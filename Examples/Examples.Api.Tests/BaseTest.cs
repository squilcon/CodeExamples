namespace Examples.Api.Tests
{
    /// <summary>
    /// Base class for every tests of this project
    /// </summary>
    public abstract class BaseTest
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public BaseTest()
        {
            Fixture = new Fixture();
            //To make sure that AutoFixture do not throw recursivity errors with entity that links between themselves.
            //Example: Entity Framework entities with navigation in them.
            Fixture.Behaviors.OfType<ThrowingRecursionBehavior>()
                             .ToList()
                             .ForEach(b => Fixture.Behaviors.Remove(b));
            Fixture.Behaviors.Add(new OmitOnRecursionBehavior());
        }

        protected Fixture Fixture { get; }
    }
}
