using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

public static class clsJournalHeadersData
{
    public static async Task<DataTable> GetAllJournalHeadersAsync()
    {
        DataTable dt = new DataTable();

        using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
        {
            using (SqlCommand command = new SqlCommand("SP_GetAllJournalHeaders", connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                try
                {
                    await connection.OpenAsync();
                    SqlDataReader reader = await command.ExecuteReaderAsync();
                    if (reader.HasRows)
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

    public static async Task<bool> AddNewJournalHeaderAsync(
        int JouID ,
        DateTime JouDate,
        string JouNote,
        int JouTypeID,
        bool JouIsPost,
        decimal TotalDebit,
        decimal TotalCredit,
        decimal TotalBalance,
        int AddedByUserID,
        DateTime AddDate,
        int OperationTypeID)
    {
        bool Succes = false; 

        using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
        {
            using (SqlCommand command = new SqlCommand("SP_AddJournalHeader", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@JouID", JouID );
                command.Parameters.AddWithValue("@JouDate", JouDate );
                command.Parameters.AddWithValue("@JouNote", JouNote );
                command.Parameters.AddWithValue("@JouTypeID", JouTypeID );
                command.Parameters.AddWithValue("@JouIsPost", (object)JouIsPost ?? DBNull.Value);
                command.Parameters.AddWithValue("@TotalDebit", TotalDebit );
                command.Parameters.AddWithValue("@TotalCredit", TotalCredit );
                command.Parameters.AddWithValue("@TotalBalance", TotalBalance );
                command.Parameters.AddWithValue("@AddedByUserID", AddedByUserID );
                command.Parameters.AddWithValue("@AddDate", AddDate );
                command.Parameters.AddWithValue("@OperationTypeID", OperationTypeID);


                try
                {
                    await connection.OpenAsync();
                    await command.ExecuteScalarAsync();
                    Succes = true; 
                }
                catch (Exception ex)
                {
                    clsDataAccessSettings.SetErrorLoggingEvent(ex.Message);
                }
            }
        }

        return Succes;
    }

    public static async Task<bool> UpdateJournalHeaderAsync(
        int JouID,
        DateTime JouDate,
        string JouNote,
        int JouTypeID,
        bool JouIsPost,
        decimal TotalDebit,
        decimal TotalCredit,
        decimal TotalBalance,
        int? EditedByUserID,
        DateTime? EditDate,
        int OperationTypeID)
    {
        bool success = false;

        using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
        {
            using (SqlCommand command = new SqlCommand("SP_UpdateJournalHeader", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@JouID", JouID);
                command.Parameters.AddWithValue("@JouDate", JouDate );
                command.Parameters.AddWithValue("@JouNote", JouNote );
                command.Parameters.AddWithValue("@JouTypeID", JouTypeID );
                command.Parameters.AddWithValue("@JouIsPost", (object)JouIsPost ?? DBNull.Value);
                command.Parameters.AddWithValue("@TotalDebit", TotalDebit );
                command.Parameters.AddWithValue("@TotalCredit", TotalCredit );
                command.Parameters.AddWithValue("@TotalBalance", TotalBalance );
                command.Parameters.AddWithValue("@EditedByUserID", EditedByUserID );
                command.Parameters.AddWithValue("@EditDate", EditDate );
                command.Parameters.AddWithValue("@OperationTypeID", OperationTypeID);

                try
                {
                    await connection.OpenAsync();
                    int rowsAffected = await command.ExecuteNonQueryAsync();
                    success = (rowsAffected > 0);
                }
                catch (Exception ex)
                {
                    clsDataAccessSettings.SetErrorLoggingEvent(ex.Message);
                }
            }
        }

        return success;
    }

    public static async Task<bool> DeleteJournalHeaderAsync(int JouID)
    {
        bool success = false;

        using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
        {
            using (SqlCommand command = new SqlCommand("SP_DeleteJournalHeader", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@JouID", JouID);

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

    public static bool FindJournalHeaderByID(
        int JouID,
        ref DateTime? JouDateRef,
        ref string JouNoteRef,
        ref int? JouTypeIDRef,
        ref bool? JouIsPostRef,
        ref decimal? TotalDebitRef,
        ref decimal? TotalCreditRef,
        ref decimal? TotalBalanceRef,
        ref int? AddedByUserIDRef,
        ref DateTime? AddDateRef,
        ref int? EditedByUserIDRef,
        ref DateTime? EditDateRef,
        ref int OperationTypeID)
    {
        bool isFound = false;

        using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
        {
            using (SqlCommand command = new SqlCommand("SP_GetJournalHeaderByID", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@JouID", JouID);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        isFound = true;
                        JouDateRef = reader["JouDate"] != DBNull.Value ? Convert.ToDateTime(reader["JouDate"]) : (DateTime?)null;
                        JouNoteRef = reader["JouNote"] != DBNull.Value ? Convert.ToString(reader["JouNote"]) : null;
                        JouTypeIDRef = reader["JouTypeID"] != DBNull.Value ? Convert.ToInt32(reader["JouTypeID"]) : (int?)null;
                        JouIsPostRef = reader["JouIsPost"] != DBNull.Value ? Convert.ToBoolean(reader["JouIsPost"]) : (bool?)null;
                        TotalDebitRef = reader["TotalDebit"] != DBNull.Value ? Convert.ToDecimal(reader["TotalDebit"]) : (decimal?)null;
                        TotalCreditRef = reader["TotalCredit"] != DBNull.Value ? Convert.ToDecimal(reader["TotalCredit"]) : (decimal?)null;
                        TotalBalanceRef = reader["TotalBalance"] != DBNull.Value ? Convert.ToDecimal(reader["TotalBalance"]) : (decimal?)null;
                        AddedByUserIDRef = reader["AddedByUserID"] != DBNull.Value ? Convert.ToInt32(reader["AddedByUserID"]) : (int?)null;
                        AddDateRef = reader["AddDate"] != DBNull.Value ? Convert.ToDateTime(reader["AddDate"]) : (DateTime?)null;
                        EditedByUserIDRef = reader["EditedByUserID"] != DBNull.Value ? Convert.ToInt32(reader["EditedByUserID"]) : (int?)null;
                        EditDateRef = reader["EditDate"] != DBNull.Value ? Convert.ToDateTime(reader["EditDate"]) : (DateTime?)null;
                        OperationTypeID = reader["OperationTypeID"] != DBNull.Value ? Convert.ToInt32(reader["OperationTypeID"]) :-1;
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

    public async static Task<int> GetLastJournalNumber()
    {
        int Count = -1;
        using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
        {
            using (SqlCommand command = new SqlCommand("SP_GetLastJournalNumber", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                SqlParameter countOutput = new SqlParameter("@Count", SqlDbType.Int)
                {
                    Direction = ParameterDirection.Output,
                };

                command.Parameters.Add(countOutput);

                try
                {
                    connection.Open();
                    await command.ExecuteScalarAsync();
                    if (countOutput != null)
                    {
                        Count = Convert.ToInt32(countOutput.Value);
                    }
                }
                catch (Exception ex)
                {
                    clsDataAccessSettings.SetErrorLoggingEvent(ex.Message);
                }
            }
        }
        return Count;
    }


    public static async Task<int?> GetJournalHeaderIDAsync(string storedProcedure, int? currentJournalHeaderID)
    {
        int? journalHeaderID = null;

        using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
        {
            using (SqlCommand command = new SqlCommand(storedProcedure, connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                if (currentJournalHeaderID.HasValue)
                {
                    command.Parameters.AddWithValue("@CurrentJournalHeaderID", currentJournalHeaderID.Value);
                }

                SqlParameter journalHeaderIDParam = new SqlParameter
                {
                    ParameterName = storedProcedure.Contains("Max") || storedProcedure.Contains("Min") ? "@JournalHeaderID" : storedProcedure.Contains("Next") ? "@NextJournalHeaderID" : "@PreviousJournalHeaderID",
                    SqlDbType = SqlDbType.Int,
                    Direction = ParameterDirection.Output
                };
                command.Parameters.Add(journalHeaderIDParam);

                try
                {
                    await connection.OpenAsync();
                    await command.ExecuteNonQueryAsync();
                    if (journalHeaderIDParam.Value != DBNull.Value)
                    {
                        journalHeaderID = Convert.ToInt32(journalHeaderIDParam.Value);
                    }
                }
                catch (Exception ex)
                {
                    // Log or handle the error as needed
                    clsDataAccessSettings.SetErrorLoggingEvent(ex.Message);
                }
            }
        }

        return journalHeaderID;
    }

}
