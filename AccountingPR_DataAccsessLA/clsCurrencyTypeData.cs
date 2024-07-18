using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

public static class clsCurrencyTypeData
{
    public static async Task<DataTable> GetAllCurrencyTypesAsync()
    {
        DataTable dt = new DataTable();

        using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
        {
            using (SqlCommand command = new SqlCommand("SP_GetAllCurrencyTypes", connection))
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

    public static async Task<int> AddNewCurrencyTypeAsync(
        string CurrencyTypeNameAr,
        string CurrencyTypeNameEn)
    {
        int currencyTypeID = -1;

        using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
        {
            using (SqlCommand command = new SqlCommand("SP_AddCurrencyType", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@CurrencyTypeNameAr", CurrencyTypeNameAr);
                command.Parameters.AddWithValue("@CurrencyTypeNameEn", (object)CurrencyTypeNameEn ?? DBNull.Value);

                try
                {
                    await connection.OpenAsync();
                    currencyTypeID = Convert.ToInt32(await command.ExecuteScalarAsync());
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

        return currencyTypeID;
    }

    public static async Task<bool> UpdateCurrencyTypeAsync(
        int CurrencyTypeID,
        string CurrencyTypeNameAr,
        string CurrencyTypeNameEn)
    {
        bool success = false;

        using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
        {
            using (SqlCommand command = new SqlCommand("SP_UpdateCurrencyType", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@CurrencyTypeID", CurrencyTypeID);
                command.Parameters.AddWithValue("@CurrencyTypeNameAr", CurrencyTypeNameAr);
                command.Parameters.AddWithValue("@CurrencyTypeNameEn", (object)CurrencyTypeNameEn ?? DBNull.Value);

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

    public static async Task<bool> DeleteCurrencyTypeAsync(int currencyTypeID)
    {
        bool success = false;

        using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
        {
            using (SqlCommand command = new SqlCommand("SP_DeleteCurrencyType", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@CurrencyTypeID", currencyTypeID);

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

    public static bool FindCurrencyTypeByID(
        int currencyTypeID,
        ref string currencyTypeNameArRef,
        ref string currencyTypeNameEnRef)
    {
        bool isFound = false;

        using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
        {
            using (SqlCommand command = new SqlCommand("SP_GetCurrencyTypeByID", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@CurrencyTypeID", currencyTypeID);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        isFound = true;
                        currencyTypeNameArRef = reader["CurrencyTypeNameAr"] != DBNull.Value ? Convert.ToString(reader["CurrencyTypeNameAr"]) : null;
                        currencyTypeNameEnRef = reader["CurrencyTypeNameEn"] != DBNull.Value ? Convert.ToString(reader["CurrencyTypeNameEn"]) : null;
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
