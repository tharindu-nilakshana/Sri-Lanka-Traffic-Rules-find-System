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
using System.Configuration;
using System.Speech.Recognition;
using System.IO;

namespace Sri_Lanka_Road_And_Traffic_Rules
{
    public partial class RulesForm : Form
    {
        //database connection 
        static string constr = ConfigurationManager.ConnectionStrings["dbx"].ConnectionString;
        SqlConnection con = new SqlConnection(constr);
        
        //recognize engine
        SpeechRecognitionEngine recognize = new SpeechRecognitionEngine();

        public RulesForm()
        {
            InitializeComponent();
            dataGridView1.DefaultCellStyle.ForeColor = Color.Black;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.RowTemplate.Height = 120;
        }

        private void RulesForm_Load(object sender, EventArgs e)
        {
            try { 
                //check database connection status 
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            else
            {
                con.Open();

            }


                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView1.RowTemplate.Height = 120;


                    SqlCommand cmd1 = con.CreateCommand();
                    cmd1.CommandType = CommandType.Text;
                    cmd1.CommandText = "select name,description,image from Missellaneous";
                    cmd1.ExecuteNonQuery();


                    SqlCommand cmd2 = con.CreateCommand();
                    cmd2.CommandType = CommandType.Text;
                    cmd2.CommandText = "select name,description,image from Danger_Warning";
                    cmd2.ExecuteNonQuery();

                    SqlCommand cmd3 = con.CreateCommand();
                    cmd3.CommandType = CommandType.Text;
                    cmd3.CommandText = "select name,description,image from Directional_Informative";
                    cmd3.ExecuteNonQuery();

                    SqlCommand cmd4 = con.CreateCommand();
                    cmd4.CommandType = CommandType.Text;
                    cmd4.CommandText = "select name,description,image from Regulotory";
                    cmd4.ExecuteNonQuery();

                    SqlCommand cmd5 = con.CreateCommand();
                    cmd5.CommandType = CommandType.Text;
                    cmd5.CommandText = "select name,description,image from Traffic_Control_Signal";
                    cmd5.ExecuteNonQuery();

                    SqlCommand cmd6 = con.CreateCommand();
                    cmd6.CommandType = CommandType.Text;
                    cmd6.CommandText = "select name,description,image from Traffic_Lights";
                    cmd6.ExecuteNonQuery();

                    DataTable dt = new DataTable();
                    

                    SqlDataAdapter c1 = new SqlDataAdapter(cmd1);
                    SqlDataAdapter c2 = new SqlDataAdapter(cmd2);
                    SqlDataAdapter c3 = new SqlDataAdapter(cmd3);
                    SqlDataAdapter c4 = new SqlDataAdapter(cmd4);
                    SqlDataAdapter c5 = new SqlDataAdapter(cmd5);
                    SqlDataAdapter c6 = new SqlDataAdapter(cmd6);
                              
                     c1.Fill(dt);
                     c2.Fill(dt);
                     c3.Fill(dt);
                     c4.Fill(dt);
                     c5.Fill(dt);
                     c6.Fill(dt);

                    dataGridView1.DataSource = dt;

                    dataGridView1.DefaultCellStyle.ForeColor = Color.Black;
                    DataGridViewImageColumn imagecolumn = new DataGridViewImageColumn();
                    imagecolumn = (DataGridViewImageColumn)dataGridView1.Columns[3];
                    imagecolumn.ImageLayout = DataGridViewImageCellLayout.Stretch;
                    dt.Dispose();
                            

            }
            catch (Exception)
            {

            }
        }

        private void recognizer_recognizer(object sender, SpeechRecognizedEventArgs e)
        {
            txtSearch.Text = e.Result.Text;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            //voice recognition
            
            recognize.SetInputToDefaultAudioDevice();
            GrammarBuilder gb = new GrammarBuilder("Left Bend Ahead,Right Bend Ahead,Double Bend to Left Ahead,Double Bend to Right Ahead," +
                "Hair Pin Bend to Right Ahead,Hair Pin Bend to Left Ahead,Dual Carriage-way Ends,Dual Carriage-way Starts Ahead," +
                "Road Narrows Ahead,Cross Roads Ahead,T Junction Ahead,Road closed for Articulated vehicles,Red Light,Red and Amber Lights," +
                "Green Light,Amber Light,Flashing Amber lights,Green Arrow,Traffic approaching from the front to STOP," +
                "All traffic to STOP,Traffic from the right to proceed,Turn right,Slow down or stop,Turn left,Turn right,Turn left");
            Grammar g = new Grammar(gb);
            recognize.LoadGrammar(g);

            //recognize.LoadGrammar(new DictationGrammar());
            recognize.RecognizeAsync(RecognizeMode.Multiple);
            recognize.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(recognizer_recognizer);

            pictureBox1.BackColor = Color.Purple;
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            recognize.RecognizeAsyncStop();
            //reset back color to default
            pictureBox1.BackColor = Color.FromArgb(35, 29, 36);

        }



