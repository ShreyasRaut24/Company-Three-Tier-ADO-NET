using Company.BusinessLayer;
using Company.Model;
using Microsoft.Data.SqlClient;
using System.Data;
namespace Company.DataAccessLayer
{
    public class CompanyService : ICompanyService
    {
        public List<CompanyModel> List()
        {
            List<CompanyModel> companyModels = new List<CompanyModel>();

            SqlConnection con = new SqlConnection("Server=localhost;Database=Batch04;Integrated Security=true;trustservercertificate=true;");
            con.Open();
            SqlCommand cmd = new SqlCommand("CompanyList", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                var companyModel = new CompanyModel()
                {
                    Name = Convert.ToString(dataReader["Name"]),
                    Address = Convert.ToString(dataReader["Address"]),
                    Email = Convert.ToString(dataReader["Email"]),
                    Mobile = Convert.ToString(dataReader["Mobile"]),
                    GST = Convert.ToString(dataReader["GST"]),
                    PAN = Convert.ToString(dataReader["PAN"]),
                };
                companyModels.Add(companyModel);
            }

            return companyModels;
        }
        public int Create(CompanyModel companyModel)
        {
            SqlConnection con = new SqlConnection("Server=localhost;Database=Batch04;Integrated Security=true;trustservercertificate=true;");
            con.Open();
            SqlCommand cmd = new SqlCommand("CreateCompany", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Name", companyModel.Name);
            cmd.Parameters.AddWithValue("@Address", companyModel.Address);
            cmd.Parameters.AddWithValue("@Email", companyModel.Email);
            cmd.Parameters.AddWithValue("@Mobile", companyModel.Mobile);
            cmd.Parameters.AddWithValue("@GST", companyModel.GST);
            cmd.Parameters.AddWithValue("@PAN", companyModel.PAN);
            cmd.Parameters.AddWithValue("@IsActive", companyModel.IsActive);
            cmd.Parameters.AddWithValue("@CreatedBy", 1);
            cmd.Parameters.AddWithValue("@CreatedOn", DateTime.Now);
            cmd.Parameters.AddWithValue("@UpdatedBy", 1);
            cmd.Parameters.AddWithValue("@UpdatedOn", DateTime.Now);
            return cmd.ExecuteNonQuery();
            con.Close();
        }


    }
}
