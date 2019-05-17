﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Models.Models.Common
{
    public class BaseException
    {
        public int Id { get; set; }
        public bool HasError { get; set; }
        public bool IsWarning { get; set; }
        public string Message { get; set; }
    }
}