using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

public static class clsJournalDetailsData
{
    public static async Task<DataTable> GetAllJournalDetailsAsync()
    {
        DataTable dt = new DataTable();

        using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
        {
            using (SqlCommand command = new SqlCommand("SP_GetAllJournalDetails", connection))
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

    public static async Task<int> AddNewJournalDetailAsync(
        int AccountID,
        decimal AccountDebit,
        decimal AccountCredit,
        string JouNote,
        int AccountCurrencyID,
        int JouID)
    {
        int journalDetailID = -1;

        using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
        {
            using (SqlCommand command = new SqlCommand("SP_AddJournalDetail", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@AccountID", (object)AccountID ?? DBNull.Value);
                command.Parameters.AddWithValue("@AccountDebit", (object)AccountDebit ?? DBNull.Value);
                command.Parameters.AddWithValue("@AccountCredit", (object)AccountCredit ?? DBNull.Value);
                command.Parameters.AddWithValue("@JouNote", (object)JouNote ?? DBNull.Value);
                command.Parameters.AddWithValue("@AccountCurrencyID", (object)AccountCurrencyID ?? DBNull.Value);
                command.Parameters.AddWithValue("@JouID", (object)JouID ?? DBNull.Value);

                try
                {
                    await connection.OpenAsync();
                    journalDetailID = Convert.ToInt32(await command.ExecuteScalarAsync());
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

        return journalDetailID;
    }

    public static async Task<bool> UpdateJournalDetailAsync(
        int JouDetalisID,
        int AccountID,
        decimal AccountDebit,
        decimal AccountCredit,
        string JouNote,
        int AccountCurrencyID,
        int JouID)
    {
        bool success = false;

        using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
        {
            using (SqlCommand command = new SqlCommand("SP_UpdateJournalDetail", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@JouDetalisID", JouDetalisID);
                command.Parameters.AddWithValue("@AccountID", (object)AccountID ?? DBNull.Value);
                command.Parameters.AddWithValue("@AccountDebit", (object)AccountDebit ?? DBNull.Value);
                command.Parameters.AddWithValue("@AccountCredit", (object)AccountCredit ?? DBNull.Value);
                command.Parameters.AddWithValue("@JouNote", (object)JouNote ?? DBNull.Value);
                command.Parameters.AddWithValue("@AccountCurrencyID", (object)AccountCurrencyID ?? DBNull.Value);
                command.Parameters.AddWithValue("@JouID", (object)JouID ?? DBNull.Value);

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

    public static async Task<bool> DeleteJournalDetailAsync(int JouDetalisID)
    {
        bool success = false;

        using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
        {
            using (SqlCommand command = new SqlCommand("SP_DeleteJournalDetail", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@JouDetalisID", JouDetalisID);

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

    public static bool FindJournalDetailByID(
        int JouDetalisID,
        ref int? AccountIDRef,
        ref decimal? AccountDebitRef,
        ref decimal? AccountCreditRef,
        ref string JouNoteRef,
        ref int? AccountCurrencyIDRef,
        ref int? JouIDRef)
    {
        bool isFound = false;

        using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
        {
            using (SqlCommand command = new SqlCommand("SP_GetJournalDetailByID", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@JouDetalisID", JouDetalisID);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        isFound = true;
                        AccountIDRef = reader["AccountID"] != DBNull.Value ? Convert.ToInt32(reader["AccountID"]) : -1;
                        AccountDebitRef = reader["AccountDebit"] != DBNull.Value ? Convert.ToDecimal(reader["AccountDebit"]) : 0;
                        AccountCreditRef = reader["AccountCredit"] != DBNull.Value ? Convert.ToDecimal(reader["AccountCredit"]) : 0;
                        JouNoteRef = reader["JouNote"] != DBNull.Value ? Convert.ToString(reader["JouNote"]) : null;
                        AccountCurrencyIDRef = reader["AccountCurrencyID"] != DBNull.Value ? Convert.ToInt32(reader["AccountCurrencyID"]) : 0;
                        JouIDRef = reader["JouID"] != DBNull.Value ? Convert.ToInt32(reader["JouID"]) : 0;
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
