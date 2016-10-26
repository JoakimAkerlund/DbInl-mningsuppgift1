using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Entity;

namespace DbInlämningsuppgift1
{
    public partial class Form1 : Form
    {
        List<Contact> ContactList = new List<Contact>();
        Contact contact = new Contact();
        Contact selectedPerson = new Contact();
        
        public Form1()
        {
            InitializeComponent();
            DisplayContacts();
            

        }
        private void DisplayContacts()
        {
            using (var db = new ContactContext())
            {
                var contacts = from c in db.Contact
                               select c;
                ContactList.Clear();
                foreach (var contact in contacts)
                {
                    ContactList.Add(contact);
                }


            }
            dgwDisplayContacts.Rows.Clear();
            
            foreach (var contact in ContactList)
            {
                dgwDisplayContacts.Rows.Add(contact);
            }
            txtName.Clear();
            txtStreetAddress.Clear();
            txtZipcode.Clear();
            txtCity.Clear();
            txtPhoneNr.Clear();
            txtEmail.Clear();
            dtpBirthday.ResetText();

        }
        
        private void cmdAddContact_Click(object sender, EventArgs e)
        {
            
                Contact contact = new Contact();
                contact.Name = txtName.Text;
                contact.StreetAddress = txtStreetAddress.Text;
                contact.Zipcode = txtZipcode.Text;
                contact.City = txtCity.Text;
                contact.PhoneNr = txtPhoneNr.Text;
                contact.Email = txtEmail.Text;
                contact.Birthday = dtpBirthday.Value;
                
                
                    using (var db = new ContactContext())
                    {
                        db.Contact.Add(contact);
                        db.SaveChanges();
                    }
                    DisplayContacts();

        }

        private void cmdEditContact_Click(object sender, EventArgs e)
        {
            using (var cmd = new ContactContext())
            {
                contact = cmd.Contact.Where(c => c.ContactId == selectedPerson.ContactId).FirstOrDefault<Contact>();
            }
            if (contact != null)
            {
                txtName.Text = contact.Name;
                txtStreetAddress.Text = contact.StreetAddress;
                txtZipcode.Text = contact.Zipcode.ToString();
                txtCity.Text = contact.City;
                txtPhoneNr.Text = contact.PhoneNr;
                txtEmail.Text = contact.Email;
                dtpBirthday.Value = contact.Birthday;

            }
            

        }
        private void cmdSaveContactChanges_Click(object sender, EventArgs e)
        {
            Contact contactToEdit = new Contact();

            using (var edit = new ContactContext())
            {
                contactToEdit = edit.Contact.Where(c => c.ContactId == selectedPerson.ContactId).FirstOrDefault<Contact>();
            }


            if (contactToEdit != null)
            {
                contactToEdit.Name = txtName.Text;
                contactToEdit.StreetAddress = txtStreetAddress.Text;
                contactToEdit.Zipcode = txtZipcode.Text;
                contactToEdit.City = txtCity.Text;
                contactToEdit.PhoneNr = txtPhoneNr.Text;
                contactToEdit.Email = txtEmail.Text;
                contactToEdit.Birthday = dtpBirthday.Value;
            }
            using (var db = new ContactContext())
            {
                db.Entry(contactToEdit).State = EntityState.Modified;
                db.SaveChanges();
            }

            DisplayContacts();
        }


        private void cmdDeleteContact_Click(object sender, EventArgs e)
        {
            Contact contactToDelete = new Contact();

            using(var ctx=new ContactContext())
            {
                contactToDelete = ctx.Contact.Where(c => c.ContactId == selectedPerson.ContactId).FirstOrDefault<Contact>();
            }
            using(var dlt=new ContactContext())
            {
                dlt.Entry(contactToDelete).State = EntityState.Deleted;
                dlt.SaveChanges();
            }
            DisplayContacts();
        }

        private void dgwDisplayContacts_SelectionChanged(object sender, EventArgs e)
        {
            
            try { 
            if (dgwDisplayContacts.SelectedCells[0] != null) {
                    selectedPerson = (Contact)dgwDisplayContacts.CurrentCell.Value;
            var selectedContact = (from c in ContactList
                                  where c.ContactId.Equals(selectedPerson.ContactId)
                                  select c).ToList();
            dgwDisplaySearchResult.DataSource = selectedContact;

                    

                }
            }
            catch
            {

            }
        }

        private void txtSearchName_KeyUp(object sender, KeyEventArgs e)
        {
            dgwDisplayContacts.Rows.Clear();
            List<Contact> SearchContactList = new List<Contact>();
            string searchString = txtSearchName.Text;
            if (txtSearchName.Text != "")
            {
                using(var search=new ContactContext())
                {
                    var contacts = from c in search.Contact
                                   where c.Name.Contains(searchString)
                                   select c;
                    foreach(var item in contacts)
                    {
                        SearchContactList.Add(item);
                    }
                    foreach(var c in SearchContactList)
                    {
                        dgwDisplayContacts.Rows.Add(c);
                    }
                }
                
            }
            else
            {
                DisplayContacts();
            }
            
        }
    }
}
