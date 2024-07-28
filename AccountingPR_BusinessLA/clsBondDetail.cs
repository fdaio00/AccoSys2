using System;
using System.Threading.Tasks;
using System.Data;

public class clsBondDetail
{
    enum enMode { AddNew = 0, Update = 1 };
    private enMode _Mode;

    public int BondDetailsID { get; private set; }
    public int AccountID { get; set; }
    public decimal Amount { get; set; }
    public string BondNote { get; set; }
    public int CurrencyID { get; set; }
    public int BondID { get; set; }

    public clsBondDetail()
    {
        this.BondDetailsID = -1;
        this.AccountID = 0;
        this.Amount = 0;
        this.BondNote = "";
        this.CurrencyID = 0;
        this.BondID = 0;
        _Mode = enMode.AddNew;
    }

    public clsBondDetail(
        int bondDetailsID,
        int accountID,
        decimal amount,
        string bondNote,
        int currencyID,
        int bondID)
    {
        this.BondDetailsID = bondDetailsID;
        this.AccountID = accountID;
        this.Amount = amount;
        this.BondNote = bondNote;
        this.CurrencyID = currencyID;
        this.BondID = bondID;
        _Mode = enMode.Update;
    }

    private async Task<bool> _AddNewBondDetailAsync()
    {
        this.BondDetailsID = await clsBondDetailsData.AddNewBondDetailAsync(
            this.AccountID,
            this.Amount,
            this.BondNote,
            this.CurrencyID,
            this.BondID);
        return (this.BondDetailsID > 0);
    }

    private async Task<bool> _UpdateBondDetailAsync()
    {
        return await clsBondDetailsData.UpdateBondDetailAsync(
            this.BondDetailsID,
            this.AccountID,
            this.Amount,
            this.BondNote,
            this.CurrencyID,
            this.BondID);
    }

    public async Task<bool> SaveAsync()
    {
        switch (_Mode)
        {
            case enMode.Update:
                return await _UpdateBondDetailAsync();
            case enMode.AddNew:
                if (await _AddNewBondDetailAsync())
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
        return await clsBondDetailsData.DeleteBondDetailAsync(this.BondDetailsID);
    }

    public static async Task<DataTable> GetAllBondDetailsAsync()
    {
        return await clsBondDetailsData.GetAllBondDetailsAsync();
    }

    public static clsBondDetail GetBondDetailByID(int BondDetailsID)
    {
        int AccountID = 0;
        decimal Amount = 0;
        string BondNote = null;
        int CurrencyID = 0;
        int BondID = 0;

        bool isBondDetailFound = clsBondDetailsData.FindBondDetailByID(
            BondDetailsID,
            out AccountID,
            out Amount,
            out BondNote,
            out CurrencyID,
            out BondID);

        if (isBondDetailFound)
        {
            return new clsBondDetail(
                BondDetailsID,
                AccountID,
                Amount,
                BondNote,
                CurrencyID,
                BondID);
        }
        else
        {
            return null;
        }
    }

    public static async Task<bool> CheckBondDetailsIDExists(int BondDetailsID)
    {
        return await clsBondDetailsData.CheckBondDetailsIDExists(BondDetailsID);
    }


}
