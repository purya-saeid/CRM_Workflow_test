using CRM_Workflow_test.Data;
using CRM_Workflow_test.Models;

using Microsoft.EntityFrameworkCore;

namespace CRM_Workflow_test.Services
{
    public class userServices
    {
        private readonly appDBContext _context;

        public userServices(appDBContext context)
        {
            _context = context;
        }

        public bool addUser(user user)
        {
            _context.Add(user);
            return Save();
        }

        public async Task<IEnumerable<user>> getAllUsers()
        {
            return await _context.Users.ToListAsync();
        }

        public bool Save()
        {
            var saved = _context.SaveChanges();
            return saved > 0 ? true : false;
        }
    }
}
