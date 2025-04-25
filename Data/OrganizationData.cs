
using GivingGardenBE.Models;
using static System.Net.Mime.MediaTypeNames;


namespace GivingGardenBE.Data
{
    public class OrganizationData
    {
        public static List<Organization> Organizations = new()
        {
            new() { Id = 101,  UserId = 1 ,Title = "HopeHarvest International", Email = "DWBtest.gmail.com", Image = "https://img.freepik.com/free-photo/neolithic-period-elements_23-2151786556.jpg?ga=GA1.1.1374388472.1721778201&semt=ais_hybrid&w=740", Description = "Brings smiles and solar-powered radios to remote villages one playlist at a time.",},
            new() { Id = 102,  UserId = 2 ,Title = "Books for Beyond", Email = "BFBtest.gmail.com", Image = "https://img.freepik.com/free-photo/child-with-autism-living-fantasy-world_23-2151248867.jpg?t=st=1745542694~exp=1745546294~hmac=62869ed05484fb4070c2bcd33e08251479292b39400c5f527eb6892307a5472f&w=996", Description = "Delivers enchanted storybooks to children in magical lands (and a few underfunded libraries)." },
            new() { Id = 103,  UserId = 3 ,Title = "Wings of Warmth", Email = "WOWtest.gmail.com", Image = "https://img.freepik.com/free-photo/headshot-emotive-puzzled-man-purses-lips-looks-aside-trembles-from-low-temperature-needs-warm-wears-grey-jacket-with-fur-hood_273609-47054.jpg?t=st=1745542577~exp=1745546177~hmac=cfe8b334e58d502f91fdb25d2fb22d276cd1615f95d2ec30107b4d90027b24b6&w=996", Description = "Knits invisible scarves for people experiencing metaphorical winters." },
            new() { Id = 104,  UserId = 4 ,Title = "Ocean Hug Project", Email = "OHPtest.gmail.com", Image = "https://img.freepik.com/premium-photo/high-quality-wallpaper-background-hd_783884-386282.jpg?ga=GA1.1.1374388472.1721778201&semt=ais_hybrid&w=740", Description = "Sends love letters and biodegradable glitter to lonely sea creatures." },
            new() { Id = 105,  UserId = 5 ,Title = "The Giraffe Ladder Fund", Email ="TGLFtest.gmail.com", Image = "https://www.rawpixel.com/image/16410113/png-baby-chubby-giraffe-giraffe-illustration-character#eyJrZXlzIjoiZ2lyYWZmZSBjYXJ0b29uIiwic29ydGVkS2V5cyI6ImNhcnRvb24gZ2lyYWZmZSJ9", Description = "Helps vertically challenged animals reach their dreams (and the top shelf)." },
            new() { Id = 106,  UserId = 7 ,Title = "Visiting Goobers", Email = "goobers@example.com", Image = "https://i1.sndcdn.com/avatars-000127116014-hqzcna-t240x240.jpg", Description = "Helps friendless goobers get all the companions they need." },
            new() { Id = 107,  UserId = 5 ,Title = "American Red Shorts", Email = "theRedShorts@example.com", Image = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQAyHT6BTbA-AKsM_-FIwE382ec-uIYKOE-Vg&s", Description = "Red shorts initiative, everyone deserves a pair. Polka dots are also allowed." },
            new() { Id = 108,  UserId = 6 ,Title = "The Salvation Army’s biggest supporter", Email = "johnelmo@example.com", Image = "https://st2.depositphotos.com/3758943/6040/i/450/depositphotos_60400957-stock-photo-the-man-in-the-office.jpg", Description = "Help the salvation army by adding to my bank account." },
            new() { Id = 109,  UserId = 7 ,Title = "Broc's Bank Account", Email = "brocbuhler@gmail.com", Image = "https://i.ytimg.com/vi/k9KAc23W48s/sddefault.jpg", Description = "One of the orgs yeah yeah" },
            new() { Id = 110,  UserId = 3 ,Title = "Cat", Email = "givecat@gmail.com", Image = "https://media.npr.org/assets/img/2023/12/12/gettyimages-1054147940-627235e01fb63b4644bec84204c259f0a343e35b.jpg", Description = "Give me money for cat NOW." },
            new() { Id = 111,  UserId = 4 ,Title = "The Dark Organization", Email = "cuteSaronPIcs@mordor.com", Image = "https://i.redd.it/the-two-towers-vs-return-of-the-king-mordor-v0-b352b0r01tyb1.jpg?width=3816&format=pjpg&auto=webp&s=c3f5494c21e1ccfc774b3bb8649fcfc8a2670ea3", Description = "We are like super dark and edgy bro look at our spiky ghost king crowns and our exploding orc birth sacs." },
        };
    }
}
