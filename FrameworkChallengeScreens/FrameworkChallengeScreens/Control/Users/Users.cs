using System;
using System.Collections.Generic;
using System.Text;

namespace FrameworkChallengeScreens.Control {
    class Users {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Username { get; set; }
        public UsersAddress Address { get; set; }
        public string Phone { get; set; }
        public string Website { get; set; }
        public UsersCompany Company { get; set; }
    }
}
