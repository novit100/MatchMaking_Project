using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP
{

    [Serializable]
    public class UserException : Exception
    {
        public string NAME;
        public UserException(string name) : base() => NAME = name;//quick initialization and call to father("base") ctor
        public UserException(string name, string message) :
            base(message) => NAME = name;
        public UserException(string name, string message, Exception innerException) :
            base(message, innerException) => NAME = name;
        //public override string ToString() => base.ToString() + $", error in line: {BUSNUMBER}";
        public override string ToString()
        {
            return Message + "\n";
        }
    }


}
