using System.ComponentModel.DataAnnotations;

namespace CMS.Web.Data.Models
{
    public class Case
    {
        [Key]
        public string CaseId { get; set; }
        public string? CaseNo { get; set; }
        public string? CaseStatus { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
