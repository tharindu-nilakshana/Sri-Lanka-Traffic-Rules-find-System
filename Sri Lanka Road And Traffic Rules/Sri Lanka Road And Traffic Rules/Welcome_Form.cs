using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sri_Lanka_Road_And_Traffic_Rules
{
    public partial class Welcome_Form : Form
    {
        
        
        public Welcome_Form()
        {
            InitializeComponent();
            
        }

        private void timerPanel_Tick(object sender, EventArgs e)
        {

            panelSlide.Left -= 2;
            if(panelSlide.Left < 232)
            {
                timerPanel2.Enabled = true;
                timerPanel1.Enabled = false;
            }

        }

        private void Welcome_Form_Load(object sender, EventArgs e)
        {
            timerPanel1.Start();
        }

        private void timerPanel2_Tick(object sender, EventArgs e)
        {
            panelSlide.Left += 2;
            if(panelSlide.Left > 509)
            {
                timerPanel1.Enabled = true;
                timerPanel2.Enabled = false;
            }
        }
    }
}
