using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PoultryManager
{
    public partial class dailyFeeding : UserControl
    {
        public dailyFeeding()
        {
            InitializeComponent();
            DateLabel.Text = DateTime.Now.ToShortDateString();
            gbupdate.Visible = false;

            //=================================================================================
            // POPULATE THE FORM IF DETAILS FOR THE DAY ALREADY EXISTED
            //=================================================================================
            //using (PoultryEntities db = new PoultryEntities())
            //{
            //    Feeding tblFeeding = new Feeding();
            //    DateTime dateTime = Convert.ToDateTime(DateLabel.Text);
            //    tblFeeding = db.Feedings.Where(x => x.Date == dateTime).FirstOrDefault();
            //    if (tblFeeding != null)
            //    {
            //        tbFeedUsed.Text = tblFeeding.FeedName;
            //        tbQuantity.Text = tblFeeding.Quantity.ToString();
            //        tbComment.Text = tblFeeding.Comment;
            //        tbWeight.Text = tblFeeding.Weight.ToString();

            //        btnSave.Text = "Update";

            //    }
            //    else
            //    {
            //        tbFeedUsed.Text = tbQuantity.Text = tbComment.Text = tbWeight.Text = " ";

            //    }

            //}
        }



        //=================================================================================


        //==========================================================================
        ///METHOD TO CHECK TB VALUE
        //==========================================================================

        private void tbcheck(TextBox text)
        {
            if (double.TryParse(text.Text, out double temp))
            {
                if (temp >= 0)
                {
                    //valid number (int)
                }
                else
                {
                    MessageBox.Show("Invalid number");
                    //invalid number (int)
                }
            }
            else
            {
                //Entered text is not a number (int)
                MessageBox.Show("Enter only a number");
            }
        }

        private void tbQuantity_Leave(object sender, EventArgs e)
        {
            tbcheck(tbQuantity);
        }

        private void tbWeight_Leave(object sender, EventArgs e)
        {
            tbcheck(tbWeight);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            switch (btnSave.Text)
            {
                case "Save":
                    {
                        try
                        {

                            if (tbQuantity.Text == "" || tbFeedUsed.Text == "")
                            {
                                if (tbQuantity.Text == "")
                                {
                                    tbQuantity.Focus();
                                }
                                else
                                {
                                    tbFeedUsed.Focus();
                                }
                                MessageBox.Show("Field cant be empty");

                            }
                            else
                            {
                                using (PoultryEntities db = new PoultryEntities())
                                {

                                    Feeding feeding = new Feeding();
                                    feeding.Date = Convert.ToDateTime(DateLabel.Text);
                                    feeding.FeedName = tbFeedUsed.Text;
                                    feeding.Quantity = Convert.ToInt32(tbQuantity.Text);
                                    feeding.Weight = Convert.ToDouble(tbWeight.Text);
                                    feeding.Comment = tbComment.Text;

                                    db.Feedings.Add(feeding);
                                    db.SaveChanges();

                                    MessageBox.Show(" Feeeding details Succesful done");

                                }

                            }
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("check input data");
                        }

                        break;
                    }

                default:
                    {
                        if (tbQuantity.Text == "" || tbFeedUsed.Text == "")
                        {
                            if (tbQuantity.Text == "")
                            {
                                tbQuantity.Focus();
                            }
                            else
                            {
                                tbFeedUsed.Focus();
                            }
                            MessageBox.Show("Field cant be empty");

                        }
                        else
                        {
                            using (PoultryEntities db = new PoultryEntities())
                            {

                                Feeding feeding = new Feeding();
                                DateTime dateTime = Convert.ToDateTime(DateLabel.Text);
                                feeding = db.Feedings.Where(x => x.Date == dateTime).FirstOrDefault();
                                //feeding.Date = Convert.ToDateTime(DateLabel.Text);
                                feeding.FeedName = tbFeedUsed.Text;
                                feeding.Quantity = Convert.ToInt32(tbQuantity.Text);
                                feeding.Weight = Convert.ToDouble(tbWeight.Text);
                                feeding.Comment = tbComment.Text;


                                db.SaveChanges();

                                MessageBox.Show(" Feeeding details Succesful Updated done");


                            }
                        }
                        break;
                    }
            }
        }

        private void btneditt_Click(object sender, EventArgs e)
        {
            using (PoultryEntities db = new PoultryEntities())
            {
                Feeding tblFeeding = new Feeding();
                DateTime dateTime = Convert.ToDateTime(dateTimePicker1.Text);

                // MessageBox.Show(dateTime.ToShortDateString());

                tblFeeding = db.Feedings.Where(x => x.Date == dateTime).FirstOrDefault();
                if (tblFeeding != null)
                {
                    tbUpdateFeed.Text = tblFeeding.FeedName;
                    tbUpdateQuantity.Text = tblFeeding.Quantity.ToString();
                    tbUpdateComment.Text = tblFeeding.Comment;
                    tbUpdateWeight.Text = tblFeeding.Weight.ToString();

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

        private void tbUpdateWeight_Leave(object sender, EventArgs e)
        {
            tbcheck(tbUpdateWeight);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (tbUpdateQuantity.Text == "" || tbUpdateFeed.Text == "")
            {
                if (tbUpdateQuantity.Text == "")
                {
                    tbUpdateQuantity.Focus();
                }
                else
                {
                    tbUpdateFeed.Focus();
                }
                MessageBox.Show("Field cant be empty");

            }
            else
            {
                using (PoultryEntities db = new PoultryEntities())
                {

                    Feeding feeding = new Feeding();
                    DateTime dateTime = Convert.ToDateTime(dateTimePicker1.Text);
                    feeding = db.Feedings.Where(x => x.Date == dateTime).FirstOrDefault();
                    //feeding.Date = Convert.ToDateTime(DateLabel.Text);
                    feeding.FeedName = tbUpdateFeed.Text;
                    feeding.Quantity = Convert.ToInt32(tbUpdateQuantity.Text);
                    feeding.Weight = Convert.ToDouble(tbUpdateWeight.Text);
                    feeding.Comment = tbUpdateComment.Text;

                    // db.Entry(feeding).State = EntityState.Modified;
                    db.SaveChanges();

                    MessageBox.Show(" Feeeding details Succesful Updated done");
                    gbSearch.Visible = true;
                    gbupdate.Visible = false;

                }

            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to cancel the Operation", "Cancel", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                gbSearch.Visible = true;
                gbupdate.Visible = false;
            }


        }

      
    }
}