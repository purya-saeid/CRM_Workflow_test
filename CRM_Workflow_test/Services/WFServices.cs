using CRM_Workflow_test.Data;
using CRM_Workflow_test.Models;
using Microsoft.EntityFrameworkCore;

namespace CRM_Workflow_test.Services
{
    public class WFServices
    {
        private readonly appDBContext _context;

        public WFServices(appDBContext context)
        {
            _context = context;
        }

        public bool addTask(task task)
        {
            _context.Add(task);
            return Save();
        }

        public async Task<IEnumerable<task>> getAllTasks()
        {
            return await _context.Tasks.ToListAsync();
        }

        public bool AddTaskTransition(taskTransition taskTransition)
        {
            _context.Add(taskTransition);
            return Save();
        }

        public async Task<IEnumerable<taskTransition>> getAllTaskTransitions()
        {
            return await _context.TasksTransition.ToListAsync();
        }

        public bool Save()
        {
            var saved = _context.SaveChanges();
            return saved > 0 ? true : false;
        }
    }
}
