using System;
using System.Data;
using System.Web;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.ComponentModel;

namespace Caronte.Service
{
    /// <summary>
    /// CaronteService returns web resources as base64 encoded strings
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    public class Caronte : System.Web.Services.WebService
    {
        readonly int maxLengthKB;
        readonly string maxLimitMessage;

        public Caronte()
        {
            maxLengthKB = 2 * 1024 * 1024;
            maxLimitMessage = String.Format("Current downloads are limited to {0} bytes", maxLengthKB);
        }

        [WebMethod]
        public string Ping()
        {
            return "Pong";
        }

        [WebMethod]
        public bool GetBase64EncodedResource(String URI, out string result)
        {
            int chunkSize = 1024;
            int totalBytesRed = 0;
            int bytesRead = 0;

            WebRequest request;
            WebResponse response;
            Stream respStrm;
            List<byte> responseBytes;
            byte[] bytesChunk;

            try
            {
                request = WebRequest.Create(URI);
            }
            catch
            {
                result = "Invalid URI";
                return false;
            }

            response = request.GetResponse();

            if (response == null || response.ContentLength < 1)
            {
                result = "Error retrieving resource";
                return false;
            }

            if (response.ContentLength > maxLengthKB)
            {
                result = maxLimitMessage;
                return false;
            }

            respStrm = response.GetResponseStream();

            if (respStrm == null || !respStrm.CanRead)
            {
                result = "Error reading server response";
                return false;
            }

            responseBytes = new List<byte>();

            try
            {
                do
                {
                    bytesChunk = new byte[chunkSize];

                    bytesRead = respStrm.Read(bytesChunk, 0, chunkSize);

                    for (int i = 0; i < bytesRead; ++i)
                    {
                        responseBytes.Add(bytesChunk[i]);
                    }

                    totalBytesRed += bytesRead;

                } while (bytesRead > 0);

                respStrm.Close();

                result = Convert.ToBase64String(responseBytes.ToArray());
            }
            catch
            {
                result = "Error retrieving the resource";
                return false;
            }
            return true;
        }
    }
}
