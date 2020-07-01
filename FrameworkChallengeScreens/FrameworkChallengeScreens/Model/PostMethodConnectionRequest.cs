using FrameworkChallengeScreens.Control;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Text;

namespace FrameworkChallengeScreens.Model {
    class PostConnectionRequest {
        public async System.Threading.Tasks.Task CreateAlbumAsync(Albums album)
        {
            string myJson = "{'Username':" + " ' " + album.UserId + " ' " + ", " + " ' " + album.ID + " ' " + "}";
            using (var client = new HttpClient())
            {
                var response = await client.PostAsync(
                    "https://jsonplaceholder.typicode.com/albums",
                     new StringContent(myJson, Encoding.UTF8, "application/json"));
            }
        }
        public void noname(Albums album)
        {
            var httpWebRequest = (HttpWebRequest)WebRequest.Create("https://jsonplaceholder.typicode.com/albums");
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "POST";
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;

            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {

                string json = JsonConvert.SerializeObject(album);
                streamWriter.Write(json);
                streamWriter.Flush();
                streamWriter.Close();
            }
        }
    }
}
