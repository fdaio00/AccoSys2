using System.Data;
using System.Threading.Tasks;
using System;

public class clsBondHeader
{
    enum enMode { AddNew = 0, Update = 1 };
    private enMode _Mode;

    public int BondID { get;  set; }
    public DateTime? BondDate { get; set; }
    public string BondNote { get; set; }
    public int BondTypeID { get; set; }
    public bool? IsPost { get; set; }
    public decimal? BondBalance { get; set; }
    public int? CashID { get; set; }
    public int? AccountBankID { get; set; }
    public int? AddedByUserID { get; set; }
    public DateTime? AddDate { get; set; }
    public int? EditedByUserID { get; set; }
    public DateTime? EditDate { get; set; }

    public clsBondHeader()
    {
        this.BondID = -1;
        this.BondDate = null;
        this.BondNote = "";
        this.BondTypeID = 0;
        this.IsPost = null;
        this.BondBalance = null;
        this.CashID = null;
        this.AccountBankID = null;
        this.AddedByUserID = null;
        this.AddDate = null;
        this.EditedByUserID = null;
        this.EditDate = null;
        _Mode = enMode.AddNew;
    }

    public clsBondHeader(
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
        int? editedByUserID,
        DateTime? editDate)
    {
        this.BondID = bondID;
        this.BondDate = bondDate;
        this.BondNote = bondNote;
        this.BondTypeID = bondType;
        this.IsPost = isPost;
        this.BondBalance = bondBalance;
        this.CashID = cashID;
        this.AccountBankID = accountBankID;
        this.AddedByUserID = addedByUserID;
        this.AddDate = addDate;
        this.EditedByUserID = editedByUserID;
        this.EditDate = editDate;
        _Mode = enMode.Update;
    }

    private async Task<bool> _AddNewBondHeaderAsync()
    {
        int rowsAffected = await clsBondHeadersData.AddNewBondHeaderAsync(
            this.BondID,
            this.BondDate,
            this.BondNote,
            this.BondTypeID,
            this.IsPost,
            this.BondBalance,
            this.CashID,
            this.AccountBankID,
            this.AddedByUserID,
            this.AddDate
          
            );

        return rowsAffected > 0;
    }

    private async Task<bool> _UpdateBondHeaderAsync()
    {
        return await clsBondHeadersData.UpdateBondHeaderAsync(
            this.BondID,
            this.BondDate,
            this.BondNote,
            this.BondTypeID,
            this.IsPost,
            this.BondBalance,
            this.CashID,
            this.AccountBankID,
            this.EditedByUserID,
            this.EditDate);
    }

    public async Task<bool> SaveAsync()
    {
        switch (_Mode)
        {
            case enMode.Update:
                return await _UpdateBondHeaderAsync();
            case enMode.AddNew:
                if (await _AddNewBondHeaderAsync())
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
        return await clsBondHeadersData.DeleteBondHeaderAsync(this.BondID);
    }

    public static async Task<DataTable> GetAllBondHeadersAsync()
    {
        return await clsBondHeadersData.GetAllBondHeadersAsync();
    }
    public async static Task<int> GenerateReceiptBondNo()
    {
        return await clsBondHeadersData.GenerateReceiptBondNo();    
    }

    public async static Task<int> GenerateDisbursementBondNo()
    {
        return await clsBondHeadersData.GenerateDisbursementBondNo(); 
    }

    public static bool FindBondHeaderByID(
        int bondID,
        out DateTime? bondDate,
        out string bondNote,
        out int bondType,
        out bool? isPost,
        out decimal? bondBalance,
        out int? cashID,
        out int? accountBankID,
        out int? addedByUserID,
        out DateTime? addDate,
        out int? editedByUserID,
        out DateTime? editDate)
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

        bool isFound = clsBondHeadersData.FindBondHeaderByID(
            bondID,
            out bondDate,
            out bondNote,
            out bondType,
            out isPost,
            out bondBalance,
            out cashID,
            out accountBankID,
            out addedByUserID,
            out addDate,
            out editedByUserID,
            out editDate);

        return isFound;
    }
}
