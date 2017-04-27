using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dto.logs
{
    public class Event
    {
        public Guid MessageID;
        public Guid UserID;
        public Guid DataTypeID;
        public Guid DataReferenceID;
        public DateTime CreatedOn;
        public string Message;
        public string RawJsonData;
    }
}
