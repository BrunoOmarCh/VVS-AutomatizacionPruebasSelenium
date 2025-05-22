using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestAutomation.Test.PageObjetPattern.Models;

namespace TestAutomation.Test.PageObjetPattern
{
    [Parallelizable(ParallelScope.All)]
    public class TestBase
    {
        public static TestSettings TestSettings { get; set; }
        //esto hace que el atributo se ejecute una solo ves antes q todos los test
        [OneTimeSetUp]
        public void OneTimeSetup()

    }
}