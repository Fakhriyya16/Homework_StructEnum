﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_SealedStruct
{
    internal sealed class Book
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        public Author Author { get; set; }
    }
}
