using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace business
{
    [DataContract]
    public class password
    {
        public string algorithm;
        public string hash;
    }
}
