namespace Tyuiu.SafronovVE.Sprint5.Task5.V5.Test
{
    [TestClass]
    public sealed class DataService
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = Path.Combine("C:", "DataSprint5", "InPutDataFileTask5V5.txt");
            FileInfo fileInfo = new FileInfo(path);
            bool res = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, res);
        }
    }
}
