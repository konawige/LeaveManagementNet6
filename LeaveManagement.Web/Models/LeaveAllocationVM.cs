using LeaveManagement.Web.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LeaveManagement.Web.Models
{
    public class LeaveAllocationVM
    {
        [Required]
        public int Id { get; set; }

        [Display(Name = "Number of Days")]
        [Required]
        [Range(1,50, ErrorMessage = "Invalid Number Entered")]
        public int NumberOfDays { get; set; }
        public LeaveTypeVM? LeaveType { get; set; }
        [Required]
        public int Period { get; set; }
    }
}