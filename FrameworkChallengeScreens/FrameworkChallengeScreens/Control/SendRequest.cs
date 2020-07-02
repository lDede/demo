using System.Collections.Generic;
using FrameworkChallengeScreens.Model;

namespace FrameworkChallengeScreens.Control {

    /// <summary>
    /// Send requests to FrameworkChallengeScreens.Model and make Connections to Remove HTTP server.
    /// </summary>
    class SendRequest {

        GetMethodConnectionRequest getRequest;

        /// <summary>
        /// Return all albums created by specific user.
        /// </summary>
        /// <param name="id">User ID to retrieve informations.</param>
        /// <returns>List of Albums</returns>
        public List<Albums> RequestAlbumsByUser(int id)
        {
            getRequest = new GetMethodConnectionRequest();
            List<Albums> list = getRequest.AlbumsByUser(id);
            return list;
        }

        /// <summary>
        /// Return all posts created by specific user.
        /// </summary>
        /// <param name="id">User ID to retrieve informations.</param>
        /// <returns>List of Posts</returns>
        public List<Posts> RequestPostsByUser(int id)
        {
            getRequest = new GetMethodConnectionRequest();
            List<Posts> list = getRequest.PostsByUser(id);
            return list;
        }

        /// <summary>
        /// Return all todo lists created by specific user.
        /// </summary>
        /// <param name="id">User ID to retrieve informations.</param>
        /// <returns>List of ToDos</returns>
        public List<Todos> RequestToDosByUser(int id)
        {
            getRequest = new GetMethodConnectionRequest();
            List<Todos> list = getRequest.TodoByUser(id);
            return list;
        }

        /// <summary>
        /// Return all users from .json File.
        /// </summary>
        /// <returns>List of Users</returns>
        public List<Users> RequestUsers()
        {
            getRequest = new GetMethodConnectionRequest();
            List<Users> list = getRequest.UsersList();
            return list;
        }
    }
}