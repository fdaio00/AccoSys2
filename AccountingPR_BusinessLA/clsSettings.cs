using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountingPR_BusinessLA
{
    public class clsSettings
    {

        public static void SetServerSettings(string Mode, string ServerName, string databaseName, string UserId = "", string Password = "")
        {
            clsDataAccessSettings.SetServerSettings(Mode, ServerName, databaseName, UserId, Password);
        }

        public static void SetErrorLoggerEvenr(string Message)
        {
             clsDataAccessSettings.SetErrorLoggingEvent(Message);
        }

    }
}
