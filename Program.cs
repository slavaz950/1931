namespace _1931;
class Program
{
   
}




namespace Zamaraev_Task3;
class Program
{
    static int ReadInt(string promt)  // Метод для целых чисел
    {
        Console.Write(promt);
        return int.Parse(Console.ReadLine());
    }

    static int ReadDouble(string promt)  // Метод для вещественных чисел
    {
        Console.Write(promt);
        return double.Parse(Console.ReadLine());
    }

    static void Main(string[] args)
    {

        double start = ReadDouble("Введите начало промежутка:  "); 
        double end =   ReadDouble("Введите конец промежутка :  ");
        double step = ReadDouble("Введите шаг               :  ");

        for (double x = start; x<= end; x += step){
            double y1 = Math.Sin(x);
            double y1 = Math.Cos(x);
            Console.WriteLine(x + " " + y1 + " " + y2 );
        }

    }
}