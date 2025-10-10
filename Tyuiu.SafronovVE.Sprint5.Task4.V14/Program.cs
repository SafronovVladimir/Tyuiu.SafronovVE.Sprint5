using System.Dynamic;
using Tyuiu.SafronovVE.Sprint5.Task4.V14.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        int x = 3;

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        string filePath = Path.GetTempPath();
        string path = Path.Combine(filePath, "InPutDataFileTask4V14.txt");
        Console.WriteLine("Файл находится: " + path);

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine(ds.LoadFromDataFile(path));
        Console.ReadKey();
    }
}