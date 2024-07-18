using System;
using System.Data;
using System.Threading.Tasks;

public class clsUser
{
    enum enMode { AddNew = 0, Update = 1 };
    private enMode _Mode;

    public int UserID { get; set; }
    public string FullName { get; set; }
    public string UserName { get; set; }
    public string Password { get; set; }
    public string Phone { get; set; }
    public string Email { get; set; }
    public byte[] Image { get; set; }
    public bool IsActive { get; set; }
    public bool UserType { get; set; }

    public clsUser()
    {
        this.UserID = -1;
        this.FullName = "";
        this.UserName = "";
        this.Password = "";
        this.Phone = null;
        this.Email = null;
        this.Image = null;
        _Mode = enMode.AddNew;
    }

    public clsUser(int userID, string fullName, string userName, string password, string phone, string email, byte[] image, bool isActive, bool userType)
    {
        this.UserID = userID;
        this.FullName = fullName;
        this.UserName = userName;
        this.Password = password;
        this.Phone = phone;
        this.Email = email;
        this.Image = image;
        _Mode = enMode.Update;
        IsActive = isActive;
        UserType = userType;
    }

    private async Task<bool> _AddNewUserAsync()
    {
        this.UserID = await clsUserData.AddNewUserAsync(this.FullName, this.UserName, this.Password, 
            this.Phone, this.Email, this.Image, this.IsActive, this.UserType);
        return (this.UserID > 0);
    }

    private async Task<bool> _UpdateUserAsync()
    {
        return await clsUserData.UpdateUserAsync(this.UserID, this.FullName, this.UserName, this.Password, this.Phone, this.Email, this.Image
            , this.IsActive, this.UserType);
    }

    public async Task<bool> SaveAsync()
    {
        switch (_Mode)
        {
            case enMode.Update:
                return await _UpdateUserAsync();
            case enMode.AddNew:
                if (await _AddNewUserAsync())
                {
                    _Mode = enMode.Update;
                    return true;
                }
                else
                    return false;
            default:
                return false;
        }
    }

    public static async Task<bool> DeleteAsync(int UserID)
    {
        return await clsUserData.DeleteUserAsync(UserID);
    }

    public static async Task<DataTable> GetAllUsersAsync()
    {
        return await clsUserData.GetAllUsersAsync();
    }

    public static clsUser GetUserByID(int UserID)
    {
        string FullName = null;
        string UserName = null;
        string Password = null;
        string Phone = null;
        string Email = null;
        byte[] Image = null;
        bool IsActive = false;
        bool UserType = false;

        bool isUserFound = clsUserData.FindUserByID(UserID, ref FullName, ref UserName, ref Password, ref Phone, ref Email, ref Image
            , ref IsActive, ref UserType);

        if (isUserFound)
        {
            return new clsUser(UserID, FullName, UserName, Password, Phone, Email, Image, IsActive, UserType);
        }
        else
        {
            return null;
        }
    }
    
    public static clsUser FindByUserNameAndPassword(string UserName , string Password )
    {
        int UserID = -1;
        string FullName = null;
        string Phone = null;
        string Email = null;
        byte[] Image = null;
        bool IsActive = false;
        bool UserType = false; 

        bool isUserFound = clsUserData.FindByUserNameAndPassword(  ref UserID, ref FullName,  UserName,  Password, ref Phone, 
            ref Email, ref Image, ref IsActive, ref UserType);

        if (isUserFound)
        {
            return new clsUser(UserID, FullName, UserName, Password, Phone, Email, Image,IsActive,UserType);
        }
        else
        {
            return null;
        }
    }

    public static bool CheckUserNameExists(string  UserName)
    {
        return clsUserData.CheckUserNameExists(UserName);
    }

    public static int GetUserMaxCount()
    {
        return clsUserData.GetUserMaxCount();
    }

}
