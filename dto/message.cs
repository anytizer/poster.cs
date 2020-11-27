using Newtonsoft.Json;
using System;
using System.IO;
using System.Net;

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

    

    


    

}
