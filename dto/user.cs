using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace business
{
    [DataContract]
    public class user
    {
        public Guid id;
        public string username;
        public password password;
    }
}
