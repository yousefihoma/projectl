using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryApp.Forms;
using Library1Utility;
using System.Net;
using System.Runtime.InteropServices;
namespace LibraryApp
{
    public partial class frmMain : Form
    {

        public frmMain()
        {
        //........................................+++++++++++++++++++++++++++++++++++
            InitializeComponent();
            btnUser.Region = System.Drawing.Region.FromHrgn(Library1Utility.Design.CreateRoundRectRgn(0, 0, btnUser.Width, btnUser.Height, 20, 20));
           btnBorrow.Region = System.Drawing.Region.FromHrgn(Library1Utility.Design.CreateRoundRectRgn(0, 0, btnBorrow.Width, btnBorrow.Height, 20, 20));
           btnReturn.Region = System.Drawing.Region.FromHrgn(Library1Utility.Design.CreateRoundRectRgn(0, 0, btnReturn.Width, btnReturn.Height, 20, 20));
            btnBook.Region = System.Drawing.Region.FromHrgn(Library1Utility.Design.CreateRoundRectRgn(0, 0, btnBook.Width, btnBook.Height, 20, 20));
            btnMember.Region = System.Drawing.Region.FromHrgn(Library1Utility.Design.CreateRoundRectRgn(0, 0, btnMember.Width, btnMember.Height, 20, 20));
            btnSendEmail.Region = System.Drawing.Region.FromHrgn(Library1Utility.Design.CreateRoundRectRgn(0, 0, btnSendEmail.Width, btnSendEmail.Height, 20, 20));
                   }
        private void frmMain_Load(object sender, EventArgs e)
        {

            string t = lblFine.Text;
            LblDate.Text = Convertor.ToShamsi(DateTime.Now);
            lblTitle.Text = $" سیستم مدیریت کتابخانه های عمومی - {t} ";
        }
        private void lblTempExit_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void btnFine_Click(object sender, EventArgs e)
        {
            frmBorrow frmBorrow = new frmBorrow();
            frmBorrow.ShowDialog();
            this.Close();
        }

        private void pcExit_Click(object sender, EventArgs e)
        {
            frmLogin frmLogin = new frmLogin();
            frmLogin.ShowDialog();
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("HH:mm:ss");

        }

        private void btnBorrow_Click(object sender, EventArgs e)
        {
            frmBorrow frmBorrow = new frmBorrow();
            frmBorrow.ShowDialog();
        }

        private void btnBorrow_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTipbtnBorrow = new ToolTip();
            toolTipbtnBorrow.ShowAlways = true;
            toolTipbtnBorrow.SetToolTip(btnBorrow, "امانت");
        }

        private void btnMember_MouseHover(object sender, EventArgs e)
        {

            ToolTip toolTipbtnMember = new ToolTip();
            toolTipbtnMember.ShowAlways = true;
            toolTipbtnMember.SetToolTip(btnMember, "عضو");


        }

        private void btnBook_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTipbtnBook = new ToolTip();
            toolTipbtnBook.ShowAlways = true;
            toolTipbtnBook.SetToolTip(btnBook, "کتاب");

        }

        private void btnPersonel_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTipbtnPersonel = new ToolTip();
            toolTipbtnPersonel.ShowAlways = true;
            toolTipbtnPersonel.SetToolTip(btnReturn, "پرسنل");


        }



        private void btnMember_Click(object sender, EventArgs e)
        {


        }

        private void LblDate_Click(object sender, EventArgs e)
        {

        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            frmBook frmBooks = new frmBook();
            frmBooks.ShowDialog();
            this.Close();
        }

        private void lblTime_Click(object sender, EventArgs e)
        {

        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            plnSide.Top = lblExit.Top;
            Application.Exit();

        }

        private void lblMinimize_Click(object sender, EventArgs e)
        {

            this.WindowState = FormWindowState.Minimized;
        }

        private void lblTempExit_Click_1(object sender, EventArgs e)
        {

            plnSide.Top = lblTempExit.Top; this.Close();
            frmLogin frmLogin = new frmLogin();
            frmLogin.ShowDialog();
        }

        private void lblHistory_Click(object sender, EventArgs e)
        {
            //  plnSide.Height = lblHistory.Height;
            plnSide.Top = lblHistory.Top;
        }

        private void lblReport_Click(object sender, EventArgs e)
        {

            plnSide.Top = lblReport.Top;
        }

        private void lblFine_Click(object sender, EventArgs e)
        {

            plnSide.Top = lblFine.Top;
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            //string PcName = System.Environment.MachineName;
            //string IP = "";
            //IPHostEntry ipe = Dns.GetHostByName(PcName);
            //IPAddress iPAddress = ipe.AddressList;
            //lblFine.Text = iPAddress[0].ToString();
        }

        private void plnTop_MouseDown(object sender, MouseEventArgs e)
        {



        }

        private void btnMember_Click_1(object sender, EventArgs e)
        {

            frmMembers frmMembers = new frmMembers();
            frmMembers.ShowDialog();
        }
    }
}
