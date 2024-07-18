using System;
using System.Data;
using System.Threading.Tasks;

public class clsAccountType
{
    enum enMode { AddNew = 0, Update = 1 };
    private enMode _Mode;

    public int AccountTypeID { get; set; }
    public string AccountTypeINameAr { get; set; }
    public string AccountTypeNameEn { get; set; }

    public clsAccountType()
    {
        this.AccountTypeID = -1;
        this.AccountTypeINameAr = "";
        this.AccountTypeNameEn = null;
        _Mode = enMode.AddNew;
    }

    public clsAccountType(int AccountTypeID, string AccountTypeINameAr, string AccountTypeNameEn)
    {
        this.AccountTypeID = AccountTypeID;
        this.AccountTypeINameAr = AccountTypeINameAr;
        this.AccountTypeNameEn = AccountTypeNameEn;
        _Mode = enMode.Update;
    }

    private async Task<bool> _AddNewAccountTypeIDAsync()
    {
        this.AccountTypeID = await clsAccountTypeData.AddNewAccountTypeAsync(this.AccountTypeINameAr, this.AccountTypeNameEn);
        return (this.AccountTypeID > 0);
    }

    private async Task<bool> _UpdateAccountTypeIDAsync()
    {
        return await clsAccountTypeData.UpdateAccountTypeAsync(this.AccountTypeID, this.AccountTypeINameAr, this.AccountTypeNameEn);
    }

    public async Task<bool> SaveAsync()
    {
        switch (_Mode)
        {
            case enMode.Update:
                return await _UpdateAccountTypeIDAsync();
            case enMode.AddNew:
                if (await _AddNewAccountTypeIDAsync())
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

    public async Task<bool> DeleteAsync()
    {
        return await clsAccountTypeData.DeleteAccountTypeAsync(this.AccountTypeID);
    }

    public static async Task<DataTable> GetAllAccountTypeIDsAsync()
    {
        return await clsAccountTypeData.GetAllAccountTypeIDsAsync();
    }

    public static clsAccountType GetAccountTypeIDByID(int AccountTypeID)
    {
        string AccountTypeINameAr = null;
        string AccountTypeNameEn = null;

        bool isAccountTypeIDFound = clsAccountTypeData.FindAccountTypeByID(AccountTypeID, ref AccountTypeINameAr, ref AccountTypeNameEn);

        if (isAccountTypeIDFound)
        {
            return new clsAccountType(AccountTypeID, AccountTypeINameAr, AccountTypeNameEn);
        }
        else
        {
            return null;
        }
    }
}
