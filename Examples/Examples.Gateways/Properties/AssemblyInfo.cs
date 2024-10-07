//Needed for unit tests to be able to see internal classes of this project

using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("Examples.Gateways.Tests")]
[assembly: InternalsVisibleTo("DynamicProxyGenAssembly2")]

namespace Examples.Gateways.Properties;

internal class AssemblyInfo
{
}