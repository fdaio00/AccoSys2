using System;
using System.Data;
using System.Threading.Tasks;

public class clsOperationType
{
    enum enMode { AddNew = 0, Update = 1 };
    private enMode _Mode;

    public int OperationTypeID { get; set; }
    public string OperationName { get; set; }

    public clsOperationType()
    {
        this.OperationTypeID = -1;
        this.OperationName = string.Empty;
        _Mode = enMode.AddNew;
    }

    public clsOperationType(int operationTypeID, string operationName)
    {
        this.OperationTypeID = operationTypeID;
        this.OperationName = operationName;
        _Mode = enMode.Update;
    }

    private async Task<bool> _AddNewOperationTypeAsync()
    {
        return await clsOperationTypeData.AddNewOperationTypeAsync(this.OperationName);
    }

    private async Task<bool> _UpdateOperationTypeAsync()
    {
        return await clsOperationTypeData.UpdateOperationTypeAsync(this.OperationTypeID, this.OperationName);
    }

    public async Task<bool> SaveAsync()
    {
        switch (_Mode)
        {
            case enMode.Update:
                return await _UpdateOperationTypeAsync();
            case enMode.AddNew:
                if (await _AddNewOperationTypeAsync())
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
        return await clsOperationTypeData.DeleteOperationTypeAsync(this.OperationTypeID);
    }

    public static async Task<DataTable> GetAllOperationTypesAsync()
    {
        return await clsOperationTypeData.GetAllOperationTypesAsync();
    }

    public static clsOperationType GetOperationTypeByID(int operationTypeID)
    {
        string operationName = string.Empty;

        bool isOperationTypeFound = clsOperationTypeData.FindOperationTypeByID(operationTypeID, ref operationName);

        if (isOperationTypeFound)
        {
            return new clsOperationType(operationTypeID, operationName);
        }
        else
        {
            return null;
        }
    }
}
