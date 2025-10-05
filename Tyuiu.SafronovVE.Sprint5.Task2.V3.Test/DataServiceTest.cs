using Tyuiu.SafronovVE.Sprint5.Task2.V3.Lib;
namespace Tyuiu.SafronovVE.Sprint5.Task2.V3.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistFile()
        {
            string filePath = @"C:\Users\safro\AppData\Local\Temp\OutPutFileTask2.csv";
            FileInfo fileInfo = new FileInfo(filePath);
            
            bool fileExist = fileInfo.Exists;
            bool wait = true;

            Assert.AreEqual(wait, fileExist);
        }
    }
}
