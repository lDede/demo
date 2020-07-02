namespace FrameworkChallengeScreens.Control {
    /// <summary>
    /// Class for retrieve address values to Users Class in .json File.
    /// </summary>
    class UsersAddress {
        public string Street { get; set; }
        public string Suite { get; set; }
        public string City { get; set; }
        public string Zipcode { get; set; }
        public AddressGeo Geo { get; set; }
    }
}