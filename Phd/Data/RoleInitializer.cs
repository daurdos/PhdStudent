using Microsoft.AspNetCore.Identity;
using Phd.Models;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Phd.Data
{
    public class RoleInitializer
    {
        public static async Task InitializeAsync(UserManager<User> userManager, RoleManager<IdentityRole> roleManager, PhdContext context)
        {
            string adminEmail = "admin@gmail.com";
            string password = "!QAZ1qaz";
            if (await roleManager.FindByNameAsync("admin") == null)
            {
                await roleManager.CreateAsync(new IdentityRole("admin"));
            }
            if (await roleManager.FindByNameAsync("user") == null)
            {
                await roleManager.CreateAsync(new IdentityRole("user"));
            }
            if (!context.DisCouncil.Any())
            {
                context.DisCouncil.Add(new DisCouncil { OrderNumber = "000", CouncilChairman = "CouncilChairman", CouncilSecretary = "CouncilSecretary", CouncilMember = "CouncilMember", DefenceDate = DateTime.Now });
                context.SaveChanges();
            }
            if (await userManager.FindByNameAsync(adminEmail) == null)
            {
                User admin = new User { Email = adminEmail, UserName = adminEmail, DisCouncilId = 1};
                IdentityResult result = await userManager.CreateAsync(admin, password);
                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(admin, "admin");
                }
            }
        }



    }
}
