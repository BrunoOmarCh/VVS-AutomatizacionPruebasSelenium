using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAutomation.Test.PageObjetPattern.Helpers
{
    public static class WaitHelper
    {
        public static void WaitForCondition(Func<bool> condition, int msTimeout = 4000)
        {
            // este codigo es muy util para controlar I
            var stopWatch = new Stopwatch(); // definimos una variable de tipo Stopwatch
            stopWatch.Start(); //iniciamos la variable.

    }
}
