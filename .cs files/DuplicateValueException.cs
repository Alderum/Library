using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class DuplicateValueException : ApplicationException
    {
        public string Value { get; set; }
        
        public DuplicateValueException() { }
        public DuplicateValueException(string message) : base(message) { }
        public DuplicateValueException(string message, string value) : base(message)
        {
            Value = value;
        }
    }
}
