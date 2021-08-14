using System;
using Xunit;
using Xunit.Abstractions;
using Lib4klang;

namespace Test
{
    public class PatchTest
    {
        private readonly ITestOutputHelper output;

        public PatchTest(ITestOutputHelper output)
        {
            this.output = output;
        }

        [Fact]
        public void deserialize()
        {
            Patch patch = Patch.deserialize("..\\..\\..\\Patch.4kp");
            output.WriteLine("Version" + (int)patch.version);
            Assert.Equal(patch.version, Patch.PatchType.Version10);
        }
    }
}
