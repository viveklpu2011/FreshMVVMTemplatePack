﻿using System;
using System.Collections.Generic;

namespace DuraDriveApp.Core.Models.Common
{
    public class BaseAPIResponseEntity
    {
        public string error { get; set; }
        public string error_description { get; set; }
        public string Message { get; set; }
        public Dictionary<string, string[]> ModelState { get; set; }
    }
}
