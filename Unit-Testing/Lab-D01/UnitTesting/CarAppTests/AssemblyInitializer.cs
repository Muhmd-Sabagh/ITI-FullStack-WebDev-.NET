using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarAppTests
{
    [TestClass]
    public class AssemblyInitializer
    {
        [AssemblyInitialize]
        public static void AssemblyInit(TestContext context)
        {
            context.WriteLine("Assembly init");
        }

        [AssemblyCleanup]
        public static void AssemblyCleanup()
        {

        }
    }
}
