using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace dto
{
    public class message
    {
        public string id;
        public DateTime created_on;
        public string notes;
    }
}

namespace Loggable
{
    class Logger
    {
        public void Log()
        {

        }
        public string post(string url, object data)
        {
            string result = "";

            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "POST";

            using (StreamWriter streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                //string json = data.serialize();
                string json = JsonConvert.SerializeObject(data);

                streamWriter.Write(json);
                streamWriter.Flush();
                streamWriter.Close();
            }

            HttpWebResponse httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (StreamReader streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                result = streamReader.ReadToEnd();
            }

            return result;
        }
    }

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

    // degree of severity or importance
    public class Levels
    {
        public const int TRACE = 0;
        public const int DEBUG = 1;
        public const int INFO = 2;
        public const int WARNING = 3;
        public const int ERROR = 4;
        public const int CRITICAL = 5;
        // exception?
    }

    /**
     * @see https://docs.microsoft.com/en-us/aspnet/core/fundamentals/logging
     */
    public class LogEventIDs
    {
        public const int ITEM_CREATED = 1000;
        public const int ITEM_LISTED = 4000;
        public const int ITEM_UPDATED = 4001;
        public const int ITEM_NOT_FOUND = 4001;
    }


    public class Providers
    {
        int Console;
        int Debug;
        int EventSource;
        int EventLog;
        int TraceSource;
    }
}
