using System;
using System.Data;
using System.Threading.Tasks;

public class clsCurrencyType
{
    enum enMode { AddNew = 0, Update = 1 };
    private enMode _Mode;

    public int CurrencyTypeID { get; set; }
    public string CurrencyTypeNameAr { get; set; }
    public string CurrencyTypeNameEn { get; set; }

    public clsCurrencyType()
    {
        this.CurrencyTypeID = -1;
        this.CurrencyTypeNameAr = "";
        this.CurrencyTypeNameEn = null;
        _Mode = enMode.AddNew;
    }

    public clsCurrencyType(
        int currencyTypeID,
        string currencyTypeNameAr,
        string currencyTypeNameEn)
    {
        this.CurrencyTypeID = currencyTypeID;
        this.CurrencyTypeNameAr = currencyTypeNameAr;
        this.CurrencyTypeNameEn = currencyTypeNameEn;
        _Mode = enMode.Update;
    }

    private async Task<bool> _AddNewCurrencyTypeAsync()
    {
        this.CurrencyTypeID = await clsCurrencyTypeData.AddNewCurrencyTypeAsync(
            this.CurrencyTypeNameAr,
            this.CurrencyTypeNameEn);
        return (this.CurrencyTypeID > 0);
    }

    private async Task<bool> _UpdateCurrencyTypeAsync()
    {
        return await clsCurrencyTypeData.UpdateCurrencyTypeAsync(
            this.CurrencyTypeID,
            this.CurrencyTypeNameAr,
            this.CurrencyTypeNameEn);
    }

    public async Task<bool> SaveAsync()
    {
        switch (_Mode)
        {
            case enMode.Update:
                return await _UpdateCurrencyTypeAsync();
            case enMode.AddNew:
                if (await _AddNewCurrencyTypeAsync())
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
        return await clsCurrencyTypeData.DeleteCurrencyTypeAsync(this.CurrencyTypeID);
    }

    public static async Task<DataTable> GetAllCurrencyTypesAsync()
    {
        return await clsCurrencyTypeData.GetAllCurrencyTypesAsync();
    }

    public static clsCurrencyType GetCurrencyTypeByID(int CurrencyTypeID)
    {
        string CurrencyTypeNameAr = null;
        string CurrencyTypeNameEn = null;

        bool isCurrencyTypeFound = clsCurrencyTypeData.FindCurrencyTypeByID(
            CurrencyTypeID,
            ref CurrencyTypeNameAr,
            ref CurrencyTypeNameEn);

        if (isCurrencyTypeFound)
        {
            return new clsCurrencyType(
                CurrencyTypeID,
                CurrencyTypeNameAr,
                CurrencyTypeNameEn);
        }
        else
        {
            return null;
        }
    }
}
