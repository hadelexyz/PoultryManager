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
    public partial class Sales : UserControl
    {
        public Sales()
        {
            InitializeComponent();
            DateLabel.Text = DateTime.Now.ToShortDateString();
            gbupdate.Visible = false;

            //using (PoultryEntities db = new PoultryEntities())
            //{
            //    Sale tblSales = new Sale();
            //    DateTime dateTime = Convert.ToDateTime(DateLabel.Text);
            //    tblSales = db.Sales.Where(x => x.Date == dateTime).FirstOrDefault();

            //    if (tblSales != null)
            //    {
            //        tbSalePrice.Text = tblSales.Price.ToString();
            //        tbQuantity.Text = tblSales.Qty.ToString();
            //        tbComment.Text = tblSales.Comment;
            //        comboxSoldItem.Text = tblSales.SoldItems;

            //        btnsubmit.Text = "Update";
            //    }
            //    else
            //    {

            //    }
            //}
        }

        private void tbcheck(TextBox text)
        {
            if (int.TryParse(text.Text, out int temp))
            {
                if (temp >= 0)
                {
                    //valid number (int)
                }
                else
                {
                    MessageBox.Show("Invalid number");
                    text.Focus();
                    //invalid number (int)
                }
            }
            else
            {
                //Entered text is not a number (int)
                MessageBox.Show("Enter only a number");
                text.Focus();
            }
        }

        private void tbQuantity_Leave(object sender, EventArgs e)
        {
            tbcheck(tbQuantity);
        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            if (btnsubmit.Text == "Submit")
            {
                try
                {
                    string value = comboxSoldItem.SelectedItem.ToString();
                    if (value == "Select" || tbQuantity.Text == "")
                    {
                        if (value == "Select")
                        {
                            comboxSoldItem.Focus();
                        }
                        else
                        {
                            tbQuantity.Focus();
                        }
                        MessageBox.Show("Field cant be empty");

                    }
                    else
                    {
                        using (PoultryEntities db = new PoultryEntities())
                        {

                            Sale tblSales = new Sale();
                            tblSales.Date = Convert.ToDateTime(DateLabel.Text);
                            tblSales.Price = int.Parse(tbSalePrice.Text);
                            tblSales.Qty = int.Parse(tbQuantity.Text);
                            tblSales.SoldItems = Convert.ToString(comboxSoldItem.SelectedItem);
                            tblSales.Comment = tbComment.Text;

                            db.Sales.Add(tblSales);
                            db.SaveChanges();

                            MessageBox.Show("Sales details stored succesfully");
                        }

                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("check input data");


                }
            }
            else
            {
                string value = comboxSoldItem.SelectedItem.ToString();
                if (value == "Select" || tbQuantity.Text == "")
                {
                    if (value == "Select")
                    {
                        comboxSoldItem.Focus();
                    }
                    else
                    {
                        tbQuantity.Focus();
                    }
                    MessageBox.Show("Field cant be empty");

                }
                else
                {
                    using (PoultryEntities db = new PoultryEntities())
                    {

                        Sale tblSales = new Sale();
                        DateTime dateTime = Convert.ToDateTime(dateTimePicker1.Text);
                        tblSales = db.Sales.Where(x => x.Date == dateTime).FirstOrDefault();


                        tblSales.Price = int.Parse(tbSalePrice.Text);
                        tblSales.Qty = int.Parse(tbQuantity.Text);
                        tblSales.SoldItems = Convert.ToString(comboxSoldItem.SelectedItem);
                        tblSales.Comment = tbComment.Text;


                        db.SaveChanges();

                        MessageBox.Show("Sales details succesfully updated");
                    }
                }

            }

        }

        private void btneditt_Click(object sender, EventArgs e)
        {
            using (PoultryEntities db = new PoultryEntities())
            {
                Sale tblSales = new Sale();
                DateTime dateTime = Convert.ToDateTime(dateTimePicker1.Text);
                tblSales = db.Sales.Where(x => x.Date == dateTime).FirstOrDefault();
                if (tblSales != null)
                {
                    tbUpdatePrice.Text = tblSales.Price.ToString();
                    tbUpdateQuantity.Text = tblSales.Qty.ToString();
                    tbUpdateComment.Text = tblSales.Comment;
                    cbUpdateSoldItem.Text = tblSales.SoldItems;

                    gbupdate.Visible = true;
                    gbSearch.Visible = false;

                }
                else
                {
                    MessageBox.Show("No records for " + dateTime.ToShortDateString());
                }
            }

        }

        private void tbUpdateQuantity_Leave(object sender, EventArgs e)
        {
            tbcheck(tbUpdateQuantity);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                string value = cbUpdateSoldItem.SelectedItem.ToString();
                if (value == "Select" || tbUpdateQuantity.Text == "")
                {
                    if (value == "Select")
                    {
                        cbUpdateSoldItem.Focus();
                    }
                    else
                    {
                        tbUpdateQuantity.Focus();
                    }
                    MessageBox.Show("Field cant be empty");

                }
                else
                {
                    using (PoultryEntities db = new PoultryEntities())
                    {

                        Sale tblSales = new Sale();
                        DateTime dateTime = Convert.ToDateTime(dateTimePicker1.Text);
                        tblSales = db.Sales.Where(x => x.Date == dateTime).FirstOrDefault();

                        tblSales.Price = int.Parse(tbUpdatePrice.Text);
                        tblSales.Qty = int.Parse(tbUpdateQuantity.Text);
                        tblSales.SoldItems = Convert.ToString(cbUpdateSoldItem.SelectedItem);
                        tblSales.Comment = tbUpdateComment.Text;

                        db.SaveChanges();

                        MessageBox.Show("Sales details update succesfully");
                        gbupdate.Visible = false;
                        gbSearch.Visible = true;

                    }

                }
            }
            catch (Exception)
            {
                MessageBox.Show("check input data");


            }
        }
    }
}