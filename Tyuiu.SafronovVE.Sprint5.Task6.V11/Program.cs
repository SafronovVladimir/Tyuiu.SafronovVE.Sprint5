using System.IO;

using Tyuiu.SafronovVE.Sprint5.Task6.V11.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        string path = Path.Combine($"{Directory.GetCurrentDirectory()}", "InPutDataFileTask6V11.txt");

        Console.WriteLine("Файл находится: " + path);

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        int res = ds.LoadFromDataFile(path);
        Console.WriteLine(res);

        Console.ReadKey();
    }
}