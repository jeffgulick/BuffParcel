using Microsoft.EntityFrameworkCore;

namespace BuffParcel.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using var context = new PackageDbContext(serviceProvider.GetRequiredService<DbContextOptions<PackageDbContext>>());

        if (context.Residents!.Any()) 
        {
            return; //Db has been seeded
        }

        context.Residents!.AddRange(
            new Resident { Id = 1, FullName = "Kittie Mousdall", Email = "jtgulick1@buffs.wtamu.edu", UnitNumber = 101 },
            new Resident { Id = 2, FullName = "Claudette Rait", Email = "jtgulick1@buffs.wtamu.edu", UnitNumber = 102 },
            new Resident { Id = 3, FullName = "Eliza Himsworth", Email = "jtgulick1@buffs.wtamu.edu", UnitNumber = 103 },
            new Resident { Id = 4, FullName = "Emmit Gann", Email = "jtgulick1@buffs.wtamu.edu", UnitNumber = 104 },
            new Resident { Id = 5, FullName = "Aurlie Pedycan", Email = "jtgulick1@buffs.wtamu.edu", UnitNumber = 105 },
            new Resident { Id = 6, FullName = "Keriann Kettlesting", Email = "jtgulick1@buffs.wtamu.edu", UnitNumber = 106 },
            new Resident { Id = 7, FullName = "Fiorenze Iacovuzzi", Email = "jtgulick1@buffs.wtamu.edu", UnitNumber = 107 },
            new Resident { Id = 8, FullName = "Darlene Gravie", Email = "jtgulick1@buffs.wtamu.edu", UnitNumber = 108 },
            new Resident { Id = 9, FullName = "Tomasine Challener", Email = "jtgulick1@buffs.wtamu.edu", UnitNumber = 109 },
            new Resident { Id = 10, FullName = "Dotti Marple", Email = "jtgulick1@buffs.wtamu.edu", UnitNumber = 110 },
            new Resident { Id = 11, FullName = "Gabriel Tofanelli", Email = "jtgulick1@buffs.wtamu.edu", UnitNumber = 201 },
            new Resident { Id = 12, FullName = "Aldo Welldrake", Email = "jtgulick1@buffs.wtamu.edu", UnitNumber = 202 },
            new Resident { Id = 13, FullName = "Ezmeralda Laydon", Email = "jtgulick1@buffs.wtamu.edu", UnitNumber = 203 },
            new Resident { Id = 14, FullName = "Kale Lendrem", Email = "jtgulick1@buffs.wtamu.edu", UnitNumber = 204 },
            new Resident { Id = 15, FullName = "Lenard Cubbit", Email = "jtgulick1@buffs.wtamu.edu", UnitNumber = 205 },
            new Resident { Id = 16, FullName = "Dedie Caddies", Email = "jtgulick1@buffs.wtamu.edu", UnitNumber = 206 },
            new Resident { Id = 17, FullName = "Nancy Janosevic", Email = "jtgulick1@buffs.wtamu.edu", UnitNumber = 207 },
            new Resident { Id = 18, FullName = "Layne Whiterod", Email = "jtgulick1@buffs.wtamu.edu", UnitNumber = 208 },
            new Resident { Id = 19, FullName = "Averell Labusch", Email = "jtgulick1@buffs.wtamu.edu", UnitNumber = 209 },
            new Resident { Id = 20, FullName = "Gordan Raddon", Email = "jtgulick1@buffs.wtamu.edu", UnitNumber = 210 },
            new Resident { Id = 21, FullName = "Deloria Johnes", Email = "jtgulick1@buffs.wtamu.edu", UnitNumber = 301 },
            new Resident { Id = 22, FullName = "Emmett MacIllrick", Email = "jtgulick1@buffs.wtamu.edu", UnitNumber = 302 },
            new Resident { Id = 23, FullName = "Sanderson Simoncelli", Email = "jtgulick1@buffs.wtamu.edu", UnitNumber = 303 },
            new Resident { Id = 24, FullName = "Had Hapke", Email = "jtgulick1@buffs.wtamu.edu", UnitNumber = 304 },
            new Resident { Id = 25, FullName = "Bellina Rodenburgh", Email = "jtgulick1@buffs.wtamu.edu", UnitNumber = 305 },
            new Resident { Id = 26, FullName = "Portie Searle", Email = "jtgulick1@buffs.wtamu.edu", UnitNumber = 306 },
            new Resident { Id = 27, FullName = "Ellsworth Richichi", Email = "jtgulick1@buffs.wtamu.edu", UnitNumber = 307 },
            new Resident { Id = 28, FullName = "Orlando Mattholie", Email = "jtgulick1@buffs.wtamu.edu", UnitNumber = 308 },
            new Resident { Id = 29, FullName = "Noby Phelp", Email = "jtgulick1@buffs.wtamu.edu", UnitNumber = 309 },
            new Resident { Id = 30, FullName = "Wilow Caush", Email = "jtgulick1@buffs.wtamu.edu", UnitNumber = 310 },
            new Resident { Id = 31, FullName = "Hesther Wincom", Email = "jtgulick1@buffs.wtamu.edu", UnitNumber = 401 },
            new Resident { Id = 32, FullName = "Ferdie Jzhakov", Email = "jtgulick1@buffs.wtamu.edu", UnitNumber = 402 },
            new Resident { Id = 33, FullName = "Cornelia Burlingham", Email = "jtgulick1@buffs.wtamu.edu", UnitNumber = 403 },
            new Resident { Id = 34, FullName = "Rochella Childers", Email = "jtgulick1@buffs.wtamu.edu", UnitNumber = 404 },
            new Resident { Id = 35, FullName = "Jennie Christensen", Email = "jtgulick1@buffs.wtamu.edu", UnitNumber = 405 },
            new Resident { Id = 36, FullName = "Kalie Cropper", Email = "jtgulick1@buffs.wtamu.edu", UnitNumber = 406 },
            new Resident { Id = 37, FullName = "Corinne Garrison", Email = "jtgulick1@buffs.wtamu.edu", UnitNumber = 407 },
            new Resident { Id = 38, FullName = "Maybelle Pigne", Email = "jtgulick1@buffs.wtamu.edu", UnitNumber = 408 },
            new Resident { Id = 39, FullName = "Wald Kuddyhy", Email = "jtgulick1@buffs.wtamu.edu", UnitNumber = 409 },
            new Resident { Id = 40, FullName = "Blancha Ambrosoni", Email = "jtgulick1@buffs.wtamu.edu", UnitNumber = 410 },
            new Resident { Id = 41, FullName = "Gussy Moiser", Email = "jtgulick1@buffs.wtamu.edu", UnitNumber = 501 },
            new Resident { Id = 42, FullName = "Margette Symcock", Email = "jtgulick1@buffs.wtamu.edu", UnitNumber = 502 },
            new Resident { Id = 43, FullName = "Cad Stearnes", Email = "jtgulick1@buffs.wtamu.edu", UnitNumber = 503 },
            new Resident { Id = 44, FullName = "Juliann Sumner", Email = "jtgulick1@buffs.wtamu.edu", UnitNumber = 504 },
            new Resident { Id = 45, FullName = "Esdras Bresland", Email = "jtgulick1@buffs.wtamu.edu", UnitNumber = 505 },
            new Resident { Id = 46, FullName = "Alisha Laspee", Email = "jtgulick1@buffs.wtamu.edu", UnitNumber = 506 },
            new Resident { Id = 47, FullName = "Yvon Jirusek", Email = "jtgulick1@buffs.wtamu.edu", UnitNumber = 507 },
            new Resident { Id = 48, FullName = "Parrnell Halbeard", Email = "jtgulick1@buffs.wtamu.edu", UnitNumber = 508 },
            new Resident { Id = 49, FullName = "Korrie Milesap", Email = "jtgulick1@buffs.wtamu.edu", UnitNumber = 509 },
            new Resident { Id = 50, FullName = "Vivyan Petzold", Email = "jtgulick1@buffs.wtamu.edu", UnitNumber = 510 },
            new Resident { Id = 51, FullName = "Angie Darben", Email = "jtgulick1@buffs.wtamu.edu", UnitNumber = 101 },
            new Resident { Id = 52, FullName = "Eachelle Texton", Email = "jtgulick1@buffs.wtamu.edu", UnitNumber = 102 },
            new Resident { Id = 53, FullName = "Lion Imlaw", Email = "jtgulick1@buffs.wtamu.edu", UnitNumber = 103 },
            new Resident { Id = 54, FullName = "Delmore Cowhig", Email = "jtgulick1@buffs.wtamu.edu", UnitNumber = 104 },
            new Resident { Id = 55, FullName = "Shaine Van Kruis", Email = "jtgulick1@buffs.wtamu.edu", UnitNumber = 105 },
            new Resident { Id = 56, FullName = "Yehudi Jones", Email = "jtgulick1@buffs.wtamu.edu", UnitNumber = 106 },
            new Resident { Id = 57, FullName = "Hamlen Gerrad", Email = "jtgulick1@buffs.wtamu.edu", UnitNumber = 107 },
            new Resident { Id = 58, FullName = "Elisabetta Francescozzi", Email = "jtgulick1@buffs.wtamu.edu", UnitNumber = 108 },
            new Resident { Id = 59, FullName = "Gusti Chinn", Email = "jtgulick1@buffs.wtamu.edu", UnitNumber = 109 },
            new Resident { Id = 60, FullName = "Candace Hurlston", Email = "jtgulick1@buffs.wtamu.edu", UnitNumber = 110 },
            new Resident { Id = 61, FullName = "Odey Butter", Email = "jtgulick1@buffs.wtamu.edu", UnitNumber = 201 },
            new Resident { Id = 62, FullName = "Viva Bolletti", Email = "jtgulick1@buffs.wtamu.edu", UnitNumber = 202 },
            new Resident { Id = 63, FullName = "Tallie Jubert", Email = "jtgulick1@buffs.wtamu.edu", UnitNumber = 203 },
            new Resident { Id = 64, FullName = "Mary Vearnals", Email = "jtgulick1@buffs.wtamu.edu", UnitNumber = 204 },
            new Resident { Id = 65, FullName = "Lona Dunbavin", Email = "jtgulick1@buffs.wtamu.edu", UnitNumber = 205 },
            new Resident { Id = 66, FullName = "Osmond Bamlett", Email = "jtgulick1@buffs.wtamu.edu", UnitNumber = 206 },
            new Resident { Id = 67, FullName = "Nomi Sollom", Email = "jtgulick1@buffs.wtamu.edu", UnitNumber = 207 },
            new Resident { Id = 68, FullName = "Hildy Campana", Email = "jtgulick1@buffs.wtamu.edu", UnitNumber = 208 },
            new Resident { Id = 69, FullName = "Emmanuel Getcliffe", Email = "jtgulick1@buffs.wtamu.edu", UnitNumber = 209 },
            new Resident { Id = 70, FullName = "Danette Danieli", Email = "jtgulick1@buffs.wtamu.edu", UnitNumber = 210 },
            new Resident { Id = 71, FullName = "Jan Witt", Email = "jtgulick1@buffs.wtamu.edu", UnitNumber = 301 },
            new Resident { Id = 72, FullName = "Woodie Kertess", Email = "jtgulick1@buffs.wtamu.edu", UnitNumber = 302 },
            new Resident { Id = 73, FullName = "Corine Cleevely", Email = "jtgulick1@buffs.wtamu.edu", UnitNumber = 303 },
            new Resident { Id = 74, FullName = "Inez Mew", Email = "jtgulick1@buffs.wtamu.edu", UnitNumber = 304 },
            new Resident { Id = 75, FullName = "Kathie Odd", Email = "jtgulick1@buffs.wtamu.edu", UnitNumber = 305 },
            new Resident { Id = 76, FullName = "Mitch Friedlos", Email = "jtgulick1@buffs.wtamu.edu", UnitNumber = 306 },
            new Resident { Id = 77, FullName = "Bambi Gostick", Email = "jtgulick1@buffs.wtamu.edu", UnitNumber = 307 },
            new Resident { Id = 78, FullName = "Mellicent Roiz", Email = "jtgulick1@buffs.wtamu.edu", UnitNumber = 308 },
            new Resident { Id = 79, FullName = "Sukey Avon", Email = "jtgulick1@buffs.wtamu.edu", UnitNumber = 309 },
            new Resident { Id = 80, FullName = "Janina Kernan", Email = "jtgulick1@buffs.wtamu.edu", UnitNumber = 310 },
            new Resident { Id = 81, FullName = "Jaynell Pitfield", Email = "jtgulick1@buffs.wtamu.edu", UnitNumber = 401 },
            new Resident { Id = 82, FullName = "Ricki Hoppner", Email = "jtgulick1@buffs.wtamu.edu", UnitNumber = 402 },
            new Resident { Id = 83, FullName = "Rinaldo Stable", Email = "jtgulick1@buffs.wtamu.edu", UnitNumber = 403 },
            new Resident { Id = 84, FullName = "Tessy Tabour", Email = "jtgulick1@buffs.wtamu.edu", UnitNumber = 404 },
            new Resident { Id = 85, FullName = "Helen Ferencz", Email = "jtgulick1@buffs.wtamu.edu", UnitNumber = 405 },
            new Resident { Id = 86, FullName = "Korney Shakelade", Email = "jtgulick1@buffs.wtamu.edu", UnitNumber = 406 },
            new Resident { Id = 87, FullName = "Tulley Reiner", Email = "jtgulick1@buffs.wtamu.edu", UnitNumber = 407 },
            new Resident { Id = 88, FullName = "Myrle Mersh", Email = "jtgulick1@buffs.wtamu.edu", UnitNumber = 408 },
            new Resident { Id = 89, FullName = "Carina Nelthorp", Email = "jtgulick1@buffs.wtamu.edu", UnitNumber = 409 },
            new Resident { Id = 90, FullName = "Monte Trahmel", Email = "jtgulick1@buffs.wtamu.edu", UnitNumber = 410 },
            new Resident { Id = 91, FullName = "Nate Zavattero", Email = "jtgulick1@buffs.wtamu.edu", UnitNumber = 501 },
            new Resident { Id = 92, FullName = "Neddy Bucky", Email = "jtgulick1@buffs.wtamu.edu", UnitNumber = 502 },
            new Resident { Id = 93, FullName = "Allissa Collyns", Email = "jtgulick1@buffs.wtamu.edu", UnitNumber = 503 },
            new Resident { Id = 94, FullName = "Brianna Ruberry", Email = "jtgulick1@buffs.wtamu.edu", UnitNumber = 504 },
            new Resident { Id = 95, FullName = "Roxane Wellen", Email = "jtgulick1@buffs.wtamu.edu", UnitNumber = 505 },
            new Resident { Id = 96, FullName = "Ashbey Keddy", Email = "jtgulick1@buffs.wtamu.edu", UnitNumber = 506 },
            new Resident { Id = 97, FullName = "Elvin Mico", Email = "jtgulick1@buffs.wtamu.edu", UnitNumber = 507 },
            new Resident { Id = 98, FullName = "Nicolas Hanratty", Email = "jtgulick1@buffs.wtamu.edu", UnitNumber = 508 },
            new Resident { Id = 99, FullName = "Gary Jochens", Email = "jtgulick1@buffs.wtamu.edu", UnitNumber = 509 },
            new Resident { Id = 100, FullName = "Alexina Tarbard", Email = "jtgulick1@buffs.wtamu.edu", UnitNumber = 510 }
        );

        //TODO seed login users
        context.StaffLogins!.AddRange(
            new StaffLogin { StaffUsername = "alice", StaffPassword = "alice123" },
            new StaffLogin { StaffUsername = "bob", StaffPassword = "bob123" }
        );
        
        context.SaveChanges();
    }
}