using System.Collections.Generic;
using System.IO;
using System.Net;
using Newtonsoft.Json;
using FrameworkChallengeScreens.Control;

namespace FrameworkChallengeScreens.Model {
    class GetMethodConnectionRequest {

        /// <summary>
        /// Return all albums created by specific user after retrieve from HTTP request.
        /// </summary>
        /// <param name="id">User ID to retrieve informations.</param>
        /// <returns>List of Albums</returns>
        public List<Albums> AlbumsByUser(int id)
        {
            HttpWebRequest WebReq = (HttpWebRequest)WebRequest.Create(string.Format("https://jsonplaceholder.typicode.com/albums?userId=" + id));

            //Make connection
            string values = StartGet(WebReq);

            //Store values at list
            List<Albums> items = JsonConvert.DeserializeObject<List<Albums>>(values);

            return items;
        }

        /// <summary>
        /// Return all posts created by specific user after retrieve from HTTP request.
        /// </summary>
        /// <param name="id">User ID to retrieve informations.</param>
        /// <returns>List of Posts</returns>
        public List<Posts> PostsByUser(int id)
        {
            HttpWebRequest WebReq = (HttpWebRequest)WebRequest.Create(string.Format("https://jsonplaceholder.typicode.com/posts?userId=" + id));

            //Make connection
            string values = StartGet(WebReq);

            //Store values at list
            List<Posts> items = JsonConvert.DeserializeObject<List<Posts>>(values);

            return items;
        }
        /// <summary>
        /// Return all todo lists created by specific user after retrieve from HTTP request.
        /// </summary>
        /// <param name="id">User ID to retrieve informations.</param>
        /// <returns>List of ToDos</returns>
        public List<Todos> TodoByUser(int id)
        {
            HttpWebRequest WebReq = (HttpWebRequest)WebRequest.Create(string.Format("https://jsonplaceholder.typicode.com/todos?userId=" + id));

            //Make connection
            string values = StartGet(WebReq);

            //Store values at list
            List<Todos> items = JsonConvert.DeserializeObject<List<Todos>>(values);

            return items;
        }

        /// <summary>
        /// Return all users from .json File after retrieve from HTTP request.
        /// </summary>
        /// <returns>List of Users</returns>
        public List<Users> UsersList()
        {
            HttpWebRequest WebReq = (HttpWebRequest)WebRequest.Create(string.Format("https://jsonplaceholder.typicode.com/users"));

            //Make connection
            string values = StartGet(WebReq);

            //Store values at list
            List<Users> items = JsonConvert.DeserializeObject<List<Users>>(values);

            return items;
        }

        /// <summary>
        /// Make connection, retrieve values and store in string.
        /// </summary>
        /// <param name="WebReqParameter">HttpWebRequest with connection string.</param>
        /// <returns>String with requested values.</returns>
        private string StartGet(HttpWebRequest WebReqParameter) {

            //Method of connection
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
