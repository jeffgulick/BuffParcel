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
            new Resident {  Id = 1, FullName = "Kittie Mousdall", Email = "YOUR_WT_EMAIL", UnitNumber = 101 },
            new Resident { Id = 2, FullName = "Claudette Rait", Email = "YOUR_WT_EMAIL", UnitNumber = 102 },
            new Resident { Id = 3, FullName = "Eliza Himsworth", Email = "YOUR_WT_EMAIL", UnitNumber = 103 },
            new Resident { Id = 4, FullName = "Emmit Gann", Email = "YOUR_WT_EMAIL", UnitNumber = 104 },
            new Resident { Id = 5, FullName = "Aurlie Pedycan", Email = "YOUR_WT_EMAIL", UnitNumber = 105 },
            new Resident { Id = 6, FullName = "Keriann Kettlesting", Email = "YOUR_WT_EMAIL", UnitNumber = 106 },
            new Resident { Id = 7, FullName = "Fiorenze Iacovuzzi", Email = "YOUR_WT_EMAIL", UnitNumber = 107 },
            new Resident { Id = 8, FullName = "Darlene Gravie", Email = "YOUR_WT_EMAIL", UnitNumber = 108 },
            new Resident { Id = 9, FullName = "Tomasine Challener", Email = "YOUR_WT_EMAIL", UnitNumber = 109 },
            new Resident { Id = 10, FullName = "Dotti Marple", Email = "YOUR_WT_EMAIL", UnitNumber = 110 },
            new Resident { Id = 11, FullName = "Gabriel Tofanelli", Email = "YOUR_WT_EMAIL", UnitNumber = 201 },
            new Resident { Id = 12, FullName = "Aldo Welldrake", Email = "YOUR_WT_EMAIL", UnitNumber = 202 },
            new Resident { Id = 13, FullName = "Ezmeralda Laydon", Email = "YOUR_WT_EMAIL", UnitNumber = 203 },
            new Resident { Id = 14, FullName = "Kale Lendrem", Email = "YOUR_WT_EMAIL", UnitNumber = 204 },
            new Resident { Id = 15, FullName = "Lenard Cubbit", Email = "YOUR_WT_EMAIL", UnitNumber = 205 },
            new Resident { Id = 16, FullName = "Dedie Caddies", Email = "YOUR_WT_EMAIL", UnitNumber = 206 },
            new Resident { Id = 17, FullName = "Nancy Janosevic", Email = "YOUR_WT_EMAIL", UnitNumber = 207 },
            new Resident { Id = 18, FullName = "Layne Whiterod", Email = "YOUR_WT_EMAIL", UnitNumber = 208 },
            new Resident { Id = 19, FullName = "Averell Labusch", Email = "YOUR_WT_EMAIL", UnitNumber = 209 },
            new Resident { Id = 20, FullName = "Gordan Raddon", Email = "YOUR_WT_EMAIL", UnitNumber = 210 },
            new Resident { Id = 21, FullName = "Deloria Johnes", Email = "YOUR_WT_EMAIL", UnitNumber = 301 },
            new Resident { Id = 22, FullName = "Emmett MacIllrick", Email = "YOUR_WT_EMAIL", UnitNumber = 302 },
            new Resident { Id = 23, FullName = "Sanderson Simoncelli", Email = "YOUR_WT_EMAIL", UnitNumber = 303 },
            new Resident { Id = 24, FullName = "Had Hapke", Email = "YOUR_WT_EMAIL", UnitNumber = 304 },
            new Resident { Id = 25, FullName = "Bellina Rodenburgh", Email = "YOUR_WT_EMAIL", UnitNumber = 305 },
            new Resident { Id = 26, FullName = "Portie Searle", Email = "YOUR_WT_EMAIL", UnitNumber = 306 },
            new Resident { Id = 27, FullName = "Ellsworth Richichi", Email = "YOUR_WT_EMAIL", UnitNumber = 307 },
            new Resident { Id = 28, FullName = "Orlando Mattholie", Email = "YOUR_WT_EMAIL", UnitNumber = 308 },
            new Resident { Id = 29, FullName = "Noby Phelp", Email = "YOUR_WT_EMAIL", UnitNumber = 309 },
            new Resident { Id = 30, FullName = "Wilow Caush", Email = "YOUR_WT_EMAIL", UnitNumber = 310 },
            new Resident { Id = 31, FullName = "Hesther Wincom", Email = "YOUR_WT_EMAIL", UnitNumber = 401 },
            new Resident { Id = 32, FullName = "Ferdie Jzhakov", Email = "YOUR_WT_EMAIL", UnitNumber = 402 },
            new Resident { Id = 33, FullName = "Cornelia Burlingham", Email = "YOUR_WT_EMAIL", UnitNumber = 403 },
            new Resident { Id = 34, FullName = "Rochella Childers", Email = "YOUR_WT_EMAIL", UnitNumber = 404 },
            new Resident { Id = 35, FullName = "Jennie Christensen", Email = "YOUR_WT_EMAIL", UnitNumber = 405 },
            new Resident { Id = 36, FullName = "Kalie Cropper", Email = "YOUR_WT_EMAIL", UnitNumber = 406 },
            new Resident { Id = 37, FullName = "Corinne Garrison", Email = "YOUR_WT_EMAIL", UnitNumber = 407 },
            new Resident { Id = 38, FullName = "Maybelle Pigne", Email = "YOUR_WT_EMAIL", UnitNumber = 408 },
            new Resident { Id = 39, FullName = "Wald Kuddyhy", Email = "YOUR_WT_EMAIL", UnitNumber = 409 },
            new Resident { Id = 40, FullName = "Blancha Ambrosoni", Email = "YOUR_WT_EMAIL", UnitNumber = 410 },
            new Resident { Id = 41, FullName = "Gussy Moiser", Email = "YOUR_WT_EMAIL", UnitNumber = 501 },
            new Resident { Id = 42, FullName = "Margette Symcock", Email = "YOUR_WT_EMAIL", UnitNumber = 502 },
            new Resident { Id = 43, FullName = "Cad Stearnes", Email = "YOUR_WT_EMAIL", UnitNumber = 503 },
            new Resident { Id = 44, FullName = "Juliann Sumner", Email = "YOUR_WT_EMAIL", UnitNumber = 504 },
            new Resident { Id = 45, FullName = "Esdras Bresland", Email = "YOUR_WT_EMAIL", UnitNumber = 505 },
            new Resident { Id = 46, FullName = "Alisha Laspee", Email = "YOUR_WT_EMAIL", UnitNumber = 506 },
            new Resident { Id = 47, FullName = "Yvon Jirusek", Email = "YOUR_WT_EMAIL", UnitNumber = 507 },
            new Resident { Id = 48, FullName = "Parrnell Halbeard", Email = "YOUR_WT_EMAIL", UnitNumber = 508 },
            new Resident { Id = 49, FullName = "Korrie Milesap", Email = "YOUR_WT_EMAIL", UnitNumber = 509 },
            new Resident { Id = 50, FullName = "Vivyan Petzold", Email = "YOUR_WT_EMAIL", UnitNumber = 510 },
            new Resident { Id = 51, FullName = "Angie Darben", Email = "YOUR_WT_EMAIL", UnitNumber = 101 },
            new Resident { Id = 52, FullName = "Eachelle Texton", Email = "YOUR_WT_EMAIL", UnitNumber = 102 },
            new Resident { Id = 53, FullName = "Lion Imlaw", Email = "YOUR_WT_EMAIL", UnitNumber = 103 },
            new Resident { Id = 54, FullName = "Delmore Cowhig", Email = "YOUR_WT_EMAIL", UnitNumber = 104 },
            new Resident { Id = 55, FullName = "Shaine Van Kruis", Email = "YOUR_WT_EMAIL", UnitNumber = 105 },
            new Resident { Id = 56, FullName = "Yehudi Jones", Email = "YOUR_WT_EMAIL", UnitNumber = 106 },
            new Resident { Id = 57, FullName = "Hamlen Gerrad", Email = "YOUR_WT_EMAIL", UnitNumber = 107 },
            new Resident { Id = 58, FullName = "Elisabetta Francescozzi", Email = "YOUR_WT_EMAIL", UnitNumber = 108 },
            new Resident { Id = 59, FullName = "Gusti Chinn", Email = "YOUR_WT_EMAIL", UnitNumber = 109 },
            new Resident { Id = 60, FullName = "Candace Hurlston", Email = "YOUR_WT_EMAIL", UnitNumber = 110 },
            new Resident { Id = 61, FullName = "Odey Butter", Email = "YOUR_WT_EMAIL", UnitNumber = 201 },
            new Resident { Id = 62, FullName = "Viva Bolletti", Email = "YOUR_WT_EMAIL", UnitNumber = 202 },
            new Resident { Id = 63, FullName = "Tallie Jubert", Email = "YOUR_WT_EMAIL", UnitNumber = 203 },
            new Resident { Id = 64, FullName = "Mary Vearnals", Email = "YOUR_WT_EMAIL", UnitNumber = 204 },
            new Resident { Id = 65, FullName = "Lona Dunbavin", Email = "YOUR_WT_EMAIL", UnitNumber = 205 },
            new Resident { Id = 66, FullName = "Osmond Bamlett", Email = "YOUR_WT_EMAIL", UnitNumber = 206 },
            new Resident { Id = 67, FullName = "Nomi Sollom", Email = "YOUR_WT_EMAIL", UnitNumber = 207 },
            new Resident { Id = 68, FullName = "Hildy Campana", Email = "YOUR_WT_EMAIL", UnitNumber = 208 },
            new Resident { Id = 69, FullName = "Emmanuel Getcliffe", Email = "YOUR_WT_EMAIL", UnitNumber = 209 },
            new Resident { Id = 70, FullName = "Danette Danieli", Email = "YOUR_WT_EMAIL", UnitNumber = 210 },
            new Resident { Id = 71, FullName = "Jan Witt", Email = "YOUR_WT_EMAIL", UnitNumber = 301 },
            new Resident { Id = 72, FullName = "Woodie Kertess", Email = "YOUR_WT_EMAIL", UnitNumber = 302 },
            new Resident { Id = 73, FullName = "Corine Cleevely", Email = "YOUR_WT_EMAIL", UnitNumber = 303 },
            new Resident { Id = 74, FullName = "Inez Mew", Email = "YOUR_WT_EMAIL", UnitNumber = 304 },
            new Resident { Id = 75, FullName = "Kathie Odd", Email = "YOUR_WT_EMAIL", UnitNumber = 305 },
            new Resident { Id = 76, FullName = "Mitch Friedlos", Email = "YOUR_WT_EMAIL", UnitNumber = 306 },
            new Resident { Id = 77, FullName = "Bambi Gostick", Email = "YOUR_WT_EMAIL", UnitNumber = 307 },
            new Resident { Id = 78, FullName = "Mellicent Roiz", Email = "YOUR_WT_EMAIL", UnitNumber = 308 },
            new Resident { Id = 79, FullName = "Sukey Avon", Email = "YOUR_WT_EMAIL", UnitNumber = 309 },
            new Resident { Id = 80, FullName = "Janina Kernan", Email = "YOUR_WT_EMAIL", UnitNumber = 310 },
            new Resident { Id = 81, FullName = "Jaynell Pitfield", Email = "YOUR_WT_EMAIL", UnitNumber = 401 },
            new Resident { Id = 82, FullName = "Ricki Hoppner", Email = "YOUR_WT_EMAIL", UnitNumber = 402 },
            new Resident { Id = 83, FullName = "Rinaldo Stable", Email = "YOUR_WT_EMAIL", UnitNumber = 403 },
            new Resident { Id = 84, FullName = "Tessy Tabour", Email = "YOUR_WT_EMAIL", UnitNumber = 404 },
            new Resident { Id = 85, FullName = "Helen Ferencz", Email = "YOUR_WT_EMAIL", UnitNumber = 405 },
            new Resident { Id = 86, FullName = "Korney Shakelade", Email = "YOUR_WT_EMAIL", UnitNumber = 406 },
            new Resident { Id = 87, FullName = "Tulley Reiner", Email = "YOUR_WT_EMAIL", UnitNumber = 407 },
            new Resident { Id = 88, FullName = "Myrle Mersh", Email = "YOUR_WT_EMAIL", UnitNumber = 408 },
            new Resident { Id = 89, FullName = "Carina Nelthorp", Email = "YOUR_WT_EMAIL", UnitNumber = 409 },
            new Resident { Id = 90, FullName = "Monte Trahmel", Email = "YOUR_WT_EMAIL", UnitNumber = 410 },
            new Resident { Id = 91, FullName = "Nate Zavattero", Email = "YOUR_WT_EMAIL", UnitNumber = 501 },
            new Resident { Id = 92, FullName = "Neddy Bucky", Email = "YOUR_WT_EMAIL", UnitNumber = 502 },
            new Resident { Id = 93, FullName = "Allissa Collyns", Email = "YOUR_WT_EMAIL", UnitNumber = 503 },
            new Resident { Id = 94, FullName = "Brianna Ruberry", Email = "YOUR_WT_EMAIL", UnitNumber = 504 },
            new Resident { Id = 95, FullName = "Roxane Wellen", Email = "YOUR_WT_EMAIL", UnitNumber = 505 },
            new Resident { Id = 96, FullName = "Ashbey Keddy", Email = "YOUR_WT_EMAIL", UnitNumber = 506 },
            new Resident { Id = 97, FullName = "Elvin Mico", Email = "YOUR_WT_EMAIL", UnitNumber = 507 },
            new Resident { Id = 98, FullName = "Nicolas Hanratty", Email = "YOUR_WT_EMAIL", UnitNumber = 508 },
            new Resident { Id = 99, FullName = "Gary Jochens", Email = "YOUR_WT_EMAIL", UnitNumber = 509 },
            new Resident { Id = 100, FullName = "Alexina Tarbard", Email = "YOUR_WT_EMAIL", UnitNumber = 510 }
        );

        //TODO seed login users
        context.StaffLogins!.AddRange(
            new StaffLogin { StaffUsername = "alice", StaffPassword = "alice123" },
            new StaffLogin { StaffUsername = "bob", StaffPassword = "bob123" }
        );
        
        context.SaveChanges();
    }
}