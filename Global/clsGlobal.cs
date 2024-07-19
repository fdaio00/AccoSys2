using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccountingPR_BusinessLA;
using Microsoft.Win32; 

namespace AccountingPR.Global
{
    public class clsGlobal
    {

        public static bool SaveCredintail(string UserName , string Password)
        {
            bool successed = false;

            string KeyPath = @"HKEY_CURRENT_USER\SOFTWARE\Accounting";
            string UserNameKey = "UserName";
            string PasswordKey = "Password";
            string UserNameValue = UserName;
            string PasswordValue = Password;

            try
            {
                Registry.SetValue(KeyPath, UserNameKey, UserNameValue);
                Registry.SetValue(KeyPath, PasswordKey, PasswordValue);

                successed = true; 
            }
            catch (Exception ex)
            {
                clsSettings.SetErrorLoggerEvenr(ex.Message);
            }


                return successed; 
        }

        public static bool GetCredintail( ref string  UserName, ref string Password)
        {
            bool successed = false;

            string KeyPath = @"HKEY_CURRENT_USER\SOFTWARE\Accounting";
            string UserNameKey = "UserName";
            string PasswordKey = "Password";


            try
            {
                             
                UserName = Registry.GetValue(KeyPath, UserNameKey, null) as string;
                Password = Registry.GetValue(KeyPath, PasswordKey, null) as string;

                successed = true;
            }
            catch (Exception ex)
            {

                clsSettings.SetErrorLoggerEvenr(ex.Message);
                throw;
            }


            return successed;
        }

        public static clsUser CurrentUser; 
        static public void SetErrorLoggingEvent(string exMessage)
        {

            string sourceName = "Accounting";

            if (!EventLog.SourceExists(sourceName))
            {
                EventLog.CreateEventSource(sourceName, "Application");

            }


            EventLog.WriteEntry(sourceName, exMessage, EventLogEntryType.Error);

        }
    }
}
