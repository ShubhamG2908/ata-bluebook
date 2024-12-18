using System.Collections.Generic;
using ATA.Bluebook.Web.Models.User;

namespace ATA.Bluebook.Web.Common.Constants
{
    public class JobsConstants
    {
        // All data is temporary now. We wil get data from database after finalize
        public static readonly List<CommonUserFormSelectonModel> JobTypes = new List<CommonUserFormSelectonModel>
        {
            new CommonUserFormSelectonModel { Id = 1, Name = "Monthly Giving" },
            new CommonUserFormSelectonModel { Id = 2, Name = "House" },
            new CommonUserFormSelectonModel { Id = 3, Name = "High $ House" },
            new CommonUserFormSelectonModel { Id = 4, Name = "Prospect" },
            new CommonUserFormSelectonModel { Id = 5, Name = "Master File" },
            new CommonUserFormSelectonModel { Id = 6, Name = "Modeled Names" },
            new CommonUserFormSelectonModel { Id = 7, Name = "Newsletter" },
            new CommonUserFormSelectonModel { Id = 8, Name = "Reactive" },
            new CommonUserFormSelectonModel { Id = 9, Name = "Conversions" },
            new CommonUserFormSelectonModel { Id = 10, Name = "Thank You" },
            new CommonUserFormSelectonModel { Id = 11, Name = "Creative Fee - House" },
            new CommonUserFormSelectonModel { Id = 12, Name = "Creative Fee - Prospect" },
            new CommonUserFormSelectonModel { Id = 13, Name = "Closed Codes & White Mail" },
            new CommonUserFormSelectonModel { Id = 14, Name = "Sweeps" },
            new CommonUserFormSelectonModel { Id = 15, Name = "Telemarketing" },
            new CommonUserFormSelectonModel { Id = 16, Name = "Email - House" },
            new CommonUserFormSelectonModel { Id = 17, Name = "Email - Prospect" },
            new CommonUserFormSelectonModel { Id = 18, Name = "ATA Purchase Names - House" },
            new CommonUserFormSelectonModel { Id = 19, Name = "ATA Purchase Names - Prospect" },
            new CommonUserFormSelectonModel { Id = 20, Name = "Non-Donor" },
        };

        public static readonly List<CommonUserFormSelectonModel> PackageSizes = new List<CommonUserFormSelectonModel>
        {
            new CommonUserFormSelectonModel { Id = 1, Name = "A: 10 x 13" },
            new CommonUserFormSelectonModel { Id = 2, Name = "B: 9 x 12" },
            new CommonUserFormSelectonModel { Id = 3, Name = "C: 6 x 9" },
            new CommonUserFormSelectonModel { Id = 4, Name = "D: #14" },
            new CommonUserFormSelectonModel { Id = 5, Name = "E: #12" },
        };

        public static readonly List<CommonUserFormSelectonModel> JobIssues = new List<CommonUserFormSelectonModel>
        {
            new CommonUserFormSelectonModel { Id = 1, Name = "A0: Anti Obama" },
            new CommonUserFormSelectonModel { Id = 2, Name = "A1: Drug Free Kids" },
            new CommonUserFormSelectonModel { Id = 3, Name = "A2: Domestic Child Aid" },
            new CommonUserFormSelectonModel { Id = 4, Name = "A3: International Child Aid" },
            new CommonUserFormSelectonModel { Id = 5, Name = "A4: Service Dogs" },
            new CommonUserFormSelectonModel { Id = 6, Name = "B1: General Defense/Terrorism" },
            new CommonUserFormSelectonModel { Id = 7, Name = "B2: Homeland Security" },
            new CommonUserFormSelectonModel { Id = 8, Name = "B3: Strong National Defense" },
            new CommonUserFormSelectonModel { Id = 9, Name = "B4: Second Amendment Rights" },
            new CommonUserFormSelectonModel { Id = 10, Name = "B5: Law Enforcement Defense" },
            new CommonUserFormSelectonModel { Id = 11, Name = "C1: English Only" },
            new CommonUserFormSelectonModel { Id = 12, Name = "C2: Catholic General" },
            new CommonUserFormSelectonModel { Id = 13, Name = "C7: Conservative Senate Campaign" },
        };

        public static readonly List<CommonUserFormSelectonModel> Copywriters = new List<CommonUserFormSelectonModel>
        {
            new CommonUserFormSelectonModel { Id = 1, Name = "Larry Clark" },
            new CommonUserFormSelectonModel { Id = 2, Name = "Christopher Hiller" },
            new CommonUserFormSelectonModel { Id = 3, Name = "Betty Thompson" },
            new CommonUserFormSelectonModel { Id = 4, Name = "William Lawson" },
            new CommonUserFormSelectonModel { Id = 5, Name = "Andrew Allen" },
            new CommonUserFormSelectonModel { Id = 6, Name = "Christopher Jensen" },
        };

        public static readonly List<CommonUserFormSelectonModel> Coordinators = new List<CommonUserFormSelectonModel>
        {
            new CommonUserFormSelectonModel { Id = 1, Name = "Stuart Oneil" },
            new CommonUserFormSelectonModel { Id = 2, Name = "Brandon Bortz" },
            new CommonUserFormSelectonModel { Id = 3, Name = "Vickie Plummer" },
            new CommonUserFormSelectonModel { Id = 4, Name = "Tommy Eaddy" },
            new CommonUserFormSelectonModel { Id = 5, Name = "Ray Williams" },
            new CommonUserFormSelectonModel { Id = 6, Name = "Delia Bailey" },
        };
    }
}
