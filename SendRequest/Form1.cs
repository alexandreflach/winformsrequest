using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SendRequest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Send(string method, string url, string contentType, byte[] data)
        {
            try
            {
                WriteLine(string.Format("{0} START", Thread.CurrentThread.Name));

                WebRequest request = HttpWebRequest.Create(url) as HttpWebRequest;
                request.Method = method;
                request.ContentType = contentType;
                request.ContentLength = data.Length;

                using (Stream requestStream = request.GetRequestStream())
                {
                    requestStream.Write(data, 0, data.Length);
                    requestStream.Close();
                }

                // Get the response back  
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                WriteLine(string.Format("{0} Status: {1}", Thread.CurrentThread.Name, (int)response.StatusCode));

                Stream s = (Stream)response.GetResponseStream();
                StreamReader readStream = new StreamReader(s);
                string dataString = readStream.ReadToEnd();
                WriteLine(string.Format("{0} Body: {1}", Thread.CurrentThread.Name, dataString));
                response.Close();
                s.Close();
                readStream.Close();

                WriteLine(string.Format("{0} END", Thread.CurrentThread.Name));
            }
            catch (Exception e)
            {
                WriteLine(string.Format("{0} ERRO: {1}", Thread.CurrentThread.Name, e.Message));
            }
        }

        private delegate void WriteLineEventHandler(string message);

        private void WriteLine(string text)
        {
            if (responseText.InvokeRequired)
            {
                responseText.Invoke(new WriteLineEventHandler(WriteLine), new object[] { text });
            }
            else
            {
                responseText.AppendText(string.Format("{0} | {1}", DateTime.Now.ToString("HH:mm:ss.ffff"), text) + Environment.NewLine);
                responseText.SelectionStart = responseText.Text.Length;
                // scroll it automatically
                responseText.ScrollToCaret();
            }
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            var method = methodComboBox.Text;
            var url = urlTextBox.Text;
            var contentTpye = contentTypeTextBox.Text;
            var data = Encoding.UTF8.GetBytes(bodyBox.Text);

            for (var i = 0; i < qtdNumber.Value; i++)
            {
                var thread = new Thread(() =>
                {
                    Send(method, url, contentTpye, data);
                });
                thread.Name = (i + 1).ToString();
                thread.Start();
            }
        }
    }
}
