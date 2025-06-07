
namespace Company.Model
{
    public class Company : BaseAuditEntity
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public string GST { get; set; }
        public string PAN { get; set; }

    }
}
