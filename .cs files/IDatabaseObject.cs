using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    internal interface IDatabaseObject
    {
        void Add();
        //Parametr that we updade and value that we insert
        void Update(string parametr, string value);
        void Delete();
    }
}
