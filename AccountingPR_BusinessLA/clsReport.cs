using System;
using System.Data;
using System.Threading.Tasks;

public class clsReport
{
    enum enMode { AddNew = 0, Update = 1 };
    private enMode _Mode;

    public int ReportID { get; set; }
    public string ReportNameAr { get; set; }
    public string ReportNameEn { get; set; }

    public clsReport()
    {
        this.ReportID = -1;
        this.ReportNameAr = "";
        this.ReportNameEn = null;
        _Mode = enMode.AddNew;
    }

    public clsReport(
        int reportID,
        string reportNameAr,
        string reportNameEn)
    {
        this.ReportID = reportID;
        this.ReportNameAr = reportNameAr;
        this.ReportNameEn = reportNameEn;
        _Mode = enMode.Update;
    }

    private async Task<bool> _AddNewReportAsync()
    {
        this.ReportID = await clsReportData.AddNewReportAsync(
            this.ReportNameAr,
            this.ReportNameEn);
        return (this.ReportID > 0);
    }

    private async Task<bool> _UpdateReportAsync()
    {
        return await clsReportData.UpdateReportAsync(
            this.ReportID,
            this.ReportNameAr,
            this.ReportNameEn);
    }

    public async Task<bool> SaveAsync()
    {
        switch (_Mode)
        {
            case enMode.Update:
                return await _UpdateReportAsync();
            case enMode.AddNew:
                if (await _AddNewReportAsync())
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
        return await clsReportData.DeleteReportAsync(this.ReportID);
    }

    public static async Task<DataTable> GetAllReportsAsync()
    {
        return await clsReportData.GetAllReportsAsync();
    }

    public static clsReport GetReportByID(int ReportID)
    {
        string ReportNameAr = null;
        string ReportNameEn = null;

        bool isReportFound = clsReportData.FindReportByID(
            ReportID,
            ref ReportNameAr,
            ref ReportNameEn);

        if (isReportFound)
        {
            return new clsReport(
                ReportID,
                ReportNameAr,
                ReportNameEn);
        }
        else
        {
            return null;
        }
    }
}
