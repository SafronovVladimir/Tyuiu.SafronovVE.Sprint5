using Tyuiu.SafronovVE.Sprint5.Task5.V5.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        File.WriteAllText(Path.Combine($"{Directory.GetCurrentDirectory()}", "InPutDataFileTask5V5.txt"), "-3.09 3 3 7.48 -3.22 17.29 8 -4 0.83 14.18 -6 8.15 -8.7 -3.06 20 -4 15.82 -10 9 -3");
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