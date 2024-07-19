using System;
using System.Data;
using System.Threading.Tasks;

public class clsJournalHeaders
{
    enum enMode { AddNew = 0, Update = 1 };
    private enMode _Mode;

    public int JouID { get; set; }
    public DateTime?JouDate { get; set; }
    public string JouNote { get; set; }
    public int? JouTypeID { get; set; }
    public bool? JouIsPost { get; set; }
    public decimal? TotalDebit { get; set; }
    public decimal? TotalCredit { get; set; }
    public decimal? TotalBalance { get; set; }
    public int? AddedByUserID { get; set; }
    public DateTime? AddDate { get; set; }
    public int? EditedByUserID { get; set; }
    public DateTime? EditDate { get; set; }

    public clsJournalHeaders()
    {
        this.JouID = -1;
        this.JouDate = null;
        this.JouNote = null;
        this.JouTypeID = null;
        this.JouIsPost = null;
        this.TotalDebit = null;
        this.TotalCredit = null;
        this.TotalBalance = null;
        this.AddedByUserID = null;
        this.AddDate = null;
        this.EditedByUserID = null;
        this.EditDate = null;
        _Mode = enMode.AddNew;
    }

    public clsJournalHeaders(
        int JouID,
        DateTime? JouDate,
        string JouNote,
        int? JouTypeID,
        bool? JouIsPost,
        decimal? TotalDebit,
        decimal? TotalCredit,
        decimal? TotalBalance,
        int? AddedByUserID,
        DateTime? AddDate,
        int? EditedByUserID,
        DateTime? EditDate)
    {
        this.JouID = JouID;
        this.JouDate = JouDate;
        this.JouNote = JouNote;
        this.JouTypeID = JouTypeID;
        this.JouIsPost = JouIsPost;
        this.TotalDebit = TotalDebit;
        this.TotalCredit = TotalCredit;
        this.TotalBalance = TotalBalance;
        this.AddedByUserID = AddedByUserID;
        this.AddDate = AddDate;
        this.EditedByUserID = EditedByUserID;
        this.EditDate = EditDate;
        _Mode = enMode.Update;
    }

    private async Task<bool> _AddNewJournalHeaderAsync()
    {
       return await clsJournalHeadersData.AddNewJournalHeaderAsync(this.JouID,
            this.JouDate.HasValue ? this.JouDate.Value : default(DateTime),
            this.JouNote,
            this.JouTypeID.HasValue ? this.JouTypeID.Value : default(int),
            this.JouIsPost.HasValue ? this.JouIsPost.Value : default(bool),
            this.TotalDebit.HasValue ? this.TotalDebit.Value : default(decimal),
            this.TotalCredit.HasValue ? this.TotalCredit.Value : default(decimal),
            this.TotalBalance.HasValue ? this.TotalBalance.Value : default(decimal),
            this.AddedByUserID.HasValue ? this.AddedByUserID.Value : default(int),
            this.AddDate.HasValue ? this.AddDate.Value : default(DateTime)
);
        
    }

    private async Task<bool> _UpdateJournalHeaderAsync()
    {
        return await clsJournalHeadersData.UpdateJournalHeaderAsync(
            this.JouID,
            this.JouDate.HasValue ? this.JouDate.Value : default(DateTime),
            this.JouNote,
            this.JouTypeID.HasValue ? this.JouTypeID.Value : default(int),
            this.JouIsPost.HasValue ? this.JouIsPost.Value : default(bool),
            this.TotalDebit.HasValue ? this.TotalDebit.Value : default(decimal),
            this.TotalCredit.HasValue ? this.TotalCredit.Value : default(decimal),
            this.TotalBalance.HasValue ? this.TotalBalance.Value : default(decimal)
 ,
            this.EditedByUserID,
            this.EditDate);
    }

    public async Task<bool> SaveAsync()
    {
        switch (_Mode)
        {
            case enMode.Update:
                return await _UpdateJournalHeaderAsync();
            case enMode.AddNew:
                if (await _AddNewJournalHeaderAsync())
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
        return await clsJournalHeadersData.DeleteJournalHeaderAsync(this.JouID);
    }

    public static async Task<DataTable> GetAllJournalHeadersAsync()
    {
        return await clsJournalHeadersData.GetAllJournalHeadersAsync();
    }

    public static clsJournalHeaders GetJournalHeaderByID(int JouID)
    {
        DateTime? JouDate = null;
        string JouNote = null;
        int? JouTypeID = null;
        bool? JouIsPost = null;
        decimal? TotalDebit = null;
        decimal? TotalCredit = null;
        decimal? TotalBalance = null;
        int? AddedByUserID = null;
        DateTime? AddDate = null;
        int? EditedByUserID = null;
        DateTime? EditDate = null;

        bool isJournalHeaderFound = clsJournalHeadersData.FindJournalHeaderByID(
            JouID,
            ref JouDate,
            ref JouNote,
            ref JouTypeID,
            ref JouIsPost,
            ref TotalDebit,
            ref TotalCredit,
            ref TotalBalance,
            ref AddedByUserID,
            ref AddDate,
            ref EditedByUserID,
            ref EditDate);

        if (isJournalHeaderFound)
        {
            return new clsJournalHeaders(
                JouID,
                JouDate,
                JouNote,
                JouTypeID,
                JouIsPost,
                TotalDebit,
                TotalCredit,
                TotalBalance,
                AddedByUserID,
                AddDate,
                EditedByUserID,
                EditDate);
        }
        else
        {
            return null;
        }
    }

    public async static Task<int> GetLastJournalNumber()
    {
        return await clsJournalHeadersData.GetLastJournalNumber();
    }
}
