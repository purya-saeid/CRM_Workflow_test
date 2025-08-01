using CRM_Workflow_test.Models;

namespace CRM_Workflow_test.ViewModels
{
    public class homeViewModel
    {
        public IEnumerable<user>Users { get; set; }
        public IEnumerable<task> Tasks { get; set; }
        public IEnumerable<taskTransition> TasksTransitions { get; set; }
    }
}
