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
    public partial class FrmCheckedListBox : Form
    {
        public FrmCheckedListBox()
        {
            InitializeComponent();
        }

        private void btnAddItems_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= 5; i++)
                checkedListBox1.Items.Add("Item" + i);
        }

        private void btnShowSelectedItems_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBox1.CheckedItems.Count; i++)
                MessageBox.Show(checkedListBox1.CheckedItems[i].ToString());
        }

        private void btnCheckAllItems_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
                checkedListBox1.SetItemChecked(i, true);
        }

        private void btnUnCheckAllItems_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
                checkedListBox1.SetItemChecked(i, false);
        }

        private void btnRemoveFirstItem_Click(object sender, EventArgs e)
        {
            if (checkedListBox1.Items.Count > 0)
                checkedListBox1.Items.RemoveAt(0);
        }
    }
}
