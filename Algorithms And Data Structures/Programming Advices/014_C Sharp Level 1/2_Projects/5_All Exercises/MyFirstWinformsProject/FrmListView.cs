using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstWinformsProject
{
    public partial class FrmListView : Form
    {
        public FrmListView()
        {
            InitializeComponent();
        }
        private string getGender() => rbFemale.Checked ? rbFemale.Text : rbMale.Text;
        private void checkInputs()
        {
            if (String.IsNullOrEmpty(txtId.Text))
            {
                MessageBox.Show("Fill ID");
                return;
            }

            if (String.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("Fill Name");
                return;
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            checkInputs();

            ListViewItem item = new ListViewItem(txtId.Text.Trim());
            item.SubItems.Add(txtName.Text.Trim());
            item.SubItems.Add(getGender());

            if (getGender() == "Male")
                item.ImageIndex = 0;
            else
                item.ImageIndex = 1;

            listView1.Items.Add(item);

            txtId.Clear();
            txtName.Clear();
            txtId.Focus();
        }
        private void btnRemove_Click(object sender, EventArgs e)
        {
            listView1.Items.Remove(listView1.SelectedItems[0]);
        }
        private void btnFillRandom_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= 10; i++)
            {
                ListViewItem item = new ListViewItem(i.ToString());
                item.SubItems.Add("Person" + i);

                if (i % 2 == 0)
                    item.ImageIndex = 0;
                else
                    item.ImageIndex = 1;

                listView1.Items.Add(item);
            }
        }

        private void listView1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(listView1.SelectedItems[0].Text);
        }
        private void rbDetails_CheckedChanged(object sender, EventArgs e)
        {
            listView1.View = View.Details;
        }

        private void rbSmallIcon_CheckedChanged(object sender, EventArgs e)
        {
            listView1.View = View.SmallIcon;
        }

        private void rbLargIcon_CheckedChanged(object sender, EventArgs e)
        {
            listView1.View = View.LargeIcon;
        }

        private void rbTile_CheckedChanged(object sender, EventArgs e)
        {
            listView1.View = View.Tile;
        }

        private void rbList_CheckedChanged(object sender, EventArgs e)
        {
            listView1.View = View.List;
        }
    }
}
