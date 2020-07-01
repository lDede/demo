using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace FrameworkChallengeScreens.Control {
    class UsersAddress {
        public string Street { get; set; }
        public string Suite { get; set; }
        public string City { get; set; }
        public string Zipcode { get; set; }
        public AddressGeolocalization Geo { get; set; }
    }
}
