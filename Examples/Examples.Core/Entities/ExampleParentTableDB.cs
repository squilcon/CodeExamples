using System.Collections.ObjectModel;

namespace Examples.Core.Entities
{
    public class ExampleParentTableDB
    {
        public int ID { get; set; }
        public string Name { get; set; } = string.Empty;

        public ICollection<ExampleChildTableDB> Children { get; set; } = new Collection<ExampleChildTableDB>();
    }
}
