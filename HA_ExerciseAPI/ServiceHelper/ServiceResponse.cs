using System;
using System.IO;
using System.Net;

namespace SeleniumAssignmentPart2.ServiceHelper
{
    public class ServiceResponse
    {
        StreamReader responseReader = null;
       
        public string GetServiceResponse(string URL)
        {   
            string response = null;
        
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(URL);
            request.Method = "GET";
            request.ContentType = "application/json";
            try
            {
                WebResponse webResponse = request.GetResponse();
                Stream webStream = webResponse.GetResponseStream();
                responseReader = new StreamReader(webStream);
                response = responseReader.ReadToEnd();
                if (response != null)
                {
                    return response;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception e)
            {
                Console.Out.WriteLine(e.Message);
                return null;
            }
        }

        public void CloseResponseReader()
        {
            responseReader.Close();
        }
    }
}
