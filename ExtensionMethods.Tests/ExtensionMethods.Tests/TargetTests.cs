using ExtensionMethods.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods.Tests
{
    class TargetTests
    {
        [Test]
        public void StandardizedId()
        {
            var obj = new Target("id01");
            Assert.AreEqual("ID01",obj.GetStandardizedId());    
        }
    }
}
