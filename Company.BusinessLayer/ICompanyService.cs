using Company.Model;
namespace Company.BusinessLayer
{
    public interface ICompanyService
    {
         List<CompanyModel> List();
         int Create(CompanyModel companyModel);
    }
}
