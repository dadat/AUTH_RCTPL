using AUTH_RCTPL.ServiceReference1;
using Mindscape.LightSpeed;
using Mindscape.LightSpeed.Querying;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

//Author DvdBarredo

namespace AUTH_RCTPL
{
    public partial class frmAuth : Form
    {
        public frmAuth()
        {
            InitializeComponent();
        }

        private void certMethod()
        {
            System.Net.ServicePointManager.ServerCertificateValidationCallback = delegate(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors) { return true; };
        }

        public int pageSize = 20;
        public int page = 1;
        public int skip()
        {
            return pageSize * (page - 1);
        }
            
        private void authenticationMethod()
        {
            try
            {
                certMethod();

                ServiceReference1.COCRegistrationClient cl = new ServiceReference1.COCRegistrationClient();
                ServiceReference1.registration reg = new ServiceReference1.registration();
                cl.ClientCredentials.UserName.UserName = "x";
                cl.ClientCredentials.UserName.Password = "x";

                AuthConnection objAuth = new AuthConnection();
                objAuth.LoadAuthConn();
                this.txtStatus.Text = "Connected...\n";

                using (var uow = AuthConnection.lscon.CreateUnitOfWork())
                {
                    var getRCTPL2 = (from a in uow.MPaips
                                     join b in uow.TBillchrghs
                                         on a.Papin equals b.Papin
                                     join c in uow.TBillchrgds
                                         on b.Bchchrgno equals c.Bchchrgno
                                     where ((c.AuthenCode != null && c.Colornum != null) && (c.AuthenStatus == null || c.AuthenStatus == "0"))
                                     orderby b.Bchdte descending
                                     select new
                                     {
                                         a.FirstName,
                                         a.Palname,
                                         a.MiddleName,
                                         a.AssuredTin,
                                         c.RegType,
                                         c.Coi,
                                         a.PlateNo,
                                         a.MvFileno,
                                         a.MotorNo,
                                         a.SerialNo,
                                         c.InceptionFrom,
                                         c.InceptionTo,
                                         a.MvType,
                                         a.TaxType,
                                         c.VehicleNumber,
                                         c.AuthenCode,
                                         c.Bchchrgno,
                                         c.TransType,
                                         c.Id,
                                         c.AuthenStatus
                                     }).Skip(skip()).Take(pageSize);
                    foreach (var item in getRCTPL2)
                    {
                        reg.username = "X";
                        reg.password = "X";
                        reg.assuredName = item.FirstName + " " + item.MiddleName + " " + item.Palname;
                        reg.assuredTin = "999-999-999-999";
                        var xRegType = "";
                        if (item.TransType == "X")
                        {
                            xRegType = "N";
                        }
                        else if (item.TransType == "X")
                        {
                            xRegType = "X";
                        }
                        reg.regType = xRegType;
                        reg.cocNo = item.Coi;
                        reg.plateNo = item.PlateNo;
                        reg.mvFileNo = item.MvFileno;
                        reg.engineNo = item.MotorNo;
                        reg.chassisNo = item.SerialNo;
                        reg.inceptionDate = Convert.ToString(item.InceptionFrom);
                        reg.expiryDate = Convert.ToString(item.InceptionTo);
                        reg.mvType = item.MvType;
                        reg.mvPremType = item.VehicleNumber;
                        reg.taxType = item.TaxType;
                        var respAuthRCTPL = cl.register(reg);
                        
                        txtStatus.AppendText(Convert.ToString(respAuthRCTPL.successMessage + respAuthRCTPL.errorMessage + " [Series] " + item.Coi + "\n"));

                        if ((respAuthRCTPL.successMessage != null || respAuthRCTPL.errorMessage != null) && item.AuthenStatus != "1")
                        {
                            var tbd = (from tdUp in uow.TBillchrgds
                                       where (tdUp.AuthenStatus == null || tdUp.AuthenStatus == "0") && tdUp.Bchchrgno == item.Bchchrgno
                                       select tdUp).FirstOrDefault();
                            tbd.AuthenStatus = "1";
                            uow.SaveChanges();
                        }

                        saveAuthenticationHist(reg.cocNo, reg.authNo, respAuthRCTPL.successMessage + respAuthRCTPL.errorMessage, respAuthRCTPL.authNo);
                    }
                    txtStatus.AppendText("End.\n");
                    page = page + 1;
                }
            }
            catch (Exception er)
            {
                txtStatus.AppendText(er.Message);
                throw;
            }
        }
        private void btnAuth_Click(object sender, EventArgs e)
        {
            btnAuth.Enabled = false;
            txtStatus.Text = "Connecting...";
            timer1.Interval = 5000;
            timer1.Start();
        }

        private void saveAuthenticationHist(string coi_, string authcode_, string authmessage_, string authUpdatedCode_)
        {
            try
            {
                using (var uow = AuthConnection.lscon.CreateUnitOfWork())
                {
                    TblBilldhist objHist = new TblBilldhist();
                    objHist.Coi = coi_;
                    objHist.AuthenCode = authcode_;
                    objHist.AuthenticationMessage = authmessage_;
                    objHist.DateTrans = DateTime.Now;

                    if (objHist.Errors.Count == 0)
                    {
                        uow.Add(objHist);
                        uow.SaveChanges();
                    }
                }
            }
            catch (Exception er)
            {
                txtStatus.AppendText("saveAuthenticationHist error: " + er.Message);
                throw;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtStatus.AppendText("Stopping procces...\n");
            timer1.Stop();
            if (backgroundWorkerRCTPL.CancellationPending)
            {
                backgroundWorkerRCTPL.CancelAsync();
            }
            txtStatus.AppendText("Stopped.");
            btnAuth.Enabled = true;
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            backgroundWorkerRCTPL.RunWorkerAsync();
        }

        private void frmAuth_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
        }

        private void backgroundWorkerRCTPL_DoWork(object sender, DoWorkEventArgs e)
        {
            button1.Enabled = false;
            authenticationMethod();
            button1.Enabled = true;
        }

        private void backgroundWorkerRCTPL_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            timer1.Start();
        }
    }
}
