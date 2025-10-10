using Tyuiu.SafronovVE.Sprint5.Task5.V5.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        string path = Path.Combine($"{Directory.GetCurrentDirectory()}", "InPutDataFileTask5V5.txt");

        Console.WriteLine("Файл находится: " + path);

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine(ds.LoadFromDataFile(path));

        Console.ReadKey();
    }
}