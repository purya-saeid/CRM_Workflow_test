using CRM_Workflow_test.Models;
using CRM_Workflow_test.Services;

namespace CRM_Workflow_test.Data
{
    public class SeedData
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<appDBContext>();

                context.Database.EnsureCreated();

                var user = new user
                {
                    Id = 1,
                    Name = "Test"
                };
                context.Users.Add(user);
            }
        }
    }
}
