using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

public static class clsCurrencyData
{
    public static async Task<DataTable> GetAllCurrenciesAsync()
    {
        DataTable dt = new DataTable();

        using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
        {
            using (SqlCommand command = new SqlCommand("SP_GetAllCurrencies", connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                try
                {
                    await connection.OpenAsync();
                    SqlDataReader reader = await command.ExecuteReaderAsync();
                   if(reader.HasRows)   dt.Load(reader); // Load data into DataTable
                }
                catch (Exception ex)
                {
                    clsDataAccessSettings.SetErrorLoggingEvent(ex.Message);
                }
            }
        }

        return dt;
    }

    public static async Task<int> AddNewCurrencyAsync(
        string CurrencyNameAr,
        string CurrencyNameEn,
        string CurrencySymbol,
        decimal? CurrencyExchange,
        string CurrencyPenies,
        int CurrencyTypeID)
    {
        int currencyID = -1;

        using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
        {
            using (SqlCommand command = new SqlCommand("SP_AddCurrency", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                SqlParameter output = new SqlParameter("@CurrencyID", SqlDbType.Int)
                { Direction = ParameterDirection.Output };
                command.Parameters.Add(output);


                command.Parameters.AddWithValue("@CurrencyNameAr", CurrencyNameAr);
                command.Parameters.AddWithValue("@CurrencyNameEn", (object)CurrencyNameEn ?? DBNull.Value);
                command.Parameters.AddWithValue("@CurrencySymbol", CurrencySymbol);
                command.Parameters.AddWithValue("@CurrencyExchange", (object)CurrencyExchange ?? DBNull.Value);
                command.Parameters.AddWithValue("@CurrencyPenies", CurrencyPenies);
                command.Parameters.AddWithValue("@CurrencyTypeID", CurrencyTypeID);


                try
                {
                    await connection.OpenAsync();
                    await command.ExecuteScalarAsync();
                    currencyID = Convert.ToInt32(output.Value ?? -1);
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

        return currencyID;
    }

    public static async Task<bool> UpdateCurrencyAsync(
        int CurrencyID,
        string CurrencyNameAr,
        string CurrencyNameEn,
        string CurrencySymbol,
        decimal? CurrencyExchange,
        string CurrencyPenies,
        int CurrencyTypeID)
    {
        bool success = false;

        using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
        {
            using (SqlCommand command = new SqlCommand("SP_UpdateCurrency", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@CurrencyID", CurrencyID);
                command.Parameters.AddWithValue("@CurrencyNameAr", CurrencyNameAr);
                command.Parameters.AddWithValue("@CurrencyNameEn", (object)CurrencyNameEn ?? DBNull.Value);
                command.Parameters.AddWithValue("@CurrencySymbol", CurrencySymbol);
                command.Parameters.AddWithValue("@CurrencyExchange", (object)CurrencyExchange ?? DBNull.Value);
                command.Parameters.AddWithValue("@CurrencyPenies", CurrencyPenies);
                command.Parameters.AddWithValue("@CurrencyTypeID", CurrencyTypeID);

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

    public static async Task<bool> DeleteCurrencyAsync(int currencyID)
    {
        bool success = false;

        using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
        {
            using (SqlCommand command = new SqlCommand("SP_DeleteCurrency", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@CurrencyID", currencyID);

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

    public static bool FindCurrencyByID(
        int currencyID,
        ref string currencyNameArRef,
        ref string currencyNameEnRef,
        ref string currencySymbolRef,
        ref decimal? currencyExchangeRef,
        ref string currencyPeniesRef,
        ref int currencyTypeID)
    {
        bool isFound = false;

        using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
        {
            using (SqlCommand command = new SqlCommand("SP_GetCurrencyByID", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@CurrencyID", currencyID);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        isFound = true;
                        currencyNameArRef = reader["CurrencyNameAr"] != DBNull.Value ? Convert.ToString(reader["CurrencyNameAr"]) : null;
                        currencyNameEnRef = reader["CurrencyNameEn"] != DBNull.Value ? Convert.ToString(reader["CurrencyNameEn"]) : null;
                        currencySymbolRef = reader["CurrencySymbol"] != DBNull.Value ? Convert.ToString(reader["CurrencySymbol"]) : null;
                        currencyExchangeRef = reader["CurrencyExchange"] != DBNull.Value ? Convert.ToDecimal(reader["CurrencyExchange"]) : (decimal?)null;
                        currencyPeniesRef = reader["CurrencyPenies"] != DBNull.Value ? Convert.ToString(reader["CurrencyPenies"]) : null;
                        currencyTypeID = reader["CurrencyTypeID"] != DBNull.Value ? Convert.ToInt32(reader["CurrencyTypeID"]) : -1;
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {isFound=false;
                    clsDataAccessSettings.SetErrorLoggingEvent(ex.Message);
                }
            }
        }

        return isFound;
    }

    public static bool FindCurrencyByName(ref  int CurrecnyID,
        string currencyName,
        ref string currencyNameArRef,
        ref string currencyNameEnRef,
        ref string currencySymbolRef,
        ref decimal? currencyExchangeRef,
        ref string currencyPeniesRef,
        ref int currencyTypeID)
    {
        bool isFound = false;

        using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
        {
            using (SqlCommand command = new SqlCommand("SP_GetCurrencyByName", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@CurrecnyName", currencyName);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        isFound = true;
                        currencyNameArRef = reader["CurrencyNameAr"] != DBNull.Value ? Convert.ToString(reader["CurrencyNameAr"]) : null;
                        currencyNameEnRef = reader["CurrencyNameEn"] != DBNull.Value ? Convert.ToString(reader["CurrencyNameEn"]) : null;
                        currencySymbolRef = reader["CurrencySymbol"] != DBNull.Value ? Convert.ToString(reader["CurrencySymbol"]) : null;
                        currencyExchangeRef = reader["CurrencyExchange"] != DBNull.Value ? Convert.ToDecimal(reader["CurrencyExchange"]) : (decimal?)null;
                        currencyPeniesRef = reader["CurrencyPenies"] != DBNull.Value ? Convert.ToString(reader["CurrencyPenies"]) : null;
                        CurrecnyID = reader["CurrencyID"] != DBNull.Value ? Convert.ToInt32(reader["CurrencyID"]) : -1;
                        currencyTypeID = reader["CurrencyTypeID"] != DBNull.Value ? Convert.ToInt32(reader["CurrencyTypeID"]) : -1;

                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    isFound=false;
                    clsDataAccessSettings.SetErrorLoggingEvent(ex.Message);
                }
            }
        }

        return isFound;
    }

}
