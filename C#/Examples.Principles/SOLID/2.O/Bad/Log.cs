namespace Examples.Principles.SOLID._2.O.Bad
{
    internal class Log
    {
        public void WriteLog(double area, bool writeToFile = false)
        {
            if (writeToFile)
            {
                File.AppendAllText("File path", area.ToString());
            }
            else
            {
                Console.WriteLine(area.ToString());
            }
        }        
    }
}