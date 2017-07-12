using System;
using System.Collections.Generic;
using System.Net;

namespace DownloadManagement
{
    public class WebFileDownloader : IDisposable
    {
        WebClient _webClient = new WebClient();

        public bool DownloadFile(Uri addressFrom, string destination)
        {
            try
            {
                _webClient.DownloadFile(addressFrom, destination);
                return true;
            }
            catch(WebException webException)
            {
                HttpWebResponse response = webException.Response as HttpWebResponse;
                if (response?.StatusCode == HttpStatusCode.NotFound)
                {
                    return false;
                }

                throw;
            }
        }

        public bool TestUrl(Uri address)
        {
            try
            {
                _webClient.DownloadString(address);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public void Dispose()
        {
            _webClient.Dispose();
        }
    }
/*
    public class FilenameGenerator
    {
        Stack<Func<string>> _generatorsStack = new Stack<Func<string>>();
        public string Filename()
        {
            bool fileDownloaded = false;

            while(!fileDownloaded && _generatorsStack.Count > 0)
            {
                var nextGenerator = _generatorsStack.Pop();

                if (nextGenerator == null)
                {
                    throw new InvalidOperationException("No generators left.");
                }

                string fileName = nextGenerator();

                fileDownloaded = new WebFileDownloader().DownloadFile(null, fileName);
            }
        }
    }
	*/
}
