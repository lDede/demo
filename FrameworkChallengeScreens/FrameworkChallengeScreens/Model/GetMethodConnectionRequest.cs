using System.Collections.Generic;
using System.IO;
using System.Net;
using Newtonsoft.Json;
using FrameworkChallengeScreens.Control;

namespace FrameworkChallengeScreens.Model {
    class GetMethodConnectionRequest {
        public List<Albums> AlbumsList() {
            HttpWebRequest WebReq = (HttpWebRequest)WebRequest.Create(string.Format("https://my-json-server.typicode.com/lDede/demo/albums"));

            string values = StartGet(WebReq);
            List<Albums> items = JsonConvert.DeserializeObject<List<Albums>>(values);

            return items;
        }
        private string StartGet(HttpWebRequest WebReqParameter) {
            WebReqParameter.Method = "GET";

            HttpWebResponse WebResp = (HttpWebResponse)WebReqParameter.GetResponse();

            string jsonString;
            using(Stream stream = WebResp.GetResponseStream()) {
                StreamReader reader = new StreamReader(stream, System.Text.Encoding.UTF8);
                jsonString = reader.ReadToEnd();
            }
            return jsonString;
        }
    }
}
