using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace PoultryManager
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            groupBox2.Visible = false;
            
           // lbCreateAccount.Visible = false;
        }

       

        private void label9_Click_1(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            groupBox2.Visible = false;
        }

        private void label3_Click_1(object sender, EventArgs e)
        {
            groupBox2.Visible = true;
            groupBox1.Visible = false;
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {

            using (PoultryEntities db = new PoultryEntities())
            {

                var query = from user in db.Accounts
                            where user.Username == tbLoginUsername.Text.Trim() && user.Password == tbLoginPassword.Text.Trim()
                            select user;


                if (query.Any())
                {
                    MessageBox.Show("Success");
                    Home home = new Home();
                    home.ShowDialog();
                }
                else
                {
                    MessageBox.Show("username and password incorrect");
                }
            }
            //if (IsValidUser(tbLoginUsername, tbPassword))
            //{
            //    Home home = new Home();
            //    home.ShowDialog();
            //}
            //else
            //{
            //    MessageBox.Show("username and password incorrect");
            //}
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            
            
               
                if (tbEmail.Text == "" | tbPassword.Text == "" | tbUsername.Text == "" | tbConfirmPass.Text == "")
                {
                    MessageBox.Show("field cannot be empty");
                    if( tbEmail.Text == "")
                    {
                        tbEmail.Focus();
                    }
                    else if(tbPassword.Text == "")
                    {
                        tbPassword.Focus();
                    }
                    else if (tbUsername.Text == "")
                    {
                        tbUsername.Focus();
                    }
                    else
                    {
                        tbConfirmPass.Focus();
                    }
                }
                else
                {
                    if (checkBoxTerm.Checked)
                    {   
                        using (PoultryEntities db = new PoultryEntities())
                        {
                            Account tblAccount = new Account();

                            tblAccount.Username = tbUsername.Text.Trim();
                            tblAccount.Password = tbPassword.Text.Trim();
                            tblAccount.Email = tbEmail.Text;
                            if (db.Accounts.Any(o => o.Email == tbEmail.Text) | db.Accounts.Any(o => o.Username == tbUsername.Text))
                            {
                                MessageBox.Show("User exist");
                            }
                            else
                            {
                                db.Accounts.Add(tblAccount);
                                db.SaveChanges();
                                MessageBox.Show("Account succesfully stored");
                            }
                               
                            
                        }
                    }
                    else
                    {
                        MessageBox.Show("check all boxes");
                        checkBoxTerm.Focus();
                    }
                   
                }
            
            //catch (Exception r)
            //{

            //    MessageBox.Show(r.Message);
            //} 
        }
       

        private void tbEmail_Leave(object sender, EventArgs e)
        {
            string email = tbEmail.Text;
            if (email.IndexOf("@") == -1)
            {
                MessageBox.Show("invalid mail");
                tbEmail.Focus();
            }
            else
            {
                if (email.Substring(email.Length - 4) == ".com")
                {
                    
                }
                else
                {
                    tbEmail.Focus();
                }
            }
            tbcheck(tbEmail);
        }
        //===========================================================
        // Password reader
        //============================================================
       
        private void tbConfirmPass_Leave(object sender, EventArgs e)
        {
            string value = (tbPassword.Text); 
            string confirm = (tbConfirmPass.Text);
            if (value != confirm)
            {
                MessageBox.Show("Password do not match");
                tbPassword.Focus();
            }
            tbcheck(tbConfirmPass);
        }

        private void tbUsername_Leave(object sender, EventArgs e)
        {
            tbcheck(tbUsername);
        }

        private void tbPassword_Leave(object sender, EventArgs e)
        {
            string value = tbPassword.Text.Trim(); ;
            string confirm = tbConfirmPass.Text.Trim();
            if (value != confirm)
            {
                MessageBox.Show("Password do not match");
                tbConfirmPass.Focus();
            }
            tbcheck(tbPassword);
        }
        //======================================================================================
        // VALIDATE ALL TEXTBOX 
        //======================================================================================
        private void tbcheck(TextBox textBox)
        {
            if (textBox.Text == "")
            {
                MessageBox.Show("field can't be empty");
                textBox.Focus();
            }
        }
        //===========================================================================
        // METHOD TO VALIDATE USER 
        //===========================================================================
        //private bool IsValidUser(TextBox userName,TextBox password)
        //{
        //    using (PoultryEntities db = new PoultryEntities())
        //    {

        //        var query = from user in db.Accounts
        //                    where user.Username == userName.Text.Trim() && user.Password == password.Text.Trim()
        //                    select user;


        //        if (query.Any())
        //        {
        //            return true;
        //        }
        //        else
        //        {
        //            return false;
        //        }
        //    }

        //}
    }
}
