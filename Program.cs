


using System;

namespace _1931;
//namespace CurrentTask
//{
    internal class Program
    {
        static int ReadInt(string promt)  // Метод для целых чисел
        {
            Console.Write(promt);
            return int.Parse(Console.ReadLine());
        }

        static void Main(string[] args)
        {
            int a = ReadInt("Введите число А: ");
            int b = ReadInt("Введите число В (A< B): ");
            if (a >= b)
            {
                Console.WriteLine("Число В должно быть больше числа А. Попробуйте снова");
                Console.WriteLine("Нажите любую клавишу для завершения работы приложения");
                Console.ReadKey();
                return;
            }
            // Объявление массива с экземплярами класса NumberDivisors
            NumberDivisors[] numbers = new NumberDivisors[b + 1 - a];
            // Присвоение значений элементам массива
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = new NumberDivisors(i + a);
            }

            // Сортировка элементов массива
            Array.Sort(numbers);
            // Вывод результата 
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Результат: ");
            Console.WriteLine("+---------+--------------------+");
            Console.WriteLine("|  Число  |  Кол-во делителей  |");
            Console.WriteLine("+---------+--------------------+");

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i].number == 0)
                    Console.WriteLine("| {0,7:F0} | {1,18:F0} |", numbers[i].number, '\u221E');
                else
                Console.WriteLine("| {0,7:F0} | {1,18:F0} |", numbers[i].number, numbers[i].divisors);
            }
            Console.WriteLine("+---------+--------------------+");
            Console.WriteLine("Нажите любую клавишу для завершения работы приложения");
            Console.ReadKey();
        }

        /*
         * Создадим класс NumberDivisors
         * у данного класса будет реализован интерфейс IComparable
         * для сравнения элементов класса 
         * Полями данного класса являются 
         * number - значение данного числа 
         * divisors - количество целых положительных делителей числа
         */
        class NumberDivisors : IComparable
        {
            public NumberDivisors()
            { }
            // Пользовательский конструктор принимаем одно целое число
            public NumberDivisors(int number)
            {
                this.number = number;
                /* Получаем значение поля divisors
                 Учитываем что поле number целое число, то есть может принимать как 
                положительные значения так и отрицательные
                А значение поле divisors содержит только число целых положительных делителей,
                поэтому используем Math.Abs - функцию модуля 
                Для числа 0 которое имеет бессконечное число делителей определим 
                значение поле divisors = 0 и учтем данный фыакт при построенни  функции сравнения 
                */
                int res = 0;
                for (int i = 1; i <= Math.Abs(this.number); i++)
                    if (Math.Abs(this.number) % i == 0)
                        res++;
                this.divisors = res;
            }

            public int number;
            public int divisors;

            // функция сравнения элементов класса 
            // сравниваем по значению поля divisors в порядке возрастания
            public int CompareTo(object obj)
            {
                NumberDivisors p = obj as NumberDivisors;
                if (p != null)
                {
                    // для одинаковых чисел  число его делителей совпадает
                    if (this.number == p.number)
                        return 0;
                    // варианты когда число равно нулю 
                    if (this.number == 0)
                        return 1;
                    if (p.number == 0)
                        return -1;
                    // варианты когда число делителей строго больше или меньше 
                    if (this.divisors < p.divisors)
                        return -1;
                    if (this.divisors > p.divisors)
                        return 1;
                    // варианты когда число делителей равно , тогда сравниваем по значению числа
                    if (this.divisors == p.divisors && this.number > p.number)
                        return 1;
                    else
                        return -1;
                }
                // стандартное исключенние для избегания случая ввода не корректных элементов класса 
                else
                {
                    throw new NotImplementedException("No correct value");
                }

            }
        }
    }
//}
