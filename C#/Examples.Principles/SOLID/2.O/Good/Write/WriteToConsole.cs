namespace Examples.Principles.SOLID._2.O.Good.Write
{
    internal class WriteToConsole : IWrite
    {
        public void WriteLog(double area)
        {
            WriteLog(area.ToString());
        }

        public void WriteLog(string message)
        {
            Console.WriteLine(message);
        }
    }
}
