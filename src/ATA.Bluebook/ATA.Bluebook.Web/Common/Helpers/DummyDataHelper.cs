using ATA.Bluebook.Web.Models.Jobs;
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

        public static List<JobModel> GetDummyJobsData()
        {
            List<JobModel> jobModels = new List<JobModel>
            {
                new JobModel(1,"J0001","Monthly Giving","Monthly Giving Campaign",new DateTime(2023, 1, 15),new DateTime(2023, 1, 30),5000,0.10m,0.50m,"A0: Anti Obama","Direct Mail","Larry Clark","Stuart Oneil","A: 10 x 13","Active","PKG001","Agency1","100%","Yes",true,false,"FC001"),
                new JobModel(2,"J0002","House","House Campaign",new DateTime(2023, 2, 10),new DateTime(2023, 2, 25),7000,0.12m,0.55m,"A1: Drug Free Kids","Email Campaign","Christopher Hiller","Brandon Bortz","B: 9 x 12","Pending","PKG002","Agency2","95%","Yes",false,true,"FC002"),
                new JobModel(3,"J0003","High $ House","High Dollar House Campaign",new DateTime(2023, 3, 5),new DateTime(2023, 3, 20),8000,0.15m,0.60m,"A2: Domestic Child Aid","Social Media","Betty Thompson","Vickie Plummer","C: 6 x 9","Completed","PKG003","Agency3","100%","No",true,false,"FC003"),
                new JobModel(4,"J0004","Prospect","Prospect Campaign",new DateTime(2023, 4, 1),new DateTime(2023, 4, 15),6000,0.11m,0.52m,"A3: International Child Aid","Telemarketing","William Lawson","Tommy Eaddy","#14","In Progress","PKG004","Agency4","80%","No",false,true,"FC004"),
                new JobModel(5,"J0005","Master File","Master File Campaign",new DateTime(2023, 5, 10),new DateTime(2023, 5, 25),9000,0.13m,0.58m,"A4: Service Dogs","TV Advertisement","Andrew Allen","Ray Williams","#12","Active","PKG005","Agency5","85%","Yes",true,false,"FC005"),
                new JobModel(6,"J0006","Modeled Names","Modeled Names Campaign",new DateTime(2023, 6, 15),new DateTime(2023, 6, 30),7500,0.14m,0.57m,"B1: General Defense/Terrorism","Print Media","Christopher Jensen","Delia Bailey","A: 10 x 13","Completed","PKG006","Agency6","90%","Yes",false,true,"FC006"),
                new JobModel(7,"J0007","Newsletter","Monthly Newsletter",new DateTime(2023, 7, 10),new DateTime(2023, 7, 25),8500,0.16m,0.59m,"B2: Homeland Security","Direct Mail","Larry Clark","Stuart Oneil","B: 9 x 12","Pending","PKG007","Agency7","70%","No",true,false,"FC007"),
                new JobModel(8,"J0008","Reactive","Reactive Campaign",new DateTime(2023, 8, 15),new DateTime(2023, 8, 30),9500,0.18m,0.61m,"B3: Strong National Defense","Email Campaign","Christopher Hiller","Brandon Bortz","C: 6 x 9","Active","PKG008","Agency8","65%","Yes",false,true,"FC008"),
                new JobModel(9,"J0009","Conversions","Conversions Campaign",new DateTime(2023, 9, 5),new DateTime(2023, 9, 20),7000,0.12m,0.55m,"B4: Second Amendment Rights","Social Media","Betty Thompson","Vickie Plummer","#14","In Progress","PKG009","Agency9","75%","No",true,false,"FC009"),
                new JobModel(10,"J0010","Thank You","Thank You Campaign",new DateTime(2023, 10, 1),new DateTime(2023, 10, 15),6500,0.11m,0.54m,"B5: Law Enforcement Defense","TV Advertisement","William Lawson","Tommy Eaddy","#12","Completed","PKG010","Agency10","85%","Yes",false,true,"FC010"),
                new JobModel(11,"J0011","Creative Fee - House","Creative Fee House Campaign",new DateTime(2023, 11, 10),new DateTime(2023, 11, 25),5000,0.10m,0.50m,"C1: English Only","Print Media","Andrew Allen","Ray Williams","A: 10 x 13","Active","PKG011","Agency11","95%","Yes",false,true,"FC011"),
                new JobModel(12,"J0012","Creative Fee - Prospect","Creative Fee Prospect Campaign",new DateTime(2023, 12, 15),new DateTime(2023, 12, 30),6000,0.12m,0.52m,"C2: Catholic General","Telemarketing","Christopher Jensen","Delia Bailey","B: 9 x 12","Completed","PKG012","Agency12","80%","No",true,false,"FC012"),
                new JobModel(13,"J0013","Closed Codes & White Mail","Closed Codes Campaign",new DateTime(2024, 1, 5),new DateTime(2024, 1, 20),7000,0.13m,0.55m,"C7: Conservative Senate Campaign","Direct Mail","Larry Clark","Stuart Oneil","C: 6 x 9","Pending","PKG013","Agency13","85%","Yes",false,true,"FC013"),
                new JobModel(14,"J0014","Sweeps","Sweeps Campaign",new DateTime(2024, 2, 10),new DateTime(2024, 2, 25),8000,0.15m,0.60m,"A0: Anti Obama","Email Campaign","Christopher Hiller","Brandon Bortz","#14","In Progress","PKG014","Agency14","70%","No",true,false,"FC014"),
                new JobModel(15,"J0015","Telemarketing","Telemarketing Campaign",new DateTime(2024, 3, 5),new DateTime(2024, 3, 20),9000,0.18m,0.65m,"A1: Drug Free Kids","Social Media","Betty Thompson","Vickie Plummer","#12","Completed","PKG015","Agency15","75%","Yes",false,true,"FC015"),
                new JobModel(16,"J0016","Email - House","House Email Campaign",new DateTime(2024, 4, 1),new DateTime(2024, 4, 15),6500,0.11m,0.54m,"A2: Domestic Child Aid","TV Advertisement","William Lawson","Tommy Eaddy","A: 10 x 13","Active","PKG016","Agency16","95%","Yes",false,true,"FC016"),
                new JobModel(17,"J0017","Email - Prospect","Prospect Email Campaign",new DateTime(2024, 5, 10),new DateTime(2024, 5, 25),7500,0.14m,0.57m,"A3: International Child Aid","Print Media","Andrew Allen","Ray Williams","B: 9 x 12","Completed","PKG017","Agency17","90%","Yes",false,true,"FC017"),
                new JobModel(18,"J0018","ATA Purchase Names - House","ATA Purchase Names House Campaign",new DateTime(2024, 6, 15),new DateTime(2024, 6, 30),8000,0.16m,0.59m,"A4: Service Dogs","Direct Mail","Christopher Jensen","Delia Bailey","C: 6 x 9","Pending","PKG018","Agency18","70%","No",true,false,"FC018"),
                new JobModel(19,"J0019","ATA Purchase Names - Prospect","ATA Purchase Names Prospect Campaign",new DateTime(2024, 7, 10),new DateTime(2024, 7, 25),9000,0.18m,0.61m,"B1: General Defense/Terrorism","Email Campaign","Larry Clark","Stuart Oneil","#14","In Progress","PKG019","Agency19","75%","No",true,false,"FC019"),
                new JobModel(20,"J0020","Non-Donor","Non-Donor Campaign",new DateTime(2024, 8, 5),new DateTime(2024, 8, 20),8500,0.15m,0.62m,"B2: Homeland Security","Social Media","Christopher Hiller","Brandon Bortz","#12","Completed","PKG020","Agency20","80%","Yes",false,true,"FC020")
            };
            return jobModels;
        }

        public static List<JobDetailModel> GetDummyJobDetailData()
        {
            List<JobDetailModel> jobDetails = new List<JobDetailModel>();

            jobDetails.Add(new JobDetailModel(1, 1,  "MC01", "ListA", new DateTime(2024, 11, 15), DateTime.Now, 1000, 1000.00M, 50.00M));
            jobDetails.Add(new JobDetailModel(2, 1, "MC02", "ListB", new DateTime(2024, 11, 20), DateTime.Now, 1500, 1500.00M, 75.00M));
            jobDetails.Add(new JobDetailModel(3, 1, "MC03", "ListC", new DateTime(2024, 11, 25), DateTime.Now, 800, 800.00M, 40.00M));
            jobDetails.Add(new JobDetailModel(4, 1, "MC04", "ListD", new DateTime(2024, 11, 18), DateTime.Now, 1200, 1200.00M, 60.00M));
            jobDetails.Add(new JobDetailModel(5, 1, "MC05", "ListE", new DateTime(2024, 11, 22), DateTime.Now, 950, 950.00M, 45.00M));
            jobDetails.Add(new JobDetailModel(6, 1, "MC06", "ListF", new DateTime(2024, 11, 17), DateTime.Now, 1100, 1100.00M, 55.00M));
            jobDetails.Add(new JobDetailModel(7, 1, "MC07", "ListG", new DateTime(2024, 12, 01), DateTime.Now, 1300, 1300.00M, 65.00M));
            jobDetails.Add(new JobDetailModel(8, 1, "MC08", "ListH", new DateTime(2024, 12, 05), DateTime.Now, 1400, 1400.00M, 70.00M));
            jobDetails.Add(new JobDetailModel(9, 1, "MC09", "ListI", new DateTime(2024, 12, 10), DateTime.Now, 1500, 1500.00M, 75.00M));
            jobDetails.Add(new JobDetailModel(10, 1, "MC10", "ListJ", new DateTime(2024, 12, 15), DateTime.Now, 1600, 1600.00M, 80.00M));
            jobDetails.Add(new JobDetailModel(11, 1, "MC11", "ListK", new DateTime(2024, 12, 20), DateTime.Now, 1700, 1700.00M, 85.00M));
            jobDetails.Add(new JobDetailModel(12, 1, "MC12", "ListL", new DateTime(2024, 12, 25), DateTime.Now, 1800, 1800.00M, 90.00M));
            jobDetails.Add(new JobDetailModel(13, 2, "MC13", "ListM", new DateTime(2024, 12, 30), DateTime.Now, 1900, 1900.00M, 95.00M));
            jobDetails.Add(new JobDetailModel(14, 2, "MC14", "ListN", new DateTime(2025, 01, 05), DateTime.Now, 2000, 2000.00M, 100.00M));
            jobDetails.Add(new JobDetailModel(15, 2, "MC15", "ListO", new DateTime(2025, 01, 10), DateTime.Now, 2100, 2100.00M, 105.00M));
            jobDetails.Add(new JobDetailModel(16, 2, "MC16", "ListP", new DateTime(2025, 01, 15), DateTime.Now, 2200, 2200.00M, 110.00M));

            return jobDetails;
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
