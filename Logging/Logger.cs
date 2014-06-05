using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Diagnostics;
namespace ContosoSiteCodeFirst.Logging
{
    public class Logger : ILogging
    {
        public void Information(string message)
        {
            Trace.TraceInformation(message);
        }
        public void Information(string fmt, params object[] vars)
        {
            Trace.TraceInformation(fmt, vars);
        }

    }
}