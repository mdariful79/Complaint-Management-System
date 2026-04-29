using System.ComponentModel.DataAnnotations;

namespace CMS.Web.Data.Models
{
    public class CaseIntake
    {
        [Key]
        public string CaseIntakeId { get; set; }
        public int? AutoCaseIntakeNo { get; set; }
        public string? CaseId { get; set; }
        public string? CaseName { get; set; }
        [Required]
        public bool IsAnonymous { get; set; }
        public string? ComplainantName { get; set; }
        public string? ComplainantPhone { get; set; }
        public string? ComplainantDepartment { get; set; }
        public string? ComplainantDesignation { get; set; }

        [Required]
        public int ComplaintCategoryId { get; set; }
        [Required]
        public string ComplaintName { get; set; }
        [Required]
        public string? ComplaintDescription { get; set; }
        public string? ComplaintLocation { get; set; }
        public int? UrgencyId { get; set; }
        public DateTime? DateOfOccurrence { get; set; }

        // Navigation
        public Case Case { get; set; }

    }
}
