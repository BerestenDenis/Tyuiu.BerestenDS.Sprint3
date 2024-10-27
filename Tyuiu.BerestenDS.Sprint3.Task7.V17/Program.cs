using Tyuiu.BerestenDS.Sprint3.Task7.V17.Lib;
class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #3 | Выполнил: Берестень Д. С.  | ИБКСБ-24-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #3                                                               *");
        Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
        Console.WriteLine("* Задание #7                                                              *");
        Console.WriteLine("* Вариант #17                                                             *");
        Console.WriteLine("* Выполнил: Берестень Денис Сергеевич  | ИБКСБ 24-1                       *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        int startValue = -5;
        int stopValue = 5;
        int len = ds.GetMassFunction(startValue, stopValue).Length;
        double[] valueArray;
        valueArray = new double[len];
        valueArray = ds.GetMassFunction(startValue,stopValue);
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("+-----------+------------+");
        Console.WriteLine("|           |            |");
        Console.WriteLine("+------------+-----------+");

        for (int i = 0; i <= len-1; i++)
        {
            Console.WriteLine("|{0,5:d}      |  {1, 5:f2}     |", startValue, valueArray[i]);
            startValue++;
        }
        Console.WriteLine("+-----------+------------+");
        Console.ReadKey();
    }
}