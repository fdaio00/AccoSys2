using System;
using System.Data;
using System.Threading.Tasks;

public class clsCash
{
    enum enMode { AddNew = 0, Update = 1 };
    private enMode _Mode;
    public int CashID { get; set; }
    public string CashNameAr { get; set; }
    public int AccountNo { get; set; }

    public clsCash()
    {
        this.CashID = -1;
        this.CashNameAr = "";
        this.AccountNo = -1;
        _Mode = enMode.AddNew;
    }

    public clsCash(int cashID, string cashNameAr, int AccountNo)
    {
        this.CashID = cashID;
        this.CashNameAr = cashNameAr;
        this.AccountNo = AccountNo;
        _Mode = enMode.Update;
    }

    private async Task<bool> _AddNewCashAsync()
    {
        this.CashID = await clsCashData.AddNewCashAsync(this.CashNameAr, this.AccountNo);
        return (this.CashID > 0);
    }

    private async Task<bool> _UpdateCashAsync()
    {
        return await clsCashData.UpdateCashAsync(this.CashID, this.CashNameAr, this.AccountNo);
    }

    public async Task<bool> SaveAsync()
    {
        switch (_Mode)
        {
            case enMode.Update:
                return await _UpdateCashAsync();
            case enMode.AddNew:
                if (await _AddNewCashAsync())
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
        return await clsCashData.DeleteCashAsync(this.CashID);
    }

    public static async Task<DataTable> GetAllCashesAsync()
    {
        return await clsCashData.GetAllCashesAsync();
    }

    public static clsCash GetCashByID(int cashID)
    {
        string CashNameAr = null;
        int AccountNo = -1;

        bool isCashFound = clsCashData.FindCashByID(cashID, ref CashNameAr, ref AccountNo);
        if (isCashFound)
        {
            return new clsCash(cashID, CashNameAr, AccountNo);
        }
        else
        {
            return null;
        }
    }
}
