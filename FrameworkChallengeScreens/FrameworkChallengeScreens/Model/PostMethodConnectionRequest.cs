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
            Dictionary<string, Object> jsonValues = new Dictionary<string, Object>();
            jsonValues.Add("userid", album.UserId);
            jsonValues.Add("id", album.AlbumId);
            jsonValues.Add("title", album.Title);

            HttpClient client = new HttpClient();
            StringContent sc = new StringContent(JsonConvert.SerializeObject(jsonValues), UnicodeEncoding.UTF8, "application/json");
            HttpResponseMessage response = await client.PostAsync("https://my-json-server.typicode.com/lDede/demo/albums", sc);            
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
