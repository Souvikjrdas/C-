using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise17
{
    public class CheckException : Exception
    {
        public CheckException(string msg) : base(msg)
        {

        }
    }
}
