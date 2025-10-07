namespace Tyuiu.SafronovVE.Sprint5.Task3.V12.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string tempPath = Path.GetTempPath();
            string filePath = Path.Combine($"{tempPath}", "OutPutFileTask3");
            
            FileInfo fileInfo = new FileInfo(filePath);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
