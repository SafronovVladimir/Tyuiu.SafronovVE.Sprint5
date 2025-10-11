using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.SafronovVE.Sprint5.Task6.V11.Lib
{
    public class DataService : ISprint5Task6V11
    {
        public int LoadFromDataFile(string path)
        {
            if (string.IsNullOrEmpty(path))
            {
                throw new ArgumentException("Path cannot be null or empty", nameof(path));
            }

            string? directory = Path.GetDirectoryName(path);
            if (!string.IsNullOrEmpty(directory) && !Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }

            if (!File.Exists(path))
            {
                File.WriteAllText(path, "2.24");
            }

            string str = File.ReadAllText(path);
            str = str.Replace(",", "").Replace("?", "");
            int k = 0;
            string[] strings = str.Split(' ');
            for (int i = 0; i < strings.Length; i++)
            {
                if (strings[i].Length == 6)
                {
                    k += 1;
                }
            }
            return k;
        }
    }
}
