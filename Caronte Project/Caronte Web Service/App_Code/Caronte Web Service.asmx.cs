using System;
using System.Data;
using System.Web;
using System.Collections;
using System.IO;
using System.Net;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.ComponentModel;

namespace CaronteProject.Service
{
    /// <summary>
    /// Summary description for Service1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [ToolboxItem(false)]
    public class Caronte : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        public string GetBase64StringFromResource(String URI)
        {
            string result = string.Empty;
            
            try
            {
                WebRequest request = WebRequest.Create(URI);
                WebResponse response = request.GetResponse();

                Stream respStrm = response.GetResponseStream();
                int length = (int)response.ContentLength;

                byte[] bytes = new byte[length];

                int numBytesRead = 0;

                while (length > 0)
                {
                    int n = respStrm.Read(bytes, numBytesRead, length);
                    if (n == 0)
                        break;
                    numBytesRead += n;
                    length -= n;
                }
                respStrm.Close();

                result = Convert.ToBase64String(bytes);
            }
            catch (Exception e)
            {
                return e.ToString();
            }
            return result;
        }
    }
}