        private void rdoRegulatoty_CheckedChanged(object sender, EventArgs e)
        {
            SqlCommand cmd1 = con.CreateCommand();
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "select name,description,image from Regulotory";
            cmd1.ExecuteNonQuery();

            DataTable dt = new DataTable();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.RowTemplate.Height = 120;

            SqlDataAdapter da = new SqlDataAdapter(cmd1);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void rdoTrafficControlSignal_CheckedChanged(object sender, EventArgs e)
        {
            SqlCommand cmd1 = con.CreateCommand();
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "select name,description,image from Traffic_Control_Signal";
            cmd1.ExecuteNonQuery();

            DataTable dt = new DataTable();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.RowTemplate.Height = 120;

            SqlDataAdapter da = new SqlDataAdapter(cmd1);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            SqlCommand cmd1 = con.CreateCommand();
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "select name,description,image from Danger_Warning WHERE description LIKE '%" + txtSearch.Text.ToString() + "%'";
            cmd1.ExecuteNonQuery();

            SqlCommand cmd2 = con.CreateCommand();
            cmd2.CommandType = CommandType.Text;
            cmd2.CommandText = "select name,description,image from Directional_Informative WHERE description LIKE '%" + txtSearch.Text.ToString() + "%'";
            cmd2.ExecuteNonQuery();

            SqlCommand cmd3 = con.CreateCommand();
            cmd3.CommandType = CommandType.Text;
            cmd3.CommandText = "select name,description,image from Missellaneous WHERE description LIKE '%" + txtSearch.Text.ToString() + "%'";
            cmd3.ExecuteNonQuery();

            SqlCommand cmd4 = con.CreateCommand();
            cmd4.CommandType = CommandType.Text;
            cmd4.CommandText = "select name,description,image from Regulotory WHERE description LIKE '%" + txtSearch.Text.ToString() + "%'";
            cmd4.ExecuteNonQuery();

            SqlCommand cmd5 = con.CreateCommand();
            cmd5.CommandType = CommandType.Text;
            cmd5.CommandText = "select name,description,image from Traffic_Control_Signal WHERE description LIKE '%" + txtSearch.Text.ToString() + "%'";
            cmd5.ExecuteNonQuery();

            SqlCommand cmd6 = con.CreateCommand();
            cmd6.CommandType = CommandType.Text;
            cmd6.CommandText = "select name,description,image from Traffic_Lights WHERE description LIKE '%" + txtSearch.Text.ToString() + "%'";
            cmd6.ExecuteNonQuery();

            DataTable dt = new DataTable();

            SqlDataAdapter c1 = new SqlDataAdapter(cmd1);
            SqlDataAdapter c2 = new SqlDataAdapter(cmd2);
            SqlDataAdapter c3 = new SqlDataAdapter(cmd3);
            SqlDataAdapter c4 = new SqlDataAdapter(cmd4);
            SqlDataAdapter c5 = new SqlDataAdapter(cmd5);
            SqlDataAdapter c6 = new SqlDataAdapter(cmd6);

            c1.Fill(dt);
            c2.Fill(dt);
            c3.Fill(dt);
            c4.Fill(dt);
            c5.Fill(dt);
            c6.Fill(dt);

            dataGridView1.DataSource = dt;
        }

        private void rdoDangerWarning_CheckedChanged(object sender, EventArgs e)
        {
            SqlCommand cmd1 = con.CreateCommand();
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "select name,description,image from Danger_Warning";
            cmd1.ExecuteNonQuery();

            DataTable dt = new DataTable();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.RowTemplate.Height = 120;

            SqlDataAdapter da = new SqlDataAdapter(cmd1);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void rdoDirectional_CheckedChanged(object sender, EventArgs e)
        {
            SqlCommand cmd1 = con.CreateCommand();
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "select name,description,image from Directional_Informative";
            cmd1.ExecuteNonQuery();

            DataTable dt = new DataTable();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.RowTemplate.Height = 120;

            SqlDataAdapter da = new SqlDataAdapter(cmd1);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void rdoMissellaneous_CheckedChanged(object sender, EventArgs e)
        {
            SqlCommand cmd1 = con.CreateCommand();
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "select name,description,image from Missellaneous";
            cmd1.ExecuteNonQuery();

            DataTable dt = new DataTable();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.RowTemplate.Height = 120;

            SqlDataAdapter da = new SqlDataAdapter(cmd1);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void rdoTrafficLights_CheckedChanged(object sender, EventArgs e)
        {
            SqlCommand cmd1 = con.CreateCommand();
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "select name,description,image from Traffic_Lights";
            cmd1.ExecuteNonQuery();

            DataTable dt = new DataTable();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.RowTemplate.Height = 120;

            SqlDataAdapter da = new SqlDataAdapter(cmd1);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
