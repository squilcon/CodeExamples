using Examples.Principles.SOLID._2.O.Good.Enums;

namespace Examples.Principles.SOLID._2.O.Good.Write
{
    internal class WriteFactory
    {
        public IWrite Instantiate(WriteType writeType)
        {
            return writeType switch
            {
                WriteType.Console => new WriteToConsole(),
                WriteType.File => new WriteToFile(),
                _ => throw new NotImplementedException()
            };
        }
    }
}
