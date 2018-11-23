﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hunter.UI.Models
{
    public enum LogConstants
    {
        Info,
        Error,
        Warning
    }
    public class LogPayload
    {
        public string Category { get; set; }
        public string Subcategory { get; set; }
        public LogConstants LogCategorization { get; set; }
        public DateTime LoggingDate { get; set; }
        public string LogMessage { get; set; }
    }
}