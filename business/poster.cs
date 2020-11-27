using Newtonsoft.Json;
using System.IO;
using System.Net;

namespace business
{
    //[DataContract]
    public class poster
    {
        public string post(string url, object data)
        {
            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);

            this.postdata(httpWebRequest, data);
            string result = this.readadata(httpWebRequest);

            return result;            
        }

        /**
         * Sends as JSON
         */
        private void postdata(HttpWebRequest httpWebRequest, object data)
        {
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "POST";

            using (StreamWriter streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                string json = JsonConvert.SerializeObject(data);

                streamWriter.Write(json);
                streamWriter.Flush();
                streamWriter.Close();
            }
        }

        private dynamic readadata(HttpWebRequest httpWebRequest)
        {
            string result = "";

            HttpWebResponse httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (StreamReader streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                result = streamReader.ReadToEnd();
            }

            return result;
        }
    }
}
