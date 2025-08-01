using System.ComponentModel.DataAnnotations;

namespace CRM_Workflow_test.Models
{
    public class user
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
