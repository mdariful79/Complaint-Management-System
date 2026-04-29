using System.ComponentModel.DataAnnotations;

namespace CMS.Web.Data.Models
{
    public class Case
    {
        [Key]
        public string CaseId { get; set; }
        public int? AutoCaseNo { get; set; }
        public string? CaseName { get; set; }
        public string? CaseStatus { get; set; }
        public DateTime? CreatedDate { get; set; } = DateTime.Today.Date;

        // Navigation
        public CaseIntake? CaseIntake { get; set; }
    }
}
