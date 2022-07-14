using ExtensionMethods.Library;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods.Tests
{
    class ConfigurationTests
    {
        [Test]
        public void IsLoaded(IConfiguration config)
        {
            IConfiguration config = null;
            Assert.IsFalse(Library.ConfigurationExtensions.IsLoaded()) ;

        }
        [Test]
        public void AddStandardProviders()
        {
            var builder = new ConfigurationBuilder();
            var config = builder.AddStandardProviders().Build();
            Assert.AreEqual(4, config.Providers.Count());
            Assert.IsTrue(Library.ConfigurationExtensions.IsLoaded());
        
        
        }
    }
}
