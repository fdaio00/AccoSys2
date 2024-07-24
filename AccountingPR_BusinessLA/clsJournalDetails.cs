using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

public class clsJournalDetails
{
    enum enMode { AddNew = 0, Update = 1 };
    private enMode _Mode;

    public int JouDetalisID { get; set; }
    public int? AccountID { get; set; }
    public decimal? AccountDebit { get; set; }
    public decimal? AccountCredit { get; set; }
    public string JouNote { get; set; }
    public int? AccountCurrencyID { get; set; }
    public int? JouID { get; set; }

    public float ? CurrentExchange { get; set;  }

    public clsJournalDetails()
    {
        this.JouDetalisID = -1;
        this.AccountID = null;
        this.AccountDebit = null;
        this.AccountCredit = null;
        this.JouNote = null;
        this.AccountCurrencyID = null;
        this.JouID = null;
        this.CurrentExchange = null;
        _Mode = enMode.AddNew;
    }

    public clsJournalDetails(
        int JouDetalisID,
        int? AccountID,
        decimal? AccountDebit,
        decimal? AccountCredit,
        string JouNote,
        int? AccountCurrencyID,
        int? JouID,float? CurrecntExchange)
    {
        this.JouDetalisID = JouDetalisID;
        this.AccountID = AccountID;
        this.AccountDebit = AccountDebit;
        this.AccountCredit = AccountCredit;
        this.JouNote = JouNote;
        this.AccountCurrencyID = AccountCurrencyID;
        this.JouID = JouID;
        this.CurrentExchange = CurrentExchange; 
        _Mode = enMode.Update;
    }

    private async Task<bool> _AddNewJournalDetailAsync()
    {
        this.JouDetalisID = await clsJournalDetailsData.AddNewJournalDetailAsync(
            this.AccountID.HasValue ? this.AccountID.Value : default(int),
            this.AccountDebit.HasValue ? this.AccountDebit.Value : default(decimal),
            this.AccountCredit.HasValue ? this.AccountCredit.Value : default(decimal),
            this.JouNote,
            this.AccountCurrencyID.HasValue ? this.AccountCurrencyID.Value : default(int),
            this.JouID.HasValue ? this.JouID.Value : default(int),
            this.CurrentExchange .HasValue ?this.CurrentExchange.Value:default(int));
        return (this.JouDetalisID > 0);
    }
    public static async Task<DataTable> GetAllJournalDetailsByJouHeaderIDAsync(int JournalHeaderID)
    {
        return await clsJournalDetailsData.GetAllJournalDetailsByJouHeaderIDAsync(JournalHeaderID);
    }
    private async Task<bool> _UpdateJournalDetailAsync()
    {
        return await clsJournalDetailsData.UpdateJournalDetailAsync(
            this.JouDetalisID,
            this.AccountID.HasValue ? this.AccountID.Value : default(int),
            this.AccountDebit.HasValue ? this.AccountDebit.Value : default(decimal),
            this.AccountCredit.HasValue ? this.AccountCredit.Value : default(decimal),
            this.JouNote,
            this.AccountCurrencyID.HasValue ? this.AccountCurrencyID.Value : default(int),
            this.JouID.HasValue ? this.JouID.Value : default(int),
           this.CurrentExchange.HasValue ? this.CurrentExchange.Value : default(int));
    }

    public async Task<bool> SaveAsync()
    {
        switch (_Mode)
        {
            case enMode.Update:
                return await _UpdateJournalDetailAsync();
            case enMode.AddNew:
                if (await _AddNewJournalDetailAsync())
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
        return await clsJournalDetailsData.DeleteJournalDetailAsync(this.JouDetalisID);
    }
     public static async Task<bool> DeleteAsync(int JournalDetailsID)
    {
        return await clsJournalDetailsData.DeleteJournalDetailAsync(JournalDetailsID);
    }

    public static async Task<DataTable> GetAllJournalDetailsAsync()
    {
        return await clsJournalDetailsData.GetAllJournalDetailsAsync();
    }

    public static clsJournalDetails GetJournalDetailByID(int JouDetalisID)
    {
        int? AccountID = null;
        decimal? AccountDebit = null;
        decimal? AccountCredit = null;
        string JouNote = null;
        int? AccountCurrencyID = null;
        int? JouID = null;
        float ?CurrentExchange =null;

        bool isJournalDetailFound = clsJournalDetailsData.FindJournalDetailByID(
            JouDetalisID,
            ref AccountID,
            ref AccountDebit,
            ref AccountCredit,
            ref JouNote,
            ref AccountCurrencyID,
            ref JouID,
            ref CurrentExchange);

        if (isJournalDetailFound)
        {
            return new clsJournalDetails(
                JouDetalisID,
                AccountID,
                AccountDebit,
                AccountCredit,
                JouNote,
                AccountCurrencyID,
                JouID,
                CurrentExchange);
        }
        else
        {
            return null;
        }
    }



    public async static Task<int> GetLastJournalNumber()
    {
        return await clsJournalDetailsData.GetLastJournalNumber();

    }


    public static async Task<bool> CheckJournalDetailsIDExists(int JouDetalisID)
    {
        return await clsJournalDetailsData.CheckJournalDetailsIDExists(JouDetalisID);
    }

}
