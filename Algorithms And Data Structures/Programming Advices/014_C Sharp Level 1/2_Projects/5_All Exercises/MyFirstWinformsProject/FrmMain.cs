using System.Windows.Forms;

namespace MyFirstWinformsProject
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnShowForm1_Click(object sender, System.EventArgs e)
        {
            Frm1 frm1 = new Frm1();
            frm1.Show();
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            FrmMessageBox frmMessageBox = new FrmMessageBox();
            frmMessageBox.ShowDialog();
        }

        private void btnComboBox_Click(object sender, System.EventArgs e)
        {
            FrmComboBox frmComboBox = new FrmComboBox();
            frmComboBox.ShowDialog();
        }

        private void btnTimer_Click(object sender, System.EventArgs e)
        {
            FrmTimer frmTimer = new FrmTimer();
            frmTimer.ShowDialog();
        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            Frm1 frm1 = new Frm1();
            frm1.ShowDialog();
        }

        private void btnCheckBoxRadioGroup_Click(object sender, System.EventArgs e)
        {
            FrmChkRadioGroup frmChkRadioGroup = new FrmChkRadioGroup();
            frmChkRadioGroup.ShowDialog();
        }

        private void button2_Click_1(object sender, System.EventArgs e)
        {
            FrmLinkLable frmLinkLable = new FrmLinkLable();
            frmLinkLable.ShowDialog();
        }

        private void btnNotifyIcon_Click(object sender, System.EventArgs e)
        {
            FrmNotifyIcon notifyIcon = new FrmNotifyIcon();
            notifyIcon.ShowDialog();
        }

        private void button3_Click(object sender, System.EventArgs e)
        {
            FrmTextBox frm1 = new FrmTextBox();
            frm1.ShowDialog();
        }

        private void btnCheckedListBox_Click(object sender, System.EventArgs e)
        {
            FrmCheckedListBox frmCheckedListBox = new FrmCheckedListBox();
            frmCheckedListBox.ShowDialog();
        }

        private void btnTreeView_Click(object sender, System.EventArgs e)
        {
            FrmTreeView frmTreeView = new FrmTreeView();
            frmTreeView.ShowDialog();
        }

        private void btnPictureBox_Click(object sender, System.EventArgs e)
        {
            FrmPictureBox frmPictureBox = new FrmPictureBox();
            frmPictureBox.ShowDialog();
        }

        private void btnDateTimePicker_Click(object sender, System.EventArgs e)
        {
            FrmDateTimePicker frmDateTimePicker = new FrmDateTimePicker();
            frmDateTimePicker.ShowDialog();
        }

        private void btnProgressBar_Click(object sender, System.EventArgs e)
        {
            FrrmProgressBar frrmProgressBar = new FrrmProgressBar();
            frrmProgressBar.ShowDialog();
        }

        private void btnMaskedTextBox_Click(object sender, System.EventArgs e)
        {
            FrmMaskedTextBox frmMaskedTextBox = new FrmMaskedTextBox();
            frmMaskedTextBox.ShowDialog();
        }

        private void btnMonthCalander_Click(object sender, System.EventArgs e)
        {
            FrmMonthCalander frmMonthCalander = new FrmMonthCalander();
            frmMonthCalander.ShowDialog();
        }

        private void btnListView_Click(object sender, System.EventArgs e)
        {
            FrmListView frmListView = new FrmListView();
            frmListView.ShowDialog();
        }

        private void button1_Click_1(object sender, System.EventArgs e)
        {
            FrmErrorProvider frmErrorProvider = new FrmErrorProvider();
            frmErrorProvider.ShowDialog();
        }

        private void btnTrackBar_Click(object sender, System.EventArgs e)
        {
            FrmTrackBar frmTrackBar = new FrmTrackBar();
            frmTrackBar.ShowDialog();
        }

        private void btnNumericUpDown_Click(object sender, System.EventArgs e)
        {
            FrmNumericUpDown frmNumericUpDown = new FrmNumericUpDown();
            frmNumericUpDown.ShowDialog();
        }

        private void button2_Click_2(object sender, System.EventArgs e)
        {
            FrmTabControl frmTabControl = new FrmTabControl();
            frmTabControl.ShowDialog();
        }

        private void btnGroupBoxvsPanel_Click(object sender, System.EventArgs e)
        {
            FrmGroupBoxvsPanel frmGroupBoxvsPanel = new FrmGroupBoxvsPanel();
            frmGroupBoxvsPanel.ShowDialog();
        }

        private void btnDialogs_Click(object sender, System.EventArgs e)
        {
            FrmDialogs frmDialogs = new FrmDialogs();
            frmDialogs.ShowDialog();
        }

        private void btnMenuStrip_Click(object sender, System.EventArgs e)
        {
            FrmMenuStrip frmMenuStrip = new FrmMenuStrip();
            frmMenuStrip.ShowDialog();
        }

        private void btnContextMenu_Click(object sender, System.EventArgs e)
        {
            FrmContextMenu frmContextMenu = new FrmContextMenu();
            frmContextMenu.ShowDialog();
        }
    }
}
