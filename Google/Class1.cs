using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;

namespace Google
{
    public partial class Form1 
    {

        string authCode = string.Empty;
        private void LoginButton_Click(object sender, EventArgs e)
        {
            GetToken();

            //Browser.Navigate(string.Format(@"http://code.google.com/p/administrator/issues/entry?token={0}",
            //                               authCode));
        }

        private void GetToken()
        {
            //using (WebClient client = new WebClient())
            //{
            //    // Send the requeset with username and password
            //    client.Headers.Add("Content-Type", "application/x-www-form-urlencoded");

            //    string response = client.UploadString(
            //        "https://www.google.com/accounts/ClientLogin",
            //        @"accountType=HOSTED_OR_GOOGLE&Email=client-issue@mail.ru&Passwd=qwe123!@#&service=code&source=none");

            //    string[] split = response.Split('\n');


            //    foreach (string s in split)
            //    {
            //        string[] nvsplit = s.Split('=');
            //        if (nvsplit.Length == 2)
            //        {
            //            if (nvsplit[0] == "Auth")
            //            {
            //                authCode = nvsplit[1];
            //            }
            //        }
            //    }
            //}

            var request = (HttpWebRequest)WebRequest.Create("https://www.google.com/accounts/ClientLogin");

            var content =
                @"accountType=HOSTED_OR_GOOGLE&Email=client-issue@mail.ru&Passwd=qwe123!@#&service=code&source=none";

            var data = Encoding.UTF8.GetBytes(content);

            request.Method = "POST";
            request.ContentType = "application/x-www-form-urlencoded";
            request.ContentLength = data.Length;

            Stream reqStream = request.GetRequestStream();

            reqStream.Write(data, 0, data.Length);
            reqStream.Close();

            var responce = request.GetResponse();

            string respText;

            using (var respReader = new StreamReader(responce.GetResponseStream()))
            {
                respText = respReader.ReadToEnd();
            }

            AuthInfo info = new AuthInfo(respText);
        }

        void Browser_DocumentCompleted()
        {

            Thread.Sleep(1000);

            //var submit = Browser.Document.GetElementById("submit");
            //var summary = Browser.Document.GetElementById("summary");
            //var discard = Browser.Document.GetElementById("discard");


            //summary.InvokeMember("onclick");
            //summary.InvokeMember("onkeydown");
            //summary.SetAttribute("value", "fuck");
            //summary.InvokeMember("onkeyup");


            //submit.InvokeMember("focus");
            ////submit.InvokeMember("click");

        }




        private void Form1_Load(object sender, EventArgs e)
        {
            GetToken();
        }

    }

    public class AuthInfo
    {
        public string SID { get; private set; }
        public string LSID { get; private set; }
        public string Auth { get; private set; }

        public AuthInfo(string sid, string lsid, string auth)
        {
            SID = sid;
            LSID = lsid;
            Auth = auth;
        }

        public AuthInfo(string responceText)
        {
            GetDataFromResponce(responceText);
        }

        private void GetDataFromResponce(string responceText)
        {
            if (string.IsNullOrEmpty(responceText)) return;

            string[] split = responceText.Split('\n');


            foreach (string s in split)
            {
                string[] nvsplit = s.Split('=');
                if (nvsplit.Length == 2)
                {
                    if (nvsplit[0].Equals("Auth", StringComparison.InvariantCultureIgnoreCase))
                    {
                        Auth = nvsplit[1];
                    }
                    else if (nvsplit[0].Equals("SID", StringComparison.InvariantCultureIgnoreCase))
                    {
                        SID = nvsplit[1];
                    }
                    else if (nvsplit[0].Equals("LSID", StringComparison.InvariantCultureIgnoreCase))
                    {
                        LSID = nvsplit[1];
                    }
                }
            }
        }
    }
}
