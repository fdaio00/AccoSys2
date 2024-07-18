using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

public static class clsAccountTypeData
{
    public static async Task<DataTable> GetAllAccountTypeIDsAsync()
    {
        DataTable dt = new DataTable();

        using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
        {
            using (SqlCommand command = new SqlCommand("SP_GetAllAccountTypes", connection))
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
                    dt = null;
                }
            }
        }

        return dt;
    }

    public static async Task<int> AddNewAccountTypeAsync(string AccountTypeNameAr, string AccountTypeNameEn)
    {
        int AccountTypeIDID = -1;

        using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
        {
            using (SqlCommand command = new SqlCommand("SP_AddAccountType", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@AccountTypeNameAr", AccountTypeNameAr);
                command.Parameters.AddWithValue("@AccountTypeNameEn", (object)AccountTypeNameEn ?? DBNull.Value);

                try
                {
                    await connection.OpenAsync();
                    AccountTypeIDID = Convert.ToInt32(await command.ExecuteScalarAsync());
                }
                catch (Exception ex)
                {
                    clsDataAccessSettings.SetErrorLoggingEvent(ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        return AccountTypeIDID;
    }

    public static async Task<bool> UpdateAccountTypeAsync(int AccountTypeID, string AccountTypeNameAr, string AccountTypeNameEn)
    {
        bool success = false;

        using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
        {
            using (SqlCommand command = new SqlCommand("SP_UpdateAccountType", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@AccountTypeID", AccountTypeID);
                command.Parameters.AddWithValue("@AccountTypeNameAr", AccountTypeNameAr);
                command.Parameters.AddWithValue("@AccountTypeNameEn", (object)AccountTypeNameEn ?? DBNull.Value);

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

    public static async Task<bool> DeleteAccountTypeAsync(int AccountTypeID)
    {
        bool success = false;

        using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
        {
            using (SqlCommand command = new SqlCommand("SP_DeleteAccountType", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@AccountTypeID", AccountTypeID);

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

    public static bool FindAccountTypeByID(int AccountTypeID, ref string AccountTypeNameArRef, ref string AccountTypeNameEnRef)
    {
        bool isFound = false;

        using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
        {
            using (SqlCommand command = new SqlCommand("SP_GetAccountTypeByID", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@AccountTypeID", AccountTypeID);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        isFound = true;
                        // Set ref parameters with null check
                        AccountTypeNameArRef = reader["AccountTypeNameAr"] != DBNull.Value ? Convert.ToString(reader["AccountTypeNameAr"]) : null;
                        AccountTypeNameEnRef = reader["AccountTypeNameEn"] != DBNull.Value ? Convert.ToString(reader["AccountTypeNameEn"]) : null;
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
