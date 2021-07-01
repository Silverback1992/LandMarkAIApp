using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;

namespace LandMarkAI
{
    public static class CustomVisionAI
    {
        private static string _url;
        private static string _predictionKey;
        private static string _contentType;

        static CustomVisionAI()
        {
            _url = "https://westeurope.api.cognitive.microsoft.com/customvision/v3.0/Prediction/bf9dcd84-caac-47f6-85de-c7c3e611058b/classify/iterations/LandmarkModel/image";
            _predictionKey = "918d188543364c8bb87a8f8d9afa155e";
            _contentType = "application/octet-stream";
        }

        public async static void CustomVisionAIPredict(MainWindow mw, string filePath)
        {
            var f = File.ReadAllBytes(filePath);

            using(var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("Prediction-Key", _predictionKey);

                using(var content = new ByteArrayContent(f))
                {
                    content.Headers.ContentType = new MediaTypeHeaderValue(_contentType);
                    var response = await client.PostAsync(_url, content);
                    string responseString = await response.Content.ReadAsStringAsync();

                    var predictions = JsonConvert.DeserializeObject<CustomVisionResponse>(responseString).Predictions;

                    mw.Dispatcher.Invoke(() => { mw.predictionsListView.ItemsSource = predictions; });
                }
            }
        }
    }
}
