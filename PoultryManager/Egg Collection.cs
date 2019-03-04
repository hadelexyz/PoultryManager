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
    public partial class Egg_Collection : UserControl
    {
        public Egg_Collection()
        {
            InitializeComponent();
            lblGoodEggs.Text = "0";
            DateLabel.Text = DateTime.Now.ToShortDateString();
            gbupdate.Visible = false;

            //===============================================================
            // POPULATE IF DATE DETAILS EXIST
            //==============================================================
            //using (PoultryEntities db = new PoultryEntities())
            //{
            //    DateTime dateTime = Convert.ToDateTime(DateLabel.Text);
            //    Egg tblEgg = new Egg();
            //    tblEgg = db.Eggs.Where(x => x.Date == dateTime).FirstOrDefault();
            //    if (tblEgg != null)
            //    {
            //        tbCollected.Text = tblEgg.CollectedEggs.ToString();
            //        lblGoodEggs.Text = tblEgg.GoodEggs.ToString();
            //        tbBadEggs.Text = tblEgg.BadEggs.ToString();
            //        btnSave.Text = "Update";
            //    }
            //}
        }
        float answer;
        //======================================================
        // tbEgg event
        //========================================================
        private void tbBadEggs_Leave(object sender, EventArgs e)
        {
            try
            {
                if (tbCollected.Text == "")
                {
                    tbCollected.Focus();
                }
                else
                {
                    if (tbBadEggs.Text == "")
                    {
                        tbBadEggs.Text = "0";
                        tbBadEggs.Focus();
                        lblGoodEggs.Text = tbCollected.Text;
                    }
                    else
                    {
                        answer = int.Parse(tbCollected.Text) - int.Parse(tbBadEggs.Text);
                        if (answer < 0)
                        {
                            MessageBox.Show("invalid number of bad eggs");
                            tbBadEggs.Text = "0";
                            tbBadEggs.Focus();
                        }
                        else
                        {
                            lblGoodEggs.Text = answer.ToString();

                        }

                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("enter only a number");
                tbBadEggs.Focus();
            }
        }

        private void tbCollected_Leave(object sender, EventArgs e)
        {
            try
            {
                answer = int.Parse(tbCollected.Text) - int.Parse(tbBadEggs.Text);
                if (answer < 0)
                {
                    MessageBox.Show("invalid number of bad eggs");
                    tbBadEggs.Text = "0";
                    tbBadEggs.Focus();
                }
                else
                {
                    lblGoodEggs.Text = answer.ToString();

                }
            }
            catch (Exception)
            {
                MessageBox.Show("invalid number");
                tbCollected.Text = "0";
                tbCollected.Focus();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (btnSave.Text == "Save")
            {
                try
                {
                    if (tbCollected.Text == "" || tbBadEggs.Text == "")
                    {
                        MessageBox.Show("Some fields are empty");
                    }
                    else
                    {
                        using (PoultryEntities db = new PoultryEntities())
                        {
                            Egg tblEgg = new Egg();
                            tblEgg.Date = Convert.ToDateTime(DateLabel.Text);
                            tblEgg.CollectedEggs = int.Parse(tbCollected.Text);
                            tblEgg.GoodEggs = int.Parse(lblGoodEggs.Text);
                            tblEgg.BadEggs = int.Parse(tbBadEggs.Text);

                            db.Eggs.Add(tblEgg);
                            db.SaveChanges();
                            MessageBox.Show("Egg Details successfully stored");

                        }




                        MessageBox.Show("Egg Details succesfuly stored");
                    }
                }
                catch (Exception r)
                {
                    MessageBox.Show(r.Message);
                }
            }
            else
            {
                if (tbCollected.Text == "" || tbBadEggs.Text == "")
                {
                    MessageBox.Show("Some fields are empty");
                }
                else
                {
                    using (PoultryEntities db = new PoultryEntities())
                    {
                        DateTime dateTime = Convert.ToDateTime(DateLabel.Text);
                        Egg tblEgg = new Egg();
                        tblEgg = db.Eggs.Where(x => x.Date == dateTime).FirstOrDefault();

                        tblEgg.CollectedEggs = int.Parse(tbCollected.Text);
                        tblEgg.GoodEggs = int.Parse(lblGoodEggs.Text);
                        tblEgg.BadEggs = int.Parse(tbBadEggs.Text);


                        db.SaveChanges();
                        MessageBox.Show("Egg Details successfully Updated");

                    }
                }
            }
        }

        private void btneditt_Click(object sender, EventArgs e)
        {
            using (PoultryEntities db = new PoultryEntities())
            {
                Egg tblEgg = new Egg();
                DateTime dateTime = Convert.ToDateTime(dateTimePicker1.Text);
                tblEgg = db.Eggs.Where(x => x.Date == dateTime).FirstOrDefault();
                if (tblEgg != null)
                {
                    tbUpdatedCollected.Text = tblEgg.CollectedEggs.ToString();
                    gbupdate.Visible = true;
                    gbSearch.Visible = false;
                }
                else
                {
                    MessageBox.Show("No records for " + dateTime.ToShortDateString());
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbUpdatedCollected.Text == "")
                {
                    MessageBox.Show("Some fields are empty");
                    tbUpdatedCollected.Focus();
                }
                else
                {
                    using (PoultryEntities db = new PoultryEntities())
                    {

                        Egg tblEgg = new Egg();
                        DateTime dateTime = Convert.ToDateTime(dateTimePicker1.Text);

                        tblEgg = db.Eggs.Where(x => x.Date == dateTime).FirstOrDefault();

                        tblEgg.CollectedEggs = int.Parse(tbUpdatedCollected.Text);
                        db.SaveChanges();
                        MessageBox.Show("Egg Details successfully updated");

                        gbupdate.Visible = false;
                        gbSearch.Visible = true;

                    }
                }
            }
            catch (Exception r)
            {
                MessageBox.Show(r.Message);
            }
        }
    }
}