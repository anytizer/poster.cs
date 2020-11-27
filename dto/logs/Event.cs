using System;

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
