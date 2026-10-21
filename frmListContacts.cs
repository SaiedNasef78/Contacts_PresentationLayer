using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ContactsBusinessLayer;
namespace ContactsPresentationLayer
{
    public partial class frmListContacts : Form
    {
        public frmListContacts()
        {
            InitializeComponent();
        }

        private void _RefreshContactsList()
        {

            dgvAllContacts.DataSource = clsContact.GetAllContacts();

        }
        private DataView FilterByCountryID()
        {
            DataTable dataTable = clsContact.GetAllContacts();

            DataView dataView= dataTable.DefaultView;

            // Filter By Country
            dataView.RowFilter = $"CountryID='{txtFilterCountry.Text}'";
            return dataView;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _RefreshContactsList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmAddEditContact frm = new frmAddEditContact(-1);
            frm.ShowDialog();

        }

        private void EditContextMenu_Click(object sender, EventArgs e)
        {
            frmAddEditContact frm = new frmAddEditContact((int)dgvAllContacts.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            _RefreshContactsList();
        }

        private void DeleteContextMenue_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want too delete contant [" + dgvAllContacts.CurrentRow.Cells[0].Value + "]", "Conferm delete", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (clsContact.DeleteContact((int)dgvAllContacts.CurrentRow.Cells[0].Value))
                {
                    MessageBox.Show("Contact Deleted Successfully.");
                    _RefreshContactsList();
                }
                else
                {
                    MessageBox.Show("Contact is not Deleted Successfully.");
                }

            }
        }

        private void btnAddNewContact_Click(object sender, EventArgs e)
        {
            frmAddEditContact frm = new frmAddEditContact(-1);
            frm.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void OrderByFirstNameASC_OR_DESC()
        {
            DataTable dataTable = clsContact.GetAllContacts();

            DataView dataView = dataTable.DefaultView;
            if (RB_ASC.Checked)
            {
                dataView.Sort = "FirstName ASC";
             
            }
            else
            {

                dataView.Sort = "FirstName DESC";

            }
            dgvAllContacts.DataSource = dataView;
        }
        private void btnApply_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtFilterCountry.Text))
                dgvAllContacts.DataSource = FilterByCountryID();

            else
                MessageBox.Show("Please Enter CountryID", "Country", MessageBoxButtons.OKCancel);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtFilterCountry.Clear();
            _RefreshContactsList();
        }

        private void RB_ASC_CheckedChanged(object sender, EventArgs e)
        {
            OrderByFirstNameASC_OR_DESC();

        }

        private void RB_DESC_CheckedChanged(object sender, EventArgs e)
        {
            OrderByFirstNameASC_OR_DESC();
        }
    }
}
