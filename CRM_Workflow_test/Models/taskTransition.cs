using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CRM_Workflow_test.Models
{
    public class taskTransition
    {
        [Key]
        public int Id { get; set; }
        
        public int taskId { get; set; }
        public task task { get; set; }
        
        public int? childId { get; set; }
        public task? childTask { get; set; }
        public string? condition { get; set; }
    }
}
