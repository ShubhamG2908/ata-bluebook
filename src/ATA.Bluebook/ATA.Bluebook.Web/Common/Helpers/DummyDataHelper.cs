using ATA.Bluebook.Web.Models.User;

namespace ATA.Bluebook.Web.Common.Helpers
{
    public class DummyDataHelper
    {
        public static List<UserModel> GetDummyUserData()
        {
            return new List<UserModel>() {
                new UserModel(1,"User 1","Password 1", "s@1d.com","User"),
                new UserModel(2,"User 2","Password 2", "s@2d.com","Agency"),
                new UserModel(3,"User 3","Password 3", "s@3d.com","Employee"),
                new UserModel(4,"User 4","Password 4", "s@4d.com","Client"),
                new UserModel(5,"User 5","Password 5", "s@5d.com","Admin"),
                new UserModel(6,"User 6","Password 6", "s@6d.com","User")
            };
        }

        public static List<UsersModel> GetDummyUsresData()
        {
            var users = new List<UsersModel>()
            {
                new UsersModel(1, UserType.Client, "Alice Johnson", "Alice M. Johnson", "alice@example.com", "123-456-7890", "password123", "alice123", "123 Main St", "Anytown", "12345", "CA"),
                new UsersModel(2, UserType.Agency, "Bob Smith", "Robert D. Smith", "bob@example.com", "987-654-3210", "password456", "bob456", "456 Elm St", "Someville", "54321", "NY"),
                new UsersModel(3, UserType.Client, "Charlie Brown", "Charles C. Brown", "charlie@example.com", "555-555-5555", "password789", "charlie789", "789 Oak St", "Anywhereville", "98765", "TX"),
                new UsersModel(4, UserType.Client, "David Lee", "David H. Lee", "david@example.com", "234-567-8901", "password901", "david901", "234 Pine St", "Othertown", "23456", "FL"),
                new UsersModel(5, UserType.Agency, "Emily Wilson", "Emily A. Wilson", "emily@example.com", "890-123-4567", "password234", "emily234", "567 Cedar St", "Somewhereville", "34567", "WA"),
                new UsersModel(6, UserType.Client, "Frank Green", "Francis G. Green", "frank@example.com", "456-789-0123", "password567", "frank567", "890 Maple St", "Nowhereville", "45678", "CO"),
                new UsersModel(7, UserType.Client, "Grace Miller", "Grace P. Miller", "grace@example.com", "345-678-9012", "password890", "grace890", "123 Oak St", "Anytown", "12345", "CA"),
                new UsersModel(8, UserType.Client, "Henry Davis", "Henry J. Davis", "henry@example.com", "901-234-5678", "password123", "henry123", "456 Pine St", "Someville", "54321", "NY"),
                new UsersModel(9, UserType.Agency, "Iris White", "Iris M. White", "iris@example.com", "567-890-1234", "password456", "iris456", "789 Cedar St", "Anywhereville", "98765", "TX"),
                new UsersModel(10, UserType.Client, "Jack Brown", "Jack T. Brown", "jack@example.com", "456-789-0123", "password789", "jack789", "234 Maple St", "Othertown", "23456", "FL"),
                new UsersModel(11, UserType.Client, "Karen Black", "Karen L. Black", "karen@example.com", "123-456-7890", "password123", "karen123", "123 Main St", "Anytown", "12345", "CA"),
                new UsersModel(12, UserType.Client, "Larry Green", "Larry M. Green", "larry@example.com", "987-654-3210", "password456", "larry456", "456 Elm St", "Someville", "54321", "NY"),
                new UsersModel(13, UserType.Client, "Michelle White", "Michelle A. White", "michelle@example.com", "555-555-5555", "password789", "michelle789", "789 Oak St", "Anywhereville", "98765", "TX"),
                new UsersModel(14, UserType.Agency, "Nathan Brown", "Nathan C. Brown", "nathan@example.com", "234-567-8901", "password901", "nathan901", "234 Pine St", "Othertown", "23456", "FL"),
                new UsersModel(15, UserType.Client, "Olivia Lee", "Olivia H. Lee", "olivia@example.com", "890-123-4567", "password234", "olivia234", "567 Cedar St", "Somewhereville", "34567", "WA"),
                new UsersModel(16, UserType.Client, "Peter Wilson", "Peter G. Wilson", "peter@example.com", "456-789-0123", "password567", "peter567", "890 Maple St", "Nowhereville", "45678", "CO"),
                new UsersModel(17, UserType.Agency, "Quinn Miller", "Quinn P. Miller", "quinn@example.com", "345-678-9012", "password890", "quinn890", "123 Oak St", "Anytown", "12345", "CA"),
                new UsersModel(18, UserType.Client, "Rachel Davis", "Rachel J. Davis", "rachel@example.com", "901-234-5678", "password123", "rachel123", "456 Pine St", "Someville", "54321", "NY"),
                new UsersModel(19, UserType.Client, "Steven White", "Steven M. White", "steven@example.com", "567-890-1234", "password456", "steven456", "789 Cedar St", "Anywhereville", "98765", "TX"),
                new UsersModel(20, UserType.Agency, "Thomas Brown", "Thomas T. Brown", "thomas@example.com", "456-789-0123", "password789", "thomas789", "234 Maple St", "Othertown", "23456", "FL"),
                new UsersModel(21, UserType.Agency, "Ursula Green", "Ursula L. Green", "ursula@example.com", "123-456-7890", "password123", "ursula123", "123 Main St", "Anytown", "12345", "CA"),
                new UsersModel(22, UserType.Agency, "Victor White", "Victor A. White", "victor@example.com", "987-654-3210", "password456", "victor456", "456 Elm St", "Someville", "54321", "NY"),
            };
            return users;
        }
    }

    public class UserModel
    {
        public UserModel() { }
        public UserModel(int id, string username, string password, string email, string userType)
        {
            Id = id;
            Username = username;
            Password = password;
            Email = email;
            UserType = userType;
        }

        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string UserType { get; set; }
    }
}
