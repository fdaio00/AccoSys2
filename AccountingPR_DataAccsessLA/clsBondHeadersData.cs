using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

public static class clsBondHeadersData
{
    public static async Task<DataTable> GetAllBondHeadersAsync()
    {
        DataTable dt = new DataTable();

        using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
        {
            using (SqlCommand command = new SqlCommand("SP_GetAllBondHeaders", connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                try
                {
                    await connection.OpenAsync();
                    SqlDataReader reader = await command.ExecuteReaderAsync();
                    if (reader.HasRows) dt.Load(reader); // Load data into DataTable
                }
                catch (Exception ex)
                {
                    clsDataAccessSettings.SetErrorLoggingEvent(ex.Message);
                }
            }
        }

        return dt;
    }

    public static async Task<int> AddNewBondHeaderAsync(
        int bondID,
        DateTime? bondDate,
        string bondNote,
        int bondType,
        bool? isPost,
        decimal? bondBalance,
        int? cashID,
        int? accountBankID,
        int? addedByUserID,
        DateTime? addDate, 
        int JournalID
   )
    {
        int rowsAffected = 0;

        using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
        {
            using (SqlCommand command = new SqlCommand("SP_AddBondHeader", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@BondID", bondID);
                command.Parameters.AddWithValue("@BondDate", bondDate);
                command.Parameters.AddWithValue("@BondNote", (object)bondNote ?? DBNull.Value);
                command.Parameters.AddWithValue("@BondTypeID", bondType);
                command.Parameters.AddWithValue("@IsPost", isPost);
                command.Parameters.AddWithValue("@BondBalance", bondBalance);
                command.Parameters.AddWithValue("@CashID", (object)cashID ?? DBNull.Value);
                command.Parameters.AddWithValue("@AccountBankID", (object)accountBankID ?? DBNull.Value);
                command.Parameters.AddWithValue("@AddedByUserID", (object)addedByUserID ?? DBNull.Value);
                command.Parameters.AddWithValue("@AddDate", (object)addDate ?? DBNull.Value);
                command.Parameters.AddWithValue("@JournalID", JournalID );

                try
                {
                    await connection.OpenAsync();
                    rowsAffected = await command.ExecuteNonQueryAsync();
                }
                catch (Exception ex)
                {
                    clsDataAccessSettings.SetErrorLoggingEvent(ex.Message);
                }
            }
        }

        return rowsAffected;
    }

    public static async Task<bool> UpdateBondHeaderAsync(
        int bondID,
        DateTime? bondDate,
        string bondNote,
        int bondType,
        bool? isPost,
        decimal? bondBalance,
        int? cashID,
        int? accountBankID,
        int? editedByUserID,
        DateTime? editDate,
        int JournalID)
    {
        bool success = false;

        using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
        {
            using (SqlCommand command = new SqlCommand("SP_UpdateBondHeader", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@BondID", bondID);
                command.Parameters.AddWithValue("@BondDate", bondDate);
                command.Parameters.AddWithValue("@BondNote", (object)bondNote ?? DBNull.Value);
                command.Parameters.AddWithValue("@BondTypeID", bondType);
                command.Parameters.AddWithValue("@IsPost", isPost);
                command.Parameters.AddWithValue("@BondBalance", bondBalance);
                command.Parameters.AddWithValue("@CashID", (object)cashID ?? DBNull.Value);
                command.Parameters.AddWithValue("@AccountBankID", (object)accountBankID ?? DBNull.Value);
                command.Parameters.AddWithValue("@EditedByUserID", (object)editedByUserID ?? DBNull.Value);
                command.Parameters.AddWithValue("@EditDate", (object)editDate ?? DBNull.Value);
                command.Parameters.AddWithValue("@JournalID", JournalID );

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

    public static async Task<bool> DeleteBondHeaderAsync(int bondID)
    {
        bool success = false;

        using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
        {
            using (SqlCommand command = new SqlCommand("SP_DeleteBondHeader", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@BondID", bondID);

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

    public static bool FindBondHeaderByID(
        int bondID,
        ref DateTime? bondDate,
        ref string bondNote,
        ref int bondType,
        ref bool? isPost,
        ref decimal? bondBalance,
        ref int? cashID,
        ref int? accountBankID,
        ref int? addedByUserID,
        ref DateTime? addDate,
        ref int? editedByUserID,
        ref DateTime? editDate, 
        ref int JournalID)
    {
        bondDate = null;
        bondNote = null;
        bondType = 0;
        isPost = null;
        bondBalance = null;
        cashID = null;
        accountBankID = null;
        addedByUserID = null;
        addDate = null;
        editedByUserID = null;
        editDate = null;

        bool isFound = false;

        using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
        {
            using (SqlCommand command = new SqlCommand("SP_GetBondHeaderByID", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@BondID", bondID);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        isFound = true;
                        bondDate = reader["BondDate"] != DBNull.Value ? (DateTime?)reader["BondDate"] : null;
                        bondNote = reader["BondNote"] != DBNull.Value ? Convert.ToString(reader["BondNote"]) : null;
                        bondType = reader["BondTypeID"] != DBNull.Value ? Convert.ToInt32(reader["BondTypeID"]) : 0;
                        JournalID = reader["JournalID"] != DBNull.Value ? Convert.ToInt32(reader["JournalID"]) : 0;
                        isPost = reader["IsPost"] != DBNull.Value ? (bool?)reader["IsPost"] : null;
                        bondBalance = reader["BondBalance"] != DBNull.Value ? (decimal?)reader["BondBalance"] : null;
                        cashID = reader["CashID"] != DBNull.Value ? (int?)reader["CashID"] : null;
                        accountBankID = reader["AccountBankID"] != DBNull.Value ? (int?)reader["AccountBankID"] : null;
                        addedByUserID = reader["AddedByUserID"] != DBNull.Value ? (int?)reader["AddedByUserID"] : null;
                        addDate = reader["AddDate"] != DBNull.Value ? (DateTime?)reader["AddDate"] : null;
                        editedByUserID = reader["EditedByUserID"] != DBNull.Value ? (int?)reader["EditedByUserID"] : null;
                        editDate = reader["EditDate"] != DBNull.Value ? (DateTime?)reader["EditDate"] : null;
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    isFound = false;
                    clsDataAccessSettings.SetErrorLoggingEvent(ex.Message);
                }
            }
        }

        return isFound;
    }




    public async static Task<int> GenerateReceiptBondNo()
    {
        int Count = -1;
        using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
        {
            using (SqlCommand command = new SqlCommand("SP_GenerateReceiptBondNo", connection))
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

    public async static Task<int> GenerateDisbursementBondNo()
    {
        int Count = -1;
        using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
        {
            using (SqlCommand command = new SqlCommand("SP_GenerateDisbursementBondNo", connection))
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


    public static async Task<int?> GetBondHeaderIDAsync(string storedProcedure, int? currentBondID)
    {
        int? bondID = null;

        using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
        {
            using (SqlCommand command = new SqlCommand(storedProcedure, connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                // Add the currentBondID parameter if it has a value
                if (currentBondID.HasValue)
                {
                    command.Parameters.AddWithValue("@CurrentBondID", currentBondID.Value);
                }

                // Determine the parameter name based on the stored procedure name
                SqlParameter bondIDParam = new SqlParameter
                {
                    ParameterName = storedProcedure.Contains("Max") || storedProcedure.Contains("Min") ? "@BondID" : storedProcedure.Contains("Next") ? "@NextBondID" : "@PreviousBondID",
                    SqlDbType = SqlDbType.Int,
                    Direction = ParameterDirection.Output
                };
                command.Parameters.Add(bondIDParam);

                try
                {
                    await connection.OpenAsync();
                    await command.ExecuteNonQueryAsync();
                    if (bondIDParam.Value != DBNull.Value)
                    {
                        bondID = Convert.ToInt32(bondIDParam.Value);
                    }
                }
                catch (Exception ex)
                {
                    // Log or handle the error as needed
                    clsDataAccessSettings.SetErrorLoggingEvent(ex.Message);
                }
            }
        }

        return bondID;
    }

}

