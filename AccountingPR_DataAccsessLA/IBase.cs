using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountingPR_DataAccsessLA
{
    public interface IBase<T> 
    {
        bool ExecuteCommand(string storedProcedureName, SqlParameter[] parameters);
        DataTable GetData(string storedProcedureName, SqlParameter[] parameters);


    }
}
