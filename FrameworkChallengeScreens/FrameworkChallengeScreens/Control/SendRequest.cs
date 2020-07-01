using System;
using System.Collections.Generic;
using System.Text;
using FrameworkChallengeScreens.Model;

namespace FrameworkChallengeScreens.Control {
    class SendRequest {
        public List<Albums> RequestAlbums() {
            GetMethodConnectionRequest getRequest = new GetMethodConnectionRequest();
            List<Albums> albumsList = getRequest.GetAllAlbums();
            return albumsList;
        }
        public void CreateAlbum(Albums album)
        {
            PostConnectionRequest postRequest = new PostConnectionRequest();
            postRequest.noname(album);
        }
    }
}
