using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LemonWayForm
{
    public partial class Fibonacci10Form : Form
    {
        /// <summary>The url of the localhost.</summary>
        private const string localhostUrl = "http://localhost:54116/";

        /// <summary>The busyform (not cancellable nor closable).</summary>
        private BusyForm busyForm = new BusyForm();

        /// <summary>
        /// Constructor.
        /// </summary>
        public Fibonacci10Form()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Returns the result when the button is clicked.
        /// </summary>
        /// <param name="sender">The parameter is not used.</param>
        /// <param name="e">The parameter is not used.</param>
        private async void buttonCompute_Click(object sender, EventArgs e)
        {
            busyForm.Start();

            string result = string.Empty;

            try
            {
                result = await GetFibonacciResult(10);
            }
            catch
            {
                result = "Failed!";
            }
            finally
            {
                Thread.Sleep(2000);
                busyForm.Stop();
                lblResult.Text = $"Result of compute 10: {result}";
            }
        }

        /// <summary>
        /// Gets the result of the fibonacci sequence by the order number.
        /// </summary>
        /// <param name="n">The order number.</param>
        /// <returns>The result of the fibonacci sequence.</returns>
        private static async Task<string> GetFibonacciResult(int n)
        {
            string result;
            HttpClient client = new HttpClient()
            {
                BaseAddress = new Uri($"{localhostUrl}fibonacci/")
            };

            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response = client.GetAsync(n.ToString()).Result;

            if (response.IsSuccessStatusCode)
            {
                result = response.Content.ReadAsStringAsync().Result;
            }
            else
            {
                result = "Failed!";
            }

            return result;
        }

        /// <summary>
        /// Gets the result in Json from the xml text.
        /// </summary>
        /// <param name="sender">The parameter is not used.</param>
        /// <param name="e">The parameter is not used.</param>
        private void btnSendXml_Click(object sender, EventArgs e)
        {
            string result = string.Empty;

            try
            {
                result = PostXml(txtBoxXml.Text);
            }
            catch
            {
                result = "Failed!";
            }
            finally
            {
                txtBoxResultXmltoJson.Text = result;
            }
        }

        /// <summary>
        /// Sends the text to convert to the JSON format. 
        /// </summary>
        /// <param name="text">The text to convert to a JSON format.</param>
        /// <returns>The text in JSON, otherwise a message error.</returns>
        private string PostXml(string text)
        {
            string result;
            HttpClient client = new HttpClient()
            {
                BaseAddress = new Uri(localhostUrl)
            };

            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/x-www-form-urlencoded"));
            var credentials = new FormUrlEncodedContent(new[]
            {
                    new KeyValuePair<string, string>("xml", text)
            });

            HttpResponseMessage response = client.PostAsync("xmltojson", credentials).Result;
            result = response.Content.ReadAsStringAsync().Result;

            if (response.IsSuccessStatusCode)
            {
                result = response.Content.ReadAsStringAsync().Result;
            }
            else
            {
                result = "Failed!";
            }

            return result;
        }
    }
}
