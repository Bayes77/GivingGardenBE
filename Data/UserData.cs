using GivingGardenBE.Models;

namespace GivingGardenBE.Data
{
    public class UserData
    {
        public static List<User> Users = new()
        {
            new() {Id = 1, Name = "Casey Cunningham", Email = "CaseCunnTest@gmail.com", Image = "https://ca.slack-edge.com/T03F2SDTJ-U078T3MSH0U-57f35b70c0e6-512",},
             new() {Id = 2, Name = "Noah Allen", Email = "NoAllenTest@gmail.com", Image = "https://ca.slack-edge.com/T03F2SDTJ-U05MUF4KMNY-e42ee592a708-192",},
              new() {Id = 3, Name = "Max Jones", Email = "MonesTest@gmail.com", Image = "https://ca.slack-edge.com/T03F2SDTJ-U078T3N3URJ-1d11def4d536-72",},
               new() {Id = 4, Name = "Toren DeRamus", Email = "TormusTest@gmail.com", Image = "https://ca.slack-edge.com/T03F2SDTJ-U078J0FDSES-82600e02198b-72",},
                new() {Id = 5, Name = "Biran Shuttles", Email = "BSuttleTest@gmail.com", Image = "https://ca.slack-edge.com/T03F2SDTJ-U078QJZUQ3U-8bc62e1cae81-512",},
                 new() {Id = 6, Name = "Christopher Pack", Email = "christopherpack17@gmail.com", Image = "https://ca.slack-edge.com/T03F2SDTJ-U086UKR68LT-e9228b208df1-512",},
                  new() {Id = 7, Name = "Broc Buhler", Email = "brocbuhler@gmail.com", Image = "https://ca.slack-edge.com/T03F2SDTJ-U086UKR0JRZ-5292d6df3113-512",},
        };
    }
}
