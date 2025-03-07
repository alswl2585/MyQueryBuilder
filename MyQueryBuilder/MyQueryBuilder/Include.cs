﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MyQueryBuilder
{
    public class Include
    {
        public string Name { get; set; }
        public Query Query { get; set; }
        public string ForeignKey { get; set; }
        public string LocalKey { get; set; }
        public bool IsMany { get; set; }
    }
}
