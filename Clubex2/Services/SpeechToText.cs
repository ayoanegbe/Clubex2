using System.Net.Http.Headers;
using System.Text;

namespace Clubex2.Services
{
    public class SpeechToText
    {
        public static async Task Transscribe()
        {
            var subscriptionKey = "<your-subscription-key>";
            var region = "<your-region>";
            var filePath = "<your-audio-file-path>";
            var endpointUrl = $"https://{region}.stt.speech.microsoft.com/speech/recognition/conversation/cognitiveservices/v1?language=en-US";

            var client = new HttpClient();
            client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", subscriptionKey);
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var audio = System.IO.File.ReadAllBytes(filePath);
            var content = new ByteArrayContent(audio);
            content.Headers.ContentType = new MediaTypeHeaderValue("audio/wav");

            var response = await client.PostAsync(endpointUrl, content);

            if (response.IsSuccessStatusCode)
            {
                var result = await response.Content.ReadAsStringAsync();
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Error: " + response.StatusCode);
            }
        }

        
    }
}
