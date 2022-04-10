using System;
using System.Collections.Generic;
using System.Text;

namespace _04102022.Models
{
    internal class AlreadyException:Exception
    {
        public AlreadyException(string msg):base(msg)
        {

        }
    }
}
