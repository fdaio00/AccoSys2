using System;
using System.Data;
using System.Threading.Tasks;

public class clsCompany
{

    enum enMode { AddNew =0 ,Update=1};
    private enMode _Mode; 
    public int CompanyID { get; set; }
    public string CompanyNameAr { get; set; }
    public string CompanyNameEn { get; set; }
    public string AddressAr { get; set; }
    public string AddressEn { get; set; }
    public string Phone { get; set; }
    public string Fax { get; set; }
    public string Email { get; set; }
    public string Website { get; set; }
    public byte[] Logo { get; set; }
    // Handle Logo property if needed

    public clsCompany()
    {
        this.CompanyID = -1;
        this.CompanyNameAr = "";
        this.CompanyNameEn = null;
        this.AddressAr = "";
        this.AddressEn = null;
        this.Phone = null;
        this.Fax = null;
        this.Email = null;
        this.Website = null;
        _Mode = enMode.AddNew;
    }

    public clsCompany(int companyID, string companyNameAr, string companyNameEn, string addressAr,
        string addressEn, string phone, string fax, string email, string website, byte[] Logo)
    {
        this.CompanyID = companyID;
        this.CompanyNameAr = companyNameAr;
        this.CompanyNameEn = companyNameEn;
        this.AddressAr = addressAr;
        this.AddressEn = addressEn;
        this.Phone = phone;
        this.Fax = fax;
        this.Email = email;
        this.Website = website;
        this.Logo = Logo; 
        _Mode = enMode.Update; 
    }

    private async Task<bool> _AddNewCompanyAsync()
    {
        this.CompanyID = await clsCompanyData.AddNewCompanyAsync(this.CompanyNameAr, CompanyNameEn, AddressAr, AddressEn, Phone, Fax, Email, Website, Logo);
        return (this.CompanyID > 0);
    }
     private async Task<bool> _UpdateCompanyAsync()
    {
        return await clsCompanyData.UpdateCompanyAsync(this.CompanyID,this.CompanyNameAr, CompanyNameEn, AddressAr, AddressEn, Phone, Fax, Email, Website, Logo);
    }

    public async Task<bool> SaveAsync()
    {

        switch (_Mode)
        {
            case enMode.Update:
                return await _UpdateCompanyAsync();
            case enMode.AddNew:
                if (await _AddNewCompanyAsync())
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

    public static async Task<bool> DeleteAsync(int CompanyID)
    {
    
            return await clsCompanyData.DeleteCompanyAsync(CompanyID);
        
       
    }

    public static async Task<DataTable> GetAllCompaniesAsync()
    {
        return await clsCompanyData.GetAllCompaniesAsync();
    }

    public static  clsCompany GetCompanyByIDAsync(int CompanyID)
    {

        string CompanyNameAr = null;
        string CompanyNameEn = null;
        string AddressAr = null;
        string AddressEn = null;
        string Phone = null;
        string Fax = null;
        string Email = null;
        string Website = null;
        byte[] Logo = null;

        bool isCompanyFound =  clsCompanyData.FindCompanyByID(
                                                                       CompanyID,
                                                                      ref CompanyNameAr,
                                                                      ref CompanyNameEn,
                                                                      ref AddressAr,
                                                                      ref AddressEn,
                                                                      ref Phone,
                                                                      ref Fax,
                                                                      ref Email,
                                                                      ref Website,
                                                                      ref Logo);
        if (isCompanyFound)
        {
           return  new clsCompany(CompanyID,CompanyNameAr,CompanyNameEn,AddressAr,AddressEn,Phone,Fax,Email,Website,Logo);
            // Use retrievedLogo byte[] data as needed
        }
        else
        {
            return null;
        }
    }
}
