using System.Data;
using System.Threading.Tasks;
using System;
using System.Data.SqlClient;

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
    public int JournalID { get; set;  }

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
        this.JournalID = -1; 
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
        DateTime? editDate, int JournalID)
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
        this.JournalID = JournalID; 
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
            this.AddDate,
            this.JournalID

            ) ;

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
            this.EditDate,
            this.JournalID);
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

    public static clsBondHeader FindBondHeaderByID( int bondID )
    {
         DateTime? bondDate = null; 
         string bondNote= null;
         int bondType= -1;
         bool? isPost= null;
         decimal? bondBalance= null;
         int? cashID= null;
         int? accountBankID= null;
         int? addedByUserID= null;
         DateTime? addDate= null;
         int? editedByUserID= null;
         DateTime? editDate = null;
        int JournalID = -1; 

        bool isFound = clsBondHeadersData.FindBondHeaderByID(
            bondID,
        ref     bondDate,
        ref     bondNote,
        ref     bondType,
        ref     isPost,
        ref     bondBalance,
        ref     cashID,
        ref     accountBankID,
        ref     addedByUserID,
        ref     addDate,
        ref     editedByUserID,
        ref editDate,
            ref JournalID);

        if(isFound )
        {
            return new clsBondHeader(bondID, bondDate, bondNote, bondType, isPost,
                bondBalance, cashID, accountBankID, addedByUserID, addDate, editedByUserID, editDate,JournalID);
        }
        else
        {
            return null; 
        }
    }



   

    public static async Task<int?> GetNextBondHeaderIDAsync(int currentBondID)
    {
        return await clsBondHeadersData.GetBondHeaderIDAsync("SP_GetNextBondHeaderID", currentBondID);
    }

    public static async Task<int?> GetPreviousBondHeaderIDAsync(int currentBondID)
    {
        return await clsBondHeadersData.GetBondHeaderIDAsync("SP_GetPreviousBondHeaderID", currentBondID);
    }

    public static async Task<int?> GetMaxBondHeaderIDAsync()
    {
        return await clsBondHeadersData.GetBondHeaderIDAsync("SP_GetMaxBondHeaderID", null);
    }

    public static async Task<int?> GetMinBondHeaderIDAsync()
    {
        return await clsBondHeadersData. GetBondHeaderIDAsync("SP_GetMinBondHeaderID", null);
    }
}
