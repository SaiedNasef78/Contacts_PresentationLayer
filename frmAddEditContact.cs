using ContactsBusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactsPresentationLayer
{
  
    public partial class frmAddEditContact : Form
    {
        private enum enMode { AddNew = 0, Update = 1 };
        private enMode _Mode;
        int _ContactID;
        clsContact _Contact;
       private string _ImagePath = "";
        public frmAddEditContact(int ContactID)
        {
            
            InitializeComponent();
            _ContactID = ContactID;
            if (_ContactID == -1)
            {
                _Mode = enMode.AddNew;
            }
            else
            {
                _Mode = enMode.Update;
            }
        }
        private void _FillCountriesInComboBox()
        {
            DataTable dtCountries = clsCountry.GetAllCountries();

            foreach (DataRow row in dtCountries.Rows)
            {
                cbCountry.Items.Add(row["CountryName"]);
            }
        }
        private void _LoadData()
        {

            _FillCountriesInComboBox();
            LbRemove.Visible = false;
            cbCountry.SelectedIndex = 0;
            if (_Mode == enMode.AddNew)
            {
                LblMode.Text = "Add New Contact";
                _Contact = new clsContact();
                return;

            }

            _Contact = clsContact.Find(_ContactID);
            if (_Contact == null)
            {
                MessageBox.Show($"This from will be closed because No Contact with ID ={_ContactID}");
                this.Close();

            }

            LblMode.Text=$"Edit ContactID = {_ContactID}";
            LblContactID.Text=_ContactID.ToString();
            gtxtbFirstName.Text= _Contact.FirstName;
            gtxtbLastName.Text= _Contact.LastName;
            gtxtbEmail.Text= _Contact.Email;
            gtxtbPhone.Text = _Contact.Phone;
            gtbAddress.Text = _Contact.Address;
            LbRemove.Visible = (_Contact.ImagePath != "");
            LblSetImage.Visible= (_Contact.ImagePath == "");
            if (_Contact.ImagePath != "")
            {
                gpbImage.Load(_Contact.ImagePath);
                
            }
            dtpDateOfBirth.Value = _Contact.DateOfBirth;
            cbCountry.SelectedIndex = cbCountry.FindString(clsCountry.Find(_Contact.CountryID).CountryName);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
      
        private void cbCountry_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void gpbImage_Click(object sender, EventArgs e)
        {

        }

        private void frmAddEditContact_Load(object sender, EventArgs e)
        {
            _LoadData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {


            int CountryID = clsCountry.Find(cbCountry.Text).CounntryID;
            _Contact.FirstName = gtxtbFirstName.Text;
            _Contact.LastName = gtxtbLastName.Text;
            _Contact.Address = gtbAddress.Text;
            _Contact.Email = gtxtbEmail.Text;
            _Contact.Phone = gtxtbPhone.Text;
            _Contact.CountryID = CountryID;
            _Contact.DateOfBirth = dtpDateOfBirth.Value;


            if (gpbImage.ImageLocation != null)
            {
                _Contact.ImagePath = gpbImage.ImageLocation;
              
            }

            else
                _Contact.ImagePath = "";

            // _Contact.ImagePath = _ImagePath;
            if (_Contact.Save())
            {
                MessageBox.Show("Data Saved Successfully");
            }
            else
            {
                MessageBox.Show("Data is not Saved Successfully");
            }
            _Mode = enMode.Update;
            LblMode.Text = "Edit Contact ID = " + _Contact.ID;
            LblContactID.Text = _Contact.ID.ToString();

        }

        private void LblMode_Click(object sender, EventArgs e)
        {

        }

        private void LblSetImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.DefaultExt = @"C:\";
           openFileDialog1.Filter = "Image Files|*.jpg;*.png;.gif;*.bmp;*JPEG";
            openFileDialog1.FilterIndex = 1; 
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
               
             _ImagePath = openFileDialog1.FileName;
               gpbImage.ImageLocation = _ImagePath;
                gpbImage.Load(_ImagePath);
                LblSetImage.Visible = false;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LbRemove_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LbRemove.Visible = false;
           gpbImage.Image= null;
        }
    }
}
