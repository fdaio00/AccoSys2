using System;
using System.Data;
using System.Threading.Tasks;

public class clsCurrency
{
    enum enMode { AddNew = 0, Update = 1 };
    private enMode _Mode;

    public int CurrencyID { get; set; }
    public string CurrencyNameAr { get; set; }
    public string CurrencyNameEn { get; set; }
    public string CurrencySymbol { get; set; }
    public decimal? CurrencyExchange { get; set; }
    public string CurrencyPenies { get; set; }


    public int CurrencyTypeID { get; set;  }
    public clsCurrency()
    {
        this.CurrencyID = -1;
        this.CurrencyNameAr = "";
        this.CurrencyNameEn = null;
        this.CurrencySymbol = "";
        this.CurrencyExchange = null;
        this.CurrencyPenies = "";
        this.CurrencyTypeID = -1;
        _Mode = enMode.AddNew;
    }

    public clsCurrency(
        int currencyID,
        string currencyNameAr,
        string currencyNameEn,
        string currencySymbol,
        decimal? currencyExchange,
        string currencyPenies,int CurrencyTypeID)
    {
        this.CurrencyID = currencyID;
        this.CurrencyNameAr = currencyNameAr;
        this.CurrencyNameEn = currencyNameEn;
        this.CurrencySymbol = currencySymbol;
        this.CurrencyExchange = currencyExchange;
        this.CurrencyPenies = currencyPenies;
        this.CurrencyTypeID = CurrencyTypeID;

        _Mode = enMode.Update;
    }

    private async Task<bool> _AddNewCurrencyAsync()
    {
        this.CurrencyID = await clsCurrencyData.AddNewCurrencyAsync(
            this.CurrencyNameAr,
            this.CurrencyNameEn,
            this.CurrencySymbol,
            this.CurrencyExchange,
            this.CurrencyPenies,
            this.CurrencyTypeID);
        return (this.CurrencyID > 0);
    }

    private async Task<bool> _UpdateCurrencyAsync()
    {
        return await clsCurrencyData.UpdateCurrencyAsync(
            this.CurrencyID,
            this.CurrencyNameAr,
            this.CurrencyNameEn,
            this.CurrencySymbol,
            this.CurrencyExchange,
            this.CurrencyPenies,
            this.CurrencyTypeID); ;
    }

    public async Task<bool> SaveAsync()
    {
        switch (_Mode)
        {
            case enMode.Update:
                return await _UpdateCurrencyAsync();
            case enMode.AddNew:
                if (await _AddNewCurrencyAsync())
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
        return await clsCurrencyData.DeleteCurrencyAsync(this.CurrencyID);
    }

    public static async Task<DataTable> GetAllCurrenciesAsync()
    {
        return await clsCurrencyData.GetAllCurrenciesAsync();
    }

    public static clsCurrency GetCurrencyByID(int CurrencyID)
    {
        string CurrencyNameAr = null;
        string CurrencyNameEn = null;
        string CurrencySymbol = null;
        decimal? CurrencyExchange = null;
        string CurrencyPenies = null;
        int CurrencyTypeID = 0; 

        bool isCurrencyFound = clsCurrencyData.FindCurrencyByID(
            CurrencyID,
            ref CurrencyNameAr,
            ref CurrencyNameEn,
            ref CurrencySymbol,
            ref CurrencyExchange,
            ref CurrencyPenies,
            ref CurrencyTypeID);

        if (isCurrencyFound)
        {
            return new clsCurrency(
                CurrencyID,
                CurrencyNameAr,
                CurrencyNameEn,
                CurrencySymbol,
                CurrencyExchange,
                CurrencyPenies,
                CurrencyTypeID);
        }
        else
        {
            return null;
        }
    }
    public static clsCurrency GetCurrencyByName(string currencyName)
    {
        int currencyID = -1;
        string currencyNameAr = null;
        string currencyNameEn = null;
        string currencySymbol = null;
        decimal? currencyExchange = null;
        string currencyPenies = null;
        int currencyTypeID = 0;

        bool isCurrencyFound = clsCurrencyData.FindCurrencyByName(ref currencyID,
            currencyName,
            ref currencyNameAr,
            ref currencyNameEn,
            ref currencySymbol,
            ref currencyExchange,
            ref currencyPenies,
            ref currencyTypeID);

        if (isCurrencyFound)
        {
            return new clsCurrency(
                currencyID,
                currencyNameAr,
                currencyNameEn,
                currencySymbol,
                currencyExchange,
                currencyPenies,
                currencyTypeID);
        }
        else
        {
            return null;
        }
    }

}
