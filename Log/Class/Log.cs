using Log.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Log.Class
{
    public class Log:Ilog
    {
        public void WriteLog()
        {
            Console.WriteLine("log test");
        }
    }
}
