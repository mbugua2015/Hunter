﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hunter.CSharp.Connector
{
    public enum LogConstants
    {
        Info,
        Error,
        Warning,
        Critical
    }

    public enum LogSource
    {
        AppLogger,
        Custom
    }

    public class LogPayload
    {
        public string ApplicationId { get; set; }
        public string Category { get; set; }
        public string Subcategory { get; set; }
        public LogConstants LogCategorization { get; set; }
        public LogSource LoggingSource { get; set; }
        public DateTime LoggingDate { get; set; }
        public string LogMessage { get; set; }     
        public string OS { get; set; }
        public string IpAddress { get; set; }
        public string CpuUtilization { get; set; }
        public string MemoryUtilization { get; set; }        
        public IDictionary<object, object> Options { get; set; } = new Dictionary<object, object>();
        public object Exception { get; set; }
        public string Runtime { get; set; }
    }
}
