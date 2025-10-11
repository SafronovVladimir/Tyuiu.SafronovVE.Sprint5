using Tyuiu.SafronovVE.Sprint5.Task7.V8.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        string path = Path.Combine("C:", "DataSprint5", "InPutDataFileTask7V8.txt");
        string pathToSave = Path.Combine("C:", "DataSprint5", "OutPutDataFileTask7V8.txt");

        Console.WriteLine("Файл находится: " + path);

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        var res = ds.LoadDataAndSave(path);
        Console.WriteLine("Данные сохранены по пути: " + path);

        Console.ReadKey();
    }
}