namespace FrameworkChallengeScreens.Control {
    /// <summary>
    /// Class for retrieve values from the .json File.
    /// </summary>
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