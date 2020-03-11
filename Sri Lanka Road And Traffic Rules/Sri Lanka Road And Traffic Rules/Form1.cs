using System.Threading;
using System.Windows.Forms;
using System;

namespace Sri_Lanka_Road_And_Traffic_Rules
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            try { 
            //create a thread 
            Thread trd = new Thread(new ThreadStart(formRun));
            trd.Start();
            Thread.Sleep(2000);
            InitializeComponent();
            //destroy
            trd.Abort();

            }
            catch (Exception)
            {

            }
        }

        //method for trd thread 
        private void formRun()
        {
            try { 
            //open the Welcome_form until the thread is runnig 
            Application.Run(new Welcome_Form());
            }

            catch (Exception)
            {

            }
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {
              
            //LOAD home page
            Form homeform = new Home();
            this.IsMdiContainer = true;
            homeform.TopLevel = false;
            panelShow.Controls.Clear();
            panelShow.Controls.Add(homeform);
            homeform.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            homeform.Dock = DockStyle.Fill;
            homeform.Show();
        }

        private void btnHome_Click(object sender, System.EventArgs e)
        {
            //Give same height to slide panel
            panelSlide.Height = btnHome.Height;
            panelSlide.Top = btnHome.Top;

            Form homeform = new Home();
            this.IsMdiContainer = true;
            homeform.TopLevel = false;
            panelShow.Controls.Clear();
            panelShow.Controls.Add(homeform);
            homeform.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            homeform.Dock = DockStyle.Fill;
            homeform.Show();

        }

        private void btnRules_Click(object sender, System.EventArgs e)
        {
            panelSlide.Height = btnRules.Height;
            panelSlide.Top = btnRules.Top;

            
            Form rulesform = new RulesForm();
            this.IsMdiContainer = true;
            rulesform.TopLevel = false;
            panelShow.Controls.Clear();
            panelShow.Controls.Add(rulesform);
            rulesform.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            rulesform.Dock = DockStyle.Fill;
            rulesform.Show();
            
            
        }

        private void btnAbout_Click(object sender, System.EventArgs e)
        {
            panelSlide.Height = btnAbout.Height;
            panelSlide.Top = btnAbout.Top;

           /*   Form addDetails = new AddDetailscs();
              this.IsMdiContainer = true;
              addDetails.TopLevel = false;
              panelShow.Controls.Clear();
              panelShow.Controls.Add(addDetails);
              addDetails.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
              addDetails.Dock = DockStyle.Fill;
              addDetails.Show();*/


             Form addDetails = new AboutUs();
            this.IsMdiContainer = true;
            addDetails.TopLevel = false;
            panelShow.Controls.Clear();
            panelShow.Controls.Add(addDetails);
            addDetails.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            addDetails.Dock = DockStyle.Fill;
            addDetails.Show();
            

        }

     

        private void button4_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
