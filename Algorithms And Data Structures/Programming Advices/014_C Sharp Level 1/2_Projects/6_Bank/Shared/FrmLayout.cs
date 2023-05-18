using Lab.Bank.Models;
using System;
using System.Windows.Forms;

namespace Bank.Shared
{
    public partial class FrmLayout : Form
    {
        protected User _loggedUser;
        public FrmLayout(string text)
        {
            InitializeComponent();
            this.Text = text;
            if (!String.IsNullOrEmpty(LoggedUser.loggedUser.UserName))
                lblWelcome.Text = "Welcome: " + LoggedUser.loggedUser.UserName.ToUpper();
        }
        private FrmLayout() { }
        private void FrmLayout_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            System.Timers.Timer timer = new System.Timers.Timer();
            timer.Interval = 1000;
            timer.Elapsed += timerElapsed;
            timer.Start();
        }
        private void timerElapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            lblClock.Invoke((MethodInvoker)delegate
            {
                lblDate.Text = DateTime.Now.ToString("dddd, MMMM yyyy");
                lblClock.Text = DateTime.Now.ToString("hh:mm:ss");
                lblSup.Text = DateTime.Now.ToString("tt"); //AM PM
            });
        }
        private void lnkSaleemPortfolio_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lnkSaleemPortfolio.LinkVisited = true;
            System.Diagnostics.Process.Start("https://saleemkassabportfolio.000webhostapp.com/index.html");
        }

        private void pnlSideBar_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
