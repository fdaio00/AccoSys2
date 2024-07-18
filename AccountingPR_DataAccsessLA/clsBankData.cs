using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

public static class clsBankData
{
    public static async Task<DataTable> GetAllBanksAsync()
    {
        DataTable dt = new DataTable();

        using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
        {
            using (SqlCommand command = new SqlCommand("SP_GetAllBanks", connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                try
                {
                    await connection.OpenAsync();
                    SqlDataReader reader = await command.ExecuteReaderAsync();
                    if (reader.HasRows)
                        dt.Load(reader);// Load data into DataTable
                }
                catch (Exception ex)
                {
                    clsDataAccessSettings.SetErrorLoggingEvent(ex.Message);
                }
            }
        }

        return dt;
    }

    public static async Task<int> AddNewBankAsync(string bankNameAr, int AccountNo)
    {
        int bankID = -1;

        using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
        {
            using (SqlCommand command = new SqlCommand("SP_AddBank", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                SqlParameter output = new SqlParameter("@BankID", SqlDbType.Int)
                { Direction = ParameterDirection.Output };
                command.Parameters.Add(output);
                command.Parameters.AddWithValue("@BankNameAr", bankNameAr);
                command.Parameters.AddWithValue("@AccountNo", (object)AccountNo ?? DBNull.Value);

                try
                {
                    await connection.OpenAsync();
                    await command.ExecuteScalarAsync();
                    if (output != null)
                        bankID = Convert.ToInt32(output.Value);
                }
                catch (Exception ex)
                {
                    clsDataAccessSettings.SetErrorLoggingEvent(ex.Message);
                }
            }
        }

        return bankID;
    }

    public static async Task<bool> UpdateBankAsync(int bankID, string bankNameAr, int AccountNo)
    {
        bool success = false;

        using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
        {
            using (SqlCommand command = new SqlCommand("SP_UpdateBank", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@BankID", bankID);
                command.Parameters.AddWithValue("@BankNameAr", bankNameAr);
                command.Parameters.AddWithValue("@AccountNo", (object)AccountNo ?? DBNull.Value);

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

    public static async Task<bool> DeleteBankAsync(int bankID)
    {
        bool success = false;

        using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
        {
            using (SqlCommand command = new SqlCommand("SP_DeleteBank", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@BankID", bankID);

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

    public static bool FindBankByID(int bankID, ref string bankNameAr, ref int AccountNo)
    {

        bool isFound = false;

        using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
        {
            using (SqlCommand command = new SqlCommand("SP_GetBankByID", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@BankID", bankID);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        isFound = true;
                        bankNameAr = reader["BankNameAr"] != DBNull.Value ? Convert.ToString(reader["BankNameAr"]) : null;
                        AccountNo = reader["AccountNo"] != DBNull.Value ? Convert.ToInt32(reader["AccountNo"]) : -1;
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
