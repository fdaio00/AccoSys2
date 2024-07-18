using System;
using System.Threading.Tasks;
using System.Data;

public class clsBank
{
    enum enMode { AddNew = 0, Update = 1 };
    private enMode _Mode;

    public int BankID { get; set; }
    public string BankNameAr { get; set; }
    public int AccountNo { get; set; }

    public clsBank()
    {
        this.BankID = -1;
        this.BankNameAr = "";
        this.AccountNo = -1;
        _Mode = enMode.AddNew;
    }

    public clsBank(int bankID, string bankNameAr, int AccountNo)
    {
        this.BankID = bankID;
        this.BankNameAr = bankNameAr;
        this.AccountNo = AccountNo;
        _Mode = enMode.Update;
    }

    private async Task<bool> _AddNewBankAsync()
    {
        this.BankID = await clsBankData.AddNewBankAsync(this.BankNameAr, this.AccountNo);
        return (this.BankID > 0);
    }

    private async Task<bool> _UpdateBankAsync()
    {
        return await clsBankData.UpdateBankAsync(this.BankID, this.BankNameAr, this.AccountNo);
    }

    public async Task<bool> SaveAsync()
    {
        switch (_Mode)
        {
            case enMode.Update:
                return await _UpdateBankAsync();
            case enMode.AddNew:
                if (await _AddNewBankAsync())
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
        return await clsBankData.DeleteBankAsync(this.BankID);
    }

    public static async Task<DataTable> GetAllBanksAsync()
    {
        return await clsBankData.GetAllBanksAsync();
    }

    public static clsBank GetBankByID(int BankID)
    {
        string BankNameAr = null;
        int AccountNo = -1;

        bool isBankFound = clsBankData.FindBankByID(BankID, ref BankNameAr, ref AccountNo);

        if (isBankFound)
        {
            return new clsBank(BankID, BankNameAr, AccountNo);
        }
        else
        {
            return null;
        }
    }
}
