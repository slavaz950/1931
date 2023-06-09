namespace _1931;
class Program

{
    static int ReadInt(string promt)  // Метод для целых чисел
    {
        Console.Write(promt);
        return int.Parse(Console.ReadLine());
    }
   
    static void Main(string[] args)
    {

        int start = ReadInt ("Введите число А: "); 
        int end =   ReadInt("Введите число В (A<B):  ");
      
        Console.WriteLine("+---------+--------------------+");    
        Console.WriteLine("|  Число  |  Кол-во делителей  |");
        Console.WriteLine("+---------+--------------------+");
        
        uint divider = 0;
        for (int x = start; x<= end; x += 1){
            for(int i = 1;  i<=x; i++)
            {
                if(x%i == 0)
                divider++;
            }
            //uint divider = 0;   // Находим делитель

            double y2 = Math.Cos(x);
            Console.WriteLine("| {0,7:F3} | {1,18:F4} |",x,divider);     
        }
        Console.WriteLine("+---------+--------------------+");

    }}