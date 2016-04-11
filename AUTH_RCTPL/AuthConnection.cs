using Mindscape.LightSpeed;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AUTH_RCTPL
{
    class AuthConnection
    {
        public static LightSpeedContext<LSMAuthenticationUnitOfWork> lscon = new LightSpeedContext<LSMAuthenticationUnitOfWork>();

        private void privLoadAuthRCTPLConnection()
        {
            lscon.ConnectionString = "Data Source="+ AUTH_RCTPL.Properties.Settings.Default.myServer +";Initial Catalog="+ AUTH_RCTPL.Properties.Settings.Default.myDB +";Persist Security Info=True;User ID=X;Password=X";
            lscon.IdentityMethod = IdentityMethod.IdentityColumn;
            lscon.DataProvider = DataProvider.SqlServer2008;
            lscon.QuoteIdentifiers = true;
        }

        public void LoadAuthConn()
        {
            privLoadAuthRCTPLConnection();
        }
    }
}
