using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimpleWebCalculator.Models
{
    public class Calculator
    {
        public int FirstNumber { get; set; }
        public int SecondNumber { get; set; }

        public string Operator { get; set; }

        public Double Result { get; set; }
    }
}