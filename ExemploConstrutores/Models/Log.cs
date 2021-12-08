using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploConstrutores.Models
{
    public class Log
    {
        private static Log _Log;

        public string PropriedadeLog { get; set; }

        private Log()
        {

        }

        public static Log GetInstance()
        {
            if (_Log == null)
            {
                _Log = new Log();
            }
            return _Log;
        }
    }
}
