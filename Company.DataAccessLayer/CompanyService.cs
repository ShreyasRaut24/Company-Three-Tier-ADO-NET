using Company.BusinessLayer;
using Company.Model;
namespace Company.DataAccessLayer
{
    public class CompanyService : ICompanyService
    {
        public List<CompanyModel> List()
        {
            List<CompanyModel> companyModels = new List<CompanyModel>();
            return companyModels;
        }
        public int Create(CompanyModel companyModel)
        {
            return 1;
        }
    }
}
