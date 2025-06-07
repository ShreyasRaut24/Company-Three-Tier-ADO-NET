
using System.ComponentModel.DataAnnotations;

namespace Company.Model
{
    public class CompanyModel : BaseAuditEntity
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Mobile { get; set; }
        [Required]
        public string GST { get; set; }
        [Required]
        public string PAN { get; set; }

    }
}
