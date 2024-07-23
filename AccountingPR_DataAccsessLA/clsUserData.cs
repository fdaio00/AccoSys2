using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

public static class clsUserData
{
    public static async Task<DataTable> GetAllUsersAsync()
    {
        DataTable dt = new DataTable();

        using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
        {
            using (SqlCommand command = new SqlCommand("SP_GetAllUsers", connection))
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

    public static async Task<int> AddNewUserAsync(string FullName, string UserName, string Password, string Phone, 
        string Email, byte[] Image, bool IsActive, bool UserType)
    {
        int userID = -1;

        using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
        {
            using (SqlCommand command = new SqlCommand("SP_AddNewUser", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                SqlParameter OUTPUT = new SqlParameter("@UserID", SqlDbType.Int)
                { Direction = ParameterDirection.Output };
                command.Parameters.Add(OUTPUT);
                command.Parameters.AddWithValue("@FullName", FullName);
                command.Parameters.AddWithValue("@UserName", UserName);
                command.Parameters.AddWithValue("@Password", Password);
                command.Parameters.AddWithValue("@Phone", (object)Phone ?? DBNull.Value);
                command.Parameters.AddWithValue("@Email", (object)Email ?? DBNull.Value);
                SqlParameter imagepatameter = new SqlParameter("@Image", SqlDbType.Image);
                if (Image != null)
                {
                    imagepatameter.Value = Image;
                }
                else
                {
                    imagepatameter.Value = DBNull.Value;
                }
                command.Parameters.Add(imagepatameter);
                command.Parameters.AddWithValue("@IsActive", (object)IsActive );
                command.Parameters.AddWithValue("@UserType", (object)UserType );



                try
                {
                    await connection.OpenAsync();
                    await command.ExecuteNonQueryAsync();
                    userID = Convert.ToInt32(OUTPUT.Value);
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

        return userID;
    }

    public static async Task<bool> UpdateUserAsync(int UserID, string FullName, string UserName, 
        string Password, string Phone, string Email, byte[] Image,  bool IsActive , bool UserType)
    {
        bool success = false;

        using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
        {
            using (SqlCommand command = new SqlCommand("SP_UpdateUser", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@UserID", UserID);
                command.Parameters.AddWithValue("@FullName", FullName);
                command.Parameters.AddWithValue("@UserName", UserName);
                command.Parameters.AddWithValue("@Password", Password);
                command.Parameters.AddWithValue("@Phone", (object)Phone ?? DBNull.Value);
                command.Parameters.AddWithValue("@Email", (object)Email ?? DBNull.Value);
                SqlParameter imagepatameter = new SqlParameter("@Image", SqlDbType.Image);
                if (Image != null)
                {
                    imagepatameter.Value = Image;
                }
                else
                {
                    imagepatameter.Value = DBNull.Value;
                }
                command.Parameters.Add(imagepatameter);
                command.Parameters.AddWithValue("@IsActive", (object)IsActive);
                command.Parameters.AddWithValue("@UserType", (object)UserType);


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

    public static async Task<bool> DeleteUserAsync(int UserID)
    {
        bool success = false;

        using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
        {
            using (SqlCommand command = new SqlCommand("SP_DeleteUser", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@UserID", UserID);

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

    public static bool FindUserByID(int UserID, ref string FullNameRef,
        ref string UserNameRef, ref string PasswordRef, ref string PhoneRef, ref string EmailRef, ref byte[] ImageRef, ref bool IsActive , 
        ref bool UserType)
    {
        bool isFound = false;

        using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
        {
            using (SqlCommand command = new SqlCommand("SP_GetUserByID", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@UserID", UserID);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        isFound = true;
                        // Set ref parameters with null check
                        FullNameRef = reader["FullName"] != DBNull.Value ? Convert.ToString(reader["FullName"]) : null;
                        UserNameRef = reader["UserName"] != DBNull.Value ? Convert.ToString(reader["UserName"]) : null;
                        PasswordRef = reader["Password"] != DBNull.Value ? Convert.ToString(reader["Password"]) : null;
                        PhoneRef = reader["Phone"] != DBNull.Value ? Convert.ToString(reader["Phone"]) : null;
                        EmailRef = reader["Email"] != DBNull.Value ? Convert.ToString(reader["Email"]) : null;
                        if (reader["Image"] != DBNull.Value)
                        {
                            ImageRef = (byte[])reader["Image"];
                        }
                        else
                        {
                            ImageRef = null;
                        }
                        IsActive = reader["IsActive"] != DBNull.Value ? Convert.ToBoolean(reader["IsActive"]) : false;
                        UserType = reader["UserType"] != DBNull.Value ? Convert.ToBoolean(reader["UserType"]) : false;

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

    public static bool FindByUserNameAndPassword(ref int UserID, ref string FullName,
        string UserName, string Password, ref string PhoneRef,
        ref string EmailRef, ref byte[] ImageRef, ref bool IsActive,
        ref bool UserType)
    {
        bool isFound = false;

        using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
        {
            using (SqlCommand command = new SqlCommand("SP_GetUserByUserNameAndPassword", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@UserName", UserName);
                command.Parameters.AddWithValue("@Password", Password);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        isFound = true;
                        // Set ref parameters with null check
                        UserID = reader["UserID"] != DBNull.Value ? Convert.ToInt32(reader["UserID"]) : -1;
                        FullName = reader["FullName"] != DBNull.Value ? Convert.ToString(reader["FullName"]) : null;
                        PhoneRef = reader["Phone"] != DBNull.Value ? Convert.ToString(reader["Phone"]) : null;
                        EmailRef = reader["Email"] != DBNull.Value ? Convert.ToString(reader["Email"]) : null;
                        if (reader["Image"] != DBNull.Value)
                        {
                            ImageRef = (byte[])reader["Image"];
                        }
                        else
                        {
                            ImageRef = null;
                        }
                        IsActive = reader["IsActive"] != DBNull.Value ? Convert.ToBoolean(reader["IsActive"]) : false;
                        UserType = reader["UserType"] != DBNull.Value ? Convert.ToBoolean(reader["UserType"]) : false;
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

    public static bool CheckUserNameExists(string UserName)
    {
        bool IsFound = false;
        using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
        {
            using (SqlCommand command = new SqlCommand("SP_CheckUserNameExists", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@UserName", UserName);

                // Add a parameter to capture the return value
                SqlParameter returnValue = new SqlParameter();
                returnValue.Direction = ParameterDirection.ReturnValue;
                command.Parameters.Add(returnValue);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
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
    
    
    public static int GetUserMaxCount()
    {
        int? result = 0; 
        using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
        {
            using (SqlCommand command = new SqlCommand("SP_GetUserMaxCount", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
               

            

                try
                {
                    connection.Open();
                    result = Convert.ToInt32(command.ExecuteScalar());
                   

                }
                catch (Exception ex)
                {
                    clsDataAccessSettings.SetErrorLoggingEvent(ex.Message);
                }
            }
        }

        return result??-1;
    }

}



