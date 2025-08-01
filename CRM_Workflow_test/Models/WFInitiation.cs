using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CRM_Workflow_test.Models
{
    public class WFInitiation
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("task")]
        public int taskId { get; set; }
        public task task { get; set; }
        [ForeignKey("user")]
        public int initiatorId { get; set; }
        public user initiatorUser { get; set; }
        public DateTime startTime { get; set; }
        public DateTime? endTime { get; set; }
    }
}
