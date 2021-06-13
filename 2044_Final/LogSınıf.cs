using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2044_Final
{
    public class LogSınıf : ILog
    {
        public EmailLog eLog = new EmailLog();
        public FileLog fLog = new FileLog();
        public SMSLog sLog = new SMSLog();
        public void logmesaji()
        {

        }

        public void uyarı() {

            eLog.logmesaji();
            fLog.logmesaji();
            sLog.logmesaji();
        }
    }
}
