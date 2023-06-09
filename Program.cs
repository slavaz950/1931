namespace _1931;
class Program

{
    static int ReadInt(string promt)  // Метод для целых чисел
    {
        Console.Write(promt);
        return int.Parse(Console.ReadLine());
    }
    static double ReadDouble(string promt)  // Метод для вещественных чисел
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
            double y2 = Math.Cos(x);
            Console.WriteLine("x={0} sin(x)={1} cos(x)={2}");  //,x,y1,y2
        }

    }
}