using Tyuiu.SafronovVE.Sprint5.Task6.V11.Lib;
namespace Tyuiu.SafronovVE.Sprint5.Task6.V11.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckLengthCount()
        {
            DataService ds = new DataService();

            string path = Path.Combine("C:", "DataSprint5", "InPutDataFileTask6V11.txt");
            var res = ds.LoadFromDataFile(path);
            var wait = 3;
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void CheckFileExist()
        {
            string path = Path.Combine("C:", "DataSprint5", "InPutDataFileTask6V11.txt");
            FileInfo fileInfo = new FileInfo(path);
            bool res = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, res);
        }
    }
}
