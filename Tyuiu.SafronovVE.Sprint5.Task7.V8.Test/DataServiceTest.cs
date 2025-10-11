using Tyuiu.SafronovVE.Sprint5.Task7.V8.Lib;
namespace Tyuiu.SafronovVE.Sprint5.Task7.V8.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckFileExist()
        {
            string path = Path.Combine("C:", "DataSprint5", "InPutDataFileTask7V8.txt");
            FileInfo fileInfo = new FileInfo(path);
            bool res = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, res);
        }
    }
}
