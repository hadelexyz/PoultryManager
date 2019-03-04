using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PoultryManager
{
    public partial class Expenses : UserControl
    {
        public Expenses()
        {
            InitializeComponent();
            DateLabel.Text = DateTime.Now.ToShortDateString();
            gbupdate.Visible = false;
            //using (PoultryEntities db = new PoultryEntities())
            //{
            //    var answer = db.Sales.Sum(s => s.Price);
            //    var expenses = db.Expenses.Sum(x => x.ExpAmount);

            //    var total = answer - expenses;

            //    label10.Text = total.ToString();

            //}

            //====================================================================================
            // CODE TO POPULATE FORM..IF THE DAYS RECORDS HAS BEEN DONE
            //===================================================================================
            //using (PoultryEntities db = new PoultryEntities())
            //{
            //    Expense tblExpense = new Expense();
            //    DateTime dateTime = Convert.ToDateTime(DateLabel.Text);
            //    tblExpense = db.Expenses.Where(x => x.Date == dateTime).FirstOrDefault();
            //    if (tblExpense != null)
            //    {
            //        tbCategory.Text = tblExpense.Category;
            //        tbAmount.Text = tblExpense.ExpAmount.ToString();
            //        btnSave.Text = "Update";
            //    }

            //}
        }

        public void tbCheck(TextBox textBox)
        {
            if (int.TryParse(textBox.Text, out int temp))
            {
                if (temp >= 0)
                {
                    //valid number (int)
                }
                else
                {
                    MessageBox.Show("Invalid number");
                    tbAmount.Focus();
                }
            }
            else
            {
                //Entered text is not a number (int)
                MessageBox.Show("Enter only a number");
                tbAmount.Focus();
            }
        }

        private void tbAmount_Leave(object sender, EventArgs e)
        {
            tbCheck(tbAmount);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (btnSave.Text == "Save")
            {
                string value = tbCategory.Text;
                if (value == "" || tbAmount.Text == "")
                {
                    if (value == "")
                    {
                        tbCategory.Focus();
                    }
                    else
                    {
                        tbAmount.Focus();
                    }
                    MessageBox.Show("Field cant be empty");

                }
                else
                {
                    using (PoultryEntities db = new PoultryEntities())
                    {
                        Expense tblExpense = new Expense();
                        tblExpense.Date = Convert.ToDateTime(DateLabel.Text);
                        tblExpense.Category = tbCategory.Text;
                        tblExpense.ExpAmount = int.Parse(tbAmount.Text);

                        db.Expenses.Add(tblExpense);
                        db.SaveChanges();


                        MessageBox.Show("Expense succesful");
                    }


                }
            }
            else
            {
                string value = tbCategory.Text;
                if (value == "" || tbAmount.Text == "")
                {
                    if (value == "")
                    {
                        tbCategory.Focus();
                    }
                    else
                    {
                        tbAmount.Focus();
                    }
                    MessageBox.Show("Field cant be empty");

                }
                else
                {
                    using (PoultryEntities db = new PoultryEntities())
                    {

                        Expense tblExpense = new Expense();
                        DateTime dateTime = Convert.ToDateTime(DateLabel.Text);

                        tblExpense = db.Expenses.Where(x => x.Date == dateTime).FirstOrDefault();

                        tblExpense.Category = tbCategory.Text;
                        tblExpense.ExpAmount = int.Parse(tbAmount.Text);
                        db.SaveChanges();
                        MessageBox.Show("Expenses succesfully updated");
                    }
                }
            }
        }

        private void tbCategory_Leave(object sender, EventArgs e)
        {
            if (int.TryParse(tbCategory.Text, out int temp))
            {
                if (temp >= 0 | temp < 0)
                {
                    MessageBox.Show("Enter only words");
                    tbCategory.Focus();
                }
            }
            else
            {
                // continue
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string value = tbUpdateCater.Text;
            if (value == "" || tbUpdateExpAmt.Text == "")
            {
                if (value == "")
                {
                    tbUpdateCater.Focus();
                }
                else
                {
                    tbUpdateExpAmt.Focus();
                }
                MessageBox.Show("Field cant be empty");

            }
            else
            {
                using (PoultryEntities db = new PoultryEntities())
                {

                    Expense tblExpense = new Expense();
                    DateTime dateTime = Convert.ToDateTime(dateTimePicker1.Text);

                    tblExpense = db.Expenses.Where(x => x.Date == dateTime).FirstOrDefault();

                    tblExpense.Category = tbUpdateCater.Text;
                    tblExpense.ExpAmount = int.Parse(tbUpdateExpAmt.Text);


                    db.SaveChanges();


                    MessageBox.Show("Expense updated succesful");
                    gbupdate.Visible = false;
                    gbSearch.Visible = true;

                }


            }

        }
        private void btneditt_Click_1(object sender, EventArgs e)
        {
            using (PoultryEntities db = new PoultryEntities())
            {
                Expense tblExpenses = new Expense();
                DateTime dateTime = Convert.ToDateTime(dateTimePicker1.Text);

                // MessageBox.Show(dateTime.ToShortDateString());

                tblExpenses = db.Expenses.Where(x => x.Date == dateTime).FirstOrDefault();
                if (tblExpenses != null)
                {
                    tbUpdateCater.Text = tblExpenses.Category;
                    tbUpdateExpAmt.Text = tblExpenses.ExpAmount.ToString();



                    gbupdate.Visible = true;
                    gbSearch.Visible = false;

                }
                else
                {
                    MessageBox.Show("No records for " + dateTime.ToShortDateString());
                }

            }
        }

    }
}