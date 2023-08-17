namespace Examples.Principles.SOLID._2.O.Good.Write
{
    internal class WriteToFile : IWrite
    {
        public void WriteLog(double area)
        {
            WriteLog(area.ToString());
        }

        public void WriteLog(string message)
        {
            File.AppendAllText("File path", message);
        }
    }
}
