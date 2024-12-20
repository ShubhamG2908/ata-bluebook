namespace ATA.Bluebook.Web.Models.User
{
    public class UsersModel
    {
        public int Id { get; set; }
        public UserType UserType { get; set; } = UserType.Client;
        public string? UserTypeName => Enum.GetName(UserType);
        public string Name { get; set; } = string.Empty;
        public string FullName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Contact { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string Username { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string Zip { get; set; } = string.Empty;
        public string State { get; set; } = string.Empty;
        public string? ClosedCode { get; set; }
        public string? CloseDays { get; set; }
        public string? WhiteMailCode { get; set; }
        public int? ClientId { get; set; }
        public List<int>? ClientList { get; set; }
        public string? AgencyId { get; set; }
        public bool IsActive { get; set; } = true;

        public UsersModel(
        int id,
        UserType userType,
        string name,
        string fullName,
        string email,
        string contact,
        string password,
        string username,
        string address,
        string city,
        string zip,
        string state,
        string? closedCode = null,
        string? closeDays = null,
        string? whiteMailCode = null,
        int? clientId = null,
        List<int>? clientList = null,
        string? agencyId = null
    )
        {
            Id = id;
            UserType = userType;
            Name = name;
            FullName = fullName;
            Email = email;
            Contact = contact;
            Password = password;
            Username = username;
            Address = address;
            City = city;
            Zip = zip;
            State = state;
            ClosedCode = closedCode;
            CloseDays = closeDays;
            WhiteMailCode = whiteMailCode;
            ClientId = clientId;
            ClientList = clientList;
            AgencyId = agencyId;
        }
    }
}
