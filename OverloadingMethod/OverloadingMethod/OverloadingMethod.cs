using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadingMethod
{
    public class OverloadingMethod
    {
        public string HelloWorld()
        {
            return "Hello World !!";
        }

        public string HelloWorld(string pesan)
        {
            return pesan;
        }
        public string HelloWorld(string pesan, string user)
        {
            return pesan + "\tOleh : " + user;
        }
        public int HelloWorld(int status)
        {
            return status;
        }
    }

}
