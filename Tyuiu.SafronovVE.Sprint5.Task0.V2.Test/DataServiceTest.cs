using Tyuiu.SafronovVE.Sprint5.Task0.V2.Lib;
namespace Tyuiu.SafronovVE.Sprint5.Task0.V2.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidSaveToFileTextData()
        {
            DataService ds = new DataService();

            int x = 3;

            
            string path = @"C:\Users\safro\source\repos\Tyuiu.SafronovVE.Sprint5\Tyuiu.SafronovVE.Sprint5.Task0.V2\bin\Debug\net8.0\OutPutFileTask0.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;

            Assert.AreEqual(wait, fileExists);
        }
    }
}
