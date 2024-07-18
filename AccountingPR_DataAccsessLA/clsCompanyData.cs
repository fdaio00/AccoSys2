using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

public static class clsCompanyData
{
    public static async Task<DataTable> GetAllCompaniesAsync()
    {
        DataTable dt = new DataTable();

        using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
        {
            using (SqlCommand command = new SqlCommand("SP_GetAllCompanies", connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                try
                {
                    await connection.OpenAsync();
                    SqlDataReader reader = await command.ExecuteReaderAsync();
                   if(reader.HasRows)  
                        dt.Load(reader); // Load data into DataTable
                }
                catch (Exception ex)
                {
                    clsDataAccessSettings.SetErrorLoggingEvent(ex.Message);
                }
                
            }
        }

        return dt;
    }

    public static async Task<int> AddNewCompanyAsync(string CompanyNameAr, string CompanyNameEn , string AddressAr, string AddressEn
        , string Phone , string Fax, string Email , string Website , byte[] Logo)
    {
        int companyID = -1;

        using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
        {
            using (SqlCommand command = new SqlCommand("SP_AddCompany", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                SqlParameter CompnayIDOutPut = new SqlParameter("@CompanyID", SqlDbType.Int)
                {
                    Direction = ParameterDirection.Output
                };
                command.Parameters.Add(CompnayIDOutPut);
                command.Parameters.AddWithValue("@CompanyNameAr", CompanyNameAr);
                command.Parameters.AddWithValue("@CompanyNameEn", (object)CompanyNameEn ?? DBNull.Value);
                command.Parameters.AddWithValue("@AddressAr", AddressAr);
                command.Parameters.AddWithValue("@AddressEn", (object)AddressEn ?? DBNull.Value);
                command.Parameters.AddWithValue("@Phone", (object)Phone ?? DBNull.Value);
                command.Parameters.AddWithValue("@Fax", (object)Fax ?? DBNull.Value);
                command.Parameters.AddWithValue("@Email", (object)Email ?? DBNull.Value);
                command.Parameters.AddWithValue("@Website", (object)Website ?? DBNull.Value);
                SqlParameter imageParameter = new SqlParameter("@Logo", SqlDbType.Image);
                if(Logo!=null)
                {
                imageParameter.Value = Logo;

                }
                else
                {
                    imageParameter.Value = DBNull.Value;

                }
                command.Parameters.Add(imageParameter);
                // Handle Logo parameter if needed

                try
                {
                    await connection.OpenAsync();
                    await command.ExecuteScalarAsync();
                    if(CompnayIDOutPut!=null)
                    companyID = Convert.ToInt32(CompnayIDOutPut.Value);
                }
                catch (Exception ex)
                {
                    clsDataAccessSettings.SetErrorLoggingEvent(ex.Message);
                }
               
            }
        }

        return companyID;
    }

    public static async Task<bool> UpdateCompanyAsync(int CompanyID,string CompanyNameAr, string CompanyNameEn, string AddressAr, string AddressEn
        , string Phone, string Fax, string Email, string Website, byte[] Logo)
    {
        bool success = false;

        using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
        {
            using (SqlCommand command = new SqlCommand("SP_UpdateCompany", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@CompanyID", CompanyID);
                command.Parameters.AddWithValue("@CompanyNameAr", CompanyNameAr);
                command.Parameters.AddWithValue("@CompanyNameEn", (object)CompanyNameEn ?? DBNull.Value);
                command.Parameters.AddWithValue("@AddressAr", AddressAr);
                command.Parameters.AddWithValue("@AddressEn", (object)AddressEn ?? DBNull.Value);
                command.Parameters.AddWithValue("@Phone", (object)Phone ?? DBNull.Value);
                command.Parameters.AddWithValue("@Fax", (object)Fax ?? DBNull.Value);
                command.Parameters.AddWithValue("@Email", (object)Email ?? DBNull.Value);
                command.Parameters.AddWithValue("@Website", (object)Website ?? DBNull.Value);
                SqlParameter imageParameter = new SqlParameter("@Logo", SqlDbType.Image);
                if (Logo != null)
                {
                    imageParameter.Value = Logo;

                }
                else
                {
                    imageParameter.Value = DBNull.Value;

                }
                command.Parameters.Add(imageParameter);

                try
                {
                    await connection.OpenAsync();
                    int rowsAffected = await command.ExecuteNonQueryAsync();
                    success = rowsAffected > 0;
                }
                catch (Exception ex)
                {
                    clsDataAccessSettings.SetErrorLoggingEvent(ex.Message);
                }
                
            }
        }

        return success;
    }

    public static async Task<bool> DeleteCompanyAsync(int companyID)
    {
        bool success = false;

        using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
        {
            using (SqlCommand command = new SqlCommand("SP_DeleteCompany", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@CompanyID", companyID);

                try
                {
                    await connection.OpenAsync();
                    int rowsAffected = await command.ExecuteNonQueryAsync();
                    success = rowsAffected > 0;
                }
                catch (Exception ex)
                {
                    clsDataAccessSettings.SetErrorLoggingEvent(ex.Message);
                }
               
            }
        }

        return success;
    }

    public static bool FindCompanyByID(int companyID,
                                                       ref string companyNameArRef,
                                                       ref string companyNameEnRef,
                                                       ref string addressArRef,
                                                       ref string addressEnRef,
                                                       ref string phoneRef,
                                                       ref string faxRef,
                                                       ref string emailRef,
                                                       ref string websiteRef,
                                                       ref byte[] logoRef)
    {
        bool isFound = false;

        using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
        {
            using (SqlCommand command = new SqlCommand("SP_GetCompanyByID", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@CompanyID", companyID);

                try
                {
                     connection.Open();
                    SqlDataReader reader =  command.ExecuteReader();
                    if (reader.Read())
                    {
                        isFound = true;
                        // Set ref parameters with null check

                        companyNameArRef = reader["CompanyNameAr"] != DBNull.Value ? Convert.ToString(reader["CompanyNameAr"]) : null;
                        companyNameEnRef = reader["CompanyNameEn"] != DBNull.Value ? Convert.ToString(reader["CompanyNameEn"]) : null;
                        addressArRef = reader["AddressAr"] != DBNull.Value ? Convert.ToString(reader["AddressAr"]) : null;
                        addressEnRef = reader["AddressEn"] != DBNull.Value ? Convert.ToString(reader["AddressEn"]) : null;
                        phoneRef = reader["Phone"] != DBNull.Value ? Convert.ToString(reader["Phone"]) : null;
                        faxRef = reader["Fax"] != DBNull.Value ? Convert.ToString(reader["Fax"]) : null;
                        emailRef = reader["Email"] != DBNull.Value ? Convert.ToString(reader["Email"]) : null;
                        websiteRef = reader["Website"] != DBNull.Value ? Convert.ToString(reader["Website"]) : null;
                        if (reader["Logo"] != DBNull.Value)
                        {
                            logoRef = (byte[])reader["Logo"];
                        }
                        else
                        {
                            logoRef = null;
                        }
                        // Handle Logo property if needed
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    clsDataAccessSettings.SetErrorLoggingEvent(ex.Message);
                }
               
            }
        }

        return isFound;
    }

}
