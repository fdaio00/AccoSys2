using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

public static class clsBondDetailsData
{
    public static async Task<DataTable> GetAllBondDetailsAsync()
    {
        DataTable dt = new DataTable();

        using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
        {
            using (SqlCommand command = new SqlCommand("SP_GetAllBondDetails", connection))
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

    public static async Task<int> AddNewBondDetailAsync(
        int accountID,
        decimal amount,
        string bondNote,
        int currencyID,
        int bondID)
    {
        int bondDetailsID = -1;

        using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
        {
            using (SqlCommand command = new SqlCommand("SP_AddBondDetails", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                SqlParameter OutputBondDetailsID = new SqlParameter("@BondDetailsID", SqlDbType.Int)
                { Direction = ParameterDirection.Output };

                command.Parameters.Add(OutputBondDetailsID);
                command.Parameters.AddWithValue("@AccountID", accountID);
                command.Parameters.AddWithValue("@Amount", amount);
                command.Parameters.AddWithValue("@BondNote", (object)bondNote ?? DBNull.Value);
                command.Parameters.AddWithValue("@CurrencyID", currencyID);
                command.Parameters.AddWithValue("@BondID", bondID);

                try
                {
                    await connection.OpenAsync();
                    await command.ExecuteScalarAsync();
                    if (OutputBondDetailsID != null)
                    {
                        bondDetailsID = Convert.ToInt32(OutputBondDetailsID.Value);
                    }
                }
                catch (Exception ex)
                {
                    clsDataAccessSettings.SetErrorLoggingEvent(ex.Message);
                }
            }
        }

        return bondDetailsID;
    }

    public static async Task<bool> UpdateBondDetailAsync(
        int bondDetailsID,
        int accountID,
        decimal amount,
        string bondNote,
        int currencyID,
        int bondID)
    {
        bool success = false;

        using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
        {
            using (SqlCommand command = new SqlCommand("SP_UpdateBondDetails", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@BondDetailsID", bondDetailsID);
                command.Parameters.AddWithValue("@AccountID", accountID);
                command.Parameters.AddWithValue("@Amount", amount);
                command.Parameters.AddWithValue("@BondNote", (object)bondNote ?? DBNull.Value);
                command.Parameters.AddWithValue("@CurrencyID", currencyID);
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

    public static async Task<bool> DeleteBondDetailAsync(int bondDetailsID)
    {
        bool success = false;

        using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
        {
            using (SqlCommand command = new SqlCommand("SP_DeleteBondDetail", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@BondDetailsID", bondDetailsID);

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

    public static bool FindBondDetailByID(
        int bondDetailsID,
        out int accountID,
        out decimal amount,
        out string bondNote,
        out int currencyID,
        out int bondID)
    {
        accountID = 0;
        amount = 0;
        bondNote = null;
        currencyID = 0;
        bondID = 0;

        bool isFound = false;

        using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
        {
            using (SqlCommand command = new SqlCommand("SP_GetBondDetailsByID", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@BondDetailsID", bondDetailsID);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        accountID = reader["AccountID"] != DBNull.Value ? Convert.ToInt32(reader["AccountID"]) : 0;
                        amount = reader["Amount"] != DBNull.Value ? Convert.ToDecimal(reader["Amount"]) : 0;
                        bondNote = reader["BondNote"] != DBNull.Value ? Convert.ToString(reader["BondNote"]) : null;
                        currencyID = reader["CurrencyID"] != DBNull.Value ? Convert.ToInt32(reader["CurrencyID"]) : 0;
                        bondID = reader["BondID"] != DBNull.Value ? Convert.ToInt32(reader["BondID"]) : 0;
                        isFound = true;
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

    public static async Task<bool> CheckBondDetailsIDExistsAsync(int BondDetailsID)
    {
        bool IsFound = false;
        using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
        {
            using (SqlCommand command = new SqlCommand("SP_CheckBondDetailsIDExists", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@BondDetailsID", BondDetailsID);

                // Add a parameter to capture the return value
                SqlParameter returnValue = new SqlParameter();
                returnValue.Direction = ParameterDirection.ReturnValue;
                command.Parameters.Add(returnValue);

                try
                {
                    connection.Open();
                    await command.ExecuteNonQueryAsync();
                    int result = (int)returnValue.Value;
                    IsFound = (result > 0);

                }
                catch (Exception ex)
                {
                    clsDataAccessSettings.SetErrorLoggingEvent(ex.Message);
                }
            }
        }

        return IsFound;
    }



    public static async Task<DataTable> GetAllBondDetailsByBondHeaderIDAsync(int BondID)
    {
        DataTable dt = new DataTable();

        using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
        {
            using (SqlCommand command = new SqlCommand("SP_GetAllBondDetailsByBondHeaderID", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@BondID", BondID);

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

}