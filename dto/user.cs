using System;

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
