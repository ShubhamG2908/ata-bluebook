namespace ATA.Bluebook.Web.Common.Helpers
{
    public  class DummyDataHelper
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
    }

    public class UserModel
    {
        public UserModel(int id, string username, string password, string email, string userType)
        {
            Id = id;
            Username = username;
            Password = password;
            Email = email;
            UserType = userType;
        }

        public int Id {  get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string UserType { get; set; }
    }
}
