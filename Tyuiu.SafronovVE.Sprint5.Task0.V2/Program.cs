using Tyuiu.SafronovVE.Sprint5.Task0.V2.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #5 | Выполнил: Сафронов В. Е. | ИБКСб-25-1";

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #5                                                               *");
        Console.WriteLine("* Тема: Класс File. Запись данных в текстовый файл                        *");
        Console.WriteLine("* Задание #0                                                              *");
        Console.WriteLine("* Вариант 2                                                               *");
        Console.WriteLine("* Выполнил: Сафронов Владимир Евгеньевич | ИБКСб-25-1                     *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Вычислить значение выражения при x = 3, результат сохранить в           *");
        Console.WriteLine("* текстовый файл OutPutFileTask0.txt и вывести на консоль.                *");
        Console.WriteLine("* Округлить до трёх знаков после запятой.                                 *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        int x = 3;

        Console.WriteLine("x = " + x);

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        
        string res = ds.SaveToFileTextData(x);


        Console.WriteLine("Файл: " + res);
        Console.WriteLine("Создан!");
        Console.ReadKey();
    }
}