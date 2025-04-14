
using GivingGardenBE.Models;


namespace GivingGardenBE.Data
{
    public class OrganizationData
    {
        public static List<Organization> Organizations = new()
        {
            new() { Id = 101,  UserId = 1 ,Title = "HopeHarvest International", Email = "DWBtest.gmail.com", Image = "test.png", Description = "Brings smiles and solar-powered radios to remote villages one playlist at a time.",},
             new() { Id = 102,  UserId = 2 ,Title = "Books for Beyond", Email = "BFBtest.gmail.com", Image = "test.png", Description = "Delivers enchanted storybooks to children in magical lands (and a few underfunded libraries)." },
             new() { Id = 103,  UserId = 3 ,Title = "Wings of Warmth", Email = "WOWtest.gmail.com", Image = "test.png", Description = "Knits invisible scarves for people experiencing metaphorical winters." },
             new() { Id = 104,  UserId = 4 ,Title = "Ocean Hug Project", Email = "OHPtest.gmail.com", Image = "test.png", Description = "Sends love letters and biodegradable glitter to lonely sea creatures." },
              new() { Id = 105,  UserId = 5 ,Title = "The Giraffe Ladder Fund", Email = "TGLFtest.gmail.com", Image = "test.png", Description = "Helps vertically challenged animals reach their dreams (and the top shelf)." },
        };
    }
}
