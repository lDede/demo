using System;
using System.Collections.Generic;
using System.Text;
using FrameworkChallengeScreens.Model;

namespace FrameworkChallengeScreens.Control {
    class SendRequest {
        public List<Albums> RequestAlbums() {
            GetMethodConnectionRequest getRequest = new GetMethodConnectionRequest();
            List<Albums> list = getRequest.AlbumsList();
            return list;
        }
        public void CreateAlbum(Albums album)
        {
            PostConnectionRequest postRequest = new PostConnectionRequest();
            _ = postRequest.CreateAlbumAsync(album);
        }
    }
}
