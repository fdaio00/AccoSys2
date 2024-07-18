using AccountingPR_DataAccsessLA;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountingPR_BusinessLA
{
    public class clsLogin
    {

        //public static DataTable Login(string StoredProsedureName , SqlParameter[] parameters )
        //{
        //    //return CRUD_DB.GetData( StoredProsedureName , parameters );
        //}

        //public static DataTable Login(string UserName , string Password)
        //{
        //    //try
        //    //{
        //    //clsDataAccessSettings connection = clsConnection.GetConnection();
        //    //SqlParameter[] parameters = new SqlParameter[2];
        //    //parameters[0] = new SqlParameter("@UserName", SqlDbType.NVarChar);
        //    //parameters[0].Value = UserName;

        //    // parameters[1] = new SqlParameter("@Password", SqlDbType.NVarChar);
        //    //parameters[1].Value = Password;

        //    //DataTable dt = new DataTable();
        //    //dt = connection.GetData("SP_Login",parameters);
        //    //return dt; 

        //    //}
        //    //catch (Exception ex)
        //    //{
        //    //   clsSettings.SetErrorLoggerEvenr(ex.Message);
        //    //    return null; 
        //    //}

        //}

    }
}
