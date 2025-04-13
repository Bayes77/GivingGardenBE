using GivingGardenBE.Models;

namespace GivingGardenBE.Data
{
    public class UserData
    {
        public static List<User> UserS = new()
        {
            new() {Id = 1, name = "Casey Cunningham", Email = "CaseCunnTest@gmail.com", Image = "test.png",},
             new() {Id = 2, name = "Noah Allen", Email = "NoAllenTest@gmail.com", Image = "test.png",},
              new() {Id = 3, name = "Max Jones", Email = "MonesTest@gmail.com", Image = "test.png",},
               new() {Id = 4, name = "Toren DeRamus", Email = "TormusTest@gmail.com", Image = "test.png",},
                new() {Id = 5, name = "Biran Shuttles", Email = "BSuttleTest@gmail.com", Image = "test.png",},
        };
    }
}
