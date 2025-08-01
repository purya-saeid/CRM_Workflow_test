using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CRM_Workflow_test.Models
{
    public class taskInstance
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        [ForeignKey("Task")]
        public int taskId { get; set; }
        public task task { get; set; }
        [ForeignKey("user")]
        public int inChargeUserId { get; set; }
        public user inChargeUser { get; set; }
        public DateTime startTime { get; set; }
        public DateTime? endTime { get; set; }
        public string status { get; set; }
    }
}
