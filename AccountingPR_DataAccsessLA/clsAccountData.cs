using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

public static class clsAccountData
{
    public static async Task<DataTable> GetAllAccountsAsync()
    {
        DataTable dt = new DataTable();

        using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
        {
            using (SqlCommand command = new SqlCommand("SP_GetAllAccounts", connection))
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
    public static async Task<DataTable> SearchByAccountNo(int AccountNo)
    {
        DataTable dt = new DataTable();

        using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
        {
            using (SqlCommand command = new SqlCommand("SP_SearchByAccountNo", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@AccountNo", AccountNo);

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
      public static async Task<bool> CheckAccountHasChildren(int AccountNo)
    {
        bool IsFound = false; 
        using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
        {
            using (SqlCommand command = new SqlCommand("SP_CheckAccountHasChildren", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@AccountNo", AccountNo);

                try
                {
                    await connection.OpenAsync();
                    SqlDataReader reader = await command.ExecuteReaderAsync();
                    
                       if(reader.HasRows)  
                        IsFound = true;
                }
                catch (Exception ex)
                {
                    clsDataAccessSettings.SetErrorLoggingEvent(ex.Message);
                }
            }
        }

        return IsFound;
    }
     public static async Task<bool> SCheckAccountHasJournal(int AccountNo)
    {
        bool IsFound = false; 
        using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
        {
            using (SqlCommand command = new SqlCommand("SP_CheckAccountHasJournal", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@AccountNo", AccountNo);

                try
                {
                    await connection.OpenAsync();
                    SqlDataReader reader = await command.ExecuteReaderAsync();
                    
                       if(reader.HasRows)  
                        IsFound = true;
                }
                catch (Exception ex)
                {
                    clsDataAccessSettings.SetErrorLoggingEvent(ex.Message);
                }
            }
        }

        return IsFound;
    }

    public static async Task<bool> AddNewAccountAsync(
        int AccountNo,
        int AccountParentNo,
        string AccountNameAr,
        string AccountNameEn,
        int AccountTypeID,
        int AccountReportID,
        int AccountLevel,
        decimal AccountDebit,
        decimal AccountCredit,
        decimal AccountBalance)
    {
        int result = 0; 

        using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
        {
            using (SqlCommand command = new SqlCommand("SP_AddAccount", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@AccountNo", AccountNo);
                command.Parameters.AddWithValue("@AccountParentNo", AccountParentNo);
                command.Parameters.AddWithValue("@AccountNameAr", AccountNameAr);
                command.Parameters.AddWithValue("@AccountNameEn", (object)AccountNameEn ?? DBNull.Value);
                command.Parameters.AddWithValue("@AccountTypeID", AccountTypeID);
                command.Parameters.AddWithValue("@AccountReportID", AccountReportID);
                command.Parameters.AddWithValue("@AccountLevel", AccountLevel);
                command.Parameters.AddWithValue("@AccountDebit", AccountDebit);
                command.Parameters.AddWithValue("@AccountCredit", AccountCredit);
                command.Parameters.AddWithValue("@AccountBalance", AccountBalance);

                try
                {
                    await connection.OpenAsync();
                    result = Convert.ToInt32(await command.ExecuteNonQueryAsync());
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

        return (result>0);
    }

    public static async Task<bool> UpdateAccountAsync(
        int AccountNo,
        int AccountParentNo,
        string AccountNameAr,
        string AccountNameEn,
        int AccountTypeID,
        int AccountReportID,
        int AccountLevel,
        decimal AccountDebit,
        decimal AccountCredit,
        decimal AccountBalance)
    {
        bool success = false;

        using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
        {
            using (SqlCommand command = new SqlCommand("SP_UpdateAccount", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@AccountNo", AccountNo);
                command.Parameters.AddWithValue("@AccountParentNo", AccountParentNo);
                command.Parameters.AddWithValue("@AccountNameAr", AccountNameAr);
                command.Parameters.AddWithValue("@AccountNameEn", (object)AccountNameEn ?? DBNull.Value);
                command.Parameters.AddWithValue("@AccountTypeID", AccountTypeID);
                command.Parameters.AddWithValue("@AccountReportID", AccountReportID);
                command.Parameters.AddWithValue("@AccountLevel", AccountLevel);
                command.Parameters.AddWithValue("@AccountDebit", AccountDebit);
                command.Parameters.AddWithValue("@AccountCredit", AccountCredit);
                command.Parameters.AddWithValue("@AccountBalance", AccountBalance);

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

    public static async Task<bool> DeleteAccountAsync(int accountNo)
    {
        bool success = false;

        using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
        {
            using (SqlCommand command = new SqlCommand("SP_DeleteAccount", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@AccountNo", accountNo);

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

    public static bool FindAccountByID(
        int accountID,
        ref int accountParentNoRef,
        ref string accountNameArRef,
        ref string accountNameEnRef,
        ref int AccountTypeIDRef,
        ref int accountReportRef,
        ref int accountLevelRef,
        ref decimal accountDebitRef,
        ref decimal accountCreditRef,
        ref decimal accountBalanceRef)
    {
        bool isFound = false;

        using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
        {
            using (SqlCommand command = new SqlCommand("SP_GetAccountByID", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@AccountNo", accountID);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        isFound = true;
                        accountParentNoRef = reader["AccountParentNo"] != DBNull.Value ? Convert.ToInt32(reader["AccountParentNo"]) : 0;
                        accountNameArRef = reader["AccountNameAr"] != DBNull.Value ? Convert.ToString(reader["AccountNameAr"]) : "";
                        accountNameEnRef = reader["AccountNameEn"] != DBNull.Value ? Convert.ToString(reader["AccountNameEn"]) : null;
                        AccountTypeIDRef = reader["AccountTypeID"] != DBNull.Value ? Convert.ToInt32(reader["AccountTypeID"]) : 0;
                        accountReportRef = reader["AccountReportID"] != DBNull.Value ? Convert.ToInt32(reader["AccountReportID"]) : 0;
                        accountLevelRef = reader["AccountLevel"] != DBNull.Value ? Convert.ToInt32(reader["AccountLevel"]) : 0;
                        accountDebitRef = reader["AccountDebit"] != DBNull.Value ? Convert.ToDecimal(reader["AccountDebit"]) : 0;
                        accountCreditRef = reader["AccountCredit"] != DBNull.Value ? Convert.ToDecimal(reader["AccountCredit"]) : 0;
                        accountBalanceRef = reader["AccountBalance"] != DBNull.Value ? Convert.ToDecimal(reader["AccountBalance"]) : 0;
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
