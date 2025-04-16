using GivingGardenBE.Models;

namespace GivingGardenBE.Data
{
    public class UserData
    {
        public static List<User> User = new()
        {
            new() {Id = 1, Name = "Casey Cunningham", Email = "CaseCunnTest@gmail.com", Image = "test.png",},
             new() {Id = 2, Name = "Noah Allen", Email = "NoAllenTest@gmail.com", Image = "test.png",},
              new() {Id = 3, Name = "Max Jones", Email = "MonesTest@gmail.com", Image = "test.png",},
               new() {Id = 4, Name = "Toren DeRamus", Email = "TormusTest@gmail.com", Image = "test.png",},
                new() {Id = 5, Name = "Biran Shuttles", Email = "BSuttleTest@gmail.com", Image = "test.png",},
        };
    }
}
