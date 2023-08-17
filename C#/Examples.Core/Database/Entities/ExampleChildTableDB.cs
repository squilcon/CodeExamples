namespace Examples.Core.Database.Entities
{
    public class ExampleChildTableDB
    {
        public int ID { get; set; }
        public string Name { get; set; } = string.Empty;


        public int ParentID { get; set; }

        public ExampleParentTableDB Parent { get; set; } = new ExampleParentTableDB();
    }
}
