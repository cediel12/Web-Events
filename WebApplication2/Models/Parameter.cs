﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PaginaWeb.Models
{
    public class Parameter
    {
        public string Name { get; set; }
        public string Value { get; set; }

        public Parameter(string n, string v)
        {
            Name = n;
            Value = v;
        }
    }
}