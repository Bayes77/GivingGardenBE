
using GivingGardenBE.Models;



namespace GivingGardenBE.Data
{
    public class OrganizationData
    {
        public static List<Organization> Organizations = new()
        {
            new() { Id = 101,  UserId = "XdynYdPxtmTU4VghjX2paBdQC9b2", Title = "HopeHarvest International", Email = "DWBtest.gmail.com", Image = "https://images.openai.com/thumbnails/39a8828844b53eb51453e3cd9e306ec8.png", Description = "Brings smiles and solar-powered radios to remote villages one playlist at a time.", Mission = "Cultivating hope and sustainable futures through global community development, education, and agricultural empowerment.",  CategoryName = "Community Development", Website = "HarvestInter@test.com", Created_at = DateTime.Now  },

            new() { Id = 102,  UserId = "XdynYdPxtmTU4VghjX2paBdQC9b2", Title = "Books for Beyond", Email = "BFBtest.gmail.com", Image = "https://m.media-amazon.com/images/I/81ukSP5PrJL._AC_UF1000%2C1000_QL80_.jpg", Description = "Delivers enchanted storybooks to children in magical lands (and a few underfunded libraries).", Mission = "Expanding minds and opportunities by delivering books and educational resources to underserved communities around the world.",  CategoryName = "Education", Website = "Beyond@test.com", Created_at = DateTime.Now },

            new() { Id = 103,  UserId = "XdynYdPxtmTU4VghjX2paBdQC9b2", Title = "Wings of Warmth", Email = "WOWtest.gmail.com", Image = "https://www.shutterstock.com/image-photo/flock-white-pelicans-soars-gracefully-over-2603037941", Description = "Knits invisible scarves for people experiencing metaphorical winters.", Mission = "To deliver warmth, comfort, and hope to vulnerable individuals through seasonal support programs, emergency aid, and community-driven outreach initiatives.",  CategoryName = "Humanitarian Aid" , Website = "WarmWing@test.com", Created_at = DateTime.Now },

            new() { Id = 104,  UserId = "XdynYdPxtmTU4VghjX2paBdQC9b2", Title = "Ocean Hug Project", Email = "OHPtest.gmail.com", Image = "https://i0.wp.com/oceanblueproject.org/wp-content/uploads/2023/05/happy-world-ocean-day-activities-ocean-blue-project-cleanup.webp?fit=2048%2C1367&ssl=1", Description = "Sends love letters and biodegradable glitter to lonely sea creatures.", Mission = "To protect and nurture our oceans through grassroots conservation efforts, education, and community engagement, inspiring a global embrace of marine stewardship.",  CategoryName ="Environment", Website = "OHP@test.com", Created_at = DateTime.Now },

            new() { Id = 105,  UserId = "XdynYdPxtmTU4VghjX2paBdQC9b2", Title = "The Giraffe Ladder Fund", Email ="TGLFtest.gmail.com", Image = "https://media.istockphoto.com/id/543346734/photo/giraffe-in-the-library.jpg?s=2048x2048&w=is&k=20&c=PgjqCSR3ad0uzcPHpnR9ji6oAmuTJFAHhp0JDL8rpas=", Description = "Helps vertically challenged animals reach their dreams (and the top shelf).", Mission = "To elevate opportunities for conservation, education, and leadership through projects that help communities—and endangered giraffes—rise to new heights.",  CategoryName = "Animal Welfare", Website = "GLF@test.com", Created_at = DateTime.Now },

            new() { Id = 106,  UserId = "9wNJQC9hfrMhjpdOUPD1wxjqLjE2", Title = "Visiting Goobers", Email = "goobers@example.com", Image = "https://i1.sndcdn.com/avatars-000127116014-hqzcna-t240x240.jpg", Description = "Helps friendless goobers get all the companions they need.", Mission = "Bring all goobers together",  CategoryName = "Humanitarian Aid", Website = "Goob@test.com", Created_at = DateTime.Now },

            new() { Id = 107,  UserId = "9wNJQC9hfrMhjpdOUPD1wxjqLjE2", Title = "American Red Shorts", Email = "theRedShorts@example.com", Image = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQAyHT6BTbA-AKsM_-FIwE382ec-uIYKOE-Vg&s", Description = "Red shorts initiative, everyone deserves a pair. Polka dots are also allowed.", Mission = "Shorts for days",  CategoryName = "Humanitarian Aid", Website = "shorts@test.com", Created_at = DateTime.Now },

            new() { Id = 108,  UserId = "9wNJQC9hfrMhjpdOUPD1wxjqLjE2", Title = "The Salvation Army’s biggest supporter", Email = "johnelmo@example.com", Image = "https://st2.depositphotos.com/3758943/6040/i/450/depositphotos_60400957-stock-photo-the-man-in-the-office.jpg", Description = "Help the salvation army by adding to my bank account.", Mission = "We shall support the cause",  CategoryName = "Humanitarian Aid", Website = "Broc@test.com", Created_at = DateTime.Now },

            new() { Id = 109,  UserId = "9wNJQC9hfrMhjpdOUPD1wxjqLjE2", Title = "Broc's Bank Account", Email = "brocbuhler@gmail.com", Image = "https://i.ytimg.com/vi/k9KAc23W48s/sddefault.jpg", Description = "One of the orgs yeah yeah", Mission = "Brocs Retirment",  CategoryName = "Education", Website = "Broc@test.com", Created_at = DateTime.Now },

            new() { Id = 110,  UserId = "9wNJQC9hfrMhjpdOUPD1wxjqLjE2", Title = "Cat", Email = "givecat@gmail.com", Image = "https://media.npr.org/assets/img/2023/12/12/gettyimages-1054147940-627235e01fb63b4644bec84204c259f0a343e35b.jpg", Description = "Give me money for cat NOW.", Mission = "Rescue all felines", CategoryName = "Animal Welfare", Website = "cat@test.com", Created_at = DateTime.Now },

            new() { Id = 111,  UserId = "9wNJQC9hfrMhjpdOUPD1wxjqLjE2", Title = "The Dark Organization", Email = "cuteSaronPIcs@mordor.com", Image = "https://i.redd.it/the-two-towers-vs-return-of-the-king-mordor-v0-b352b0r01tyb1.jpg?width=3816&format=pjpg&auto=webp&s=c3f5494c21e1ccfc774b3bb8649fcfc8a2670ea3", Description = "We are like super dark and edgy bro look at our spiky ghost king crowns and our exploding orc birth sacs.", Mission = "Bring about the rise of mordor",  CategoryName = "Environment", Website = "mordor@test.com", Created_at = DateTime.Now},
        };
    }
}
