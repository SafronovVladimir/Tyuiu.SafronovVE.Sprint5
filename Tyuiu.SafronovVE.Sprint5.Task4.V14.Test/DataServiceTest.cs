namespace Tyuiu.SafronovVE.Sprint5.Task4.V14.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = @"C:\Users\safro\source\repos\Tyuiu.SafronovVE.Sprint5\Tyuiu.SafronovVE.Sprint5.Task4.V14\bin\Debug\net8.0\InPutDataFileTask4V14.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool res = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, res);
        }
    }
}
