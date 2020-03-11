using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace Sri_Lanka_Road_And_Traffic_Rules
{

    public partial class AddDetailscs : Form
    {
        string ipath;

        static string constr = ConfigurationManager.ConnectionStrings["dbx"].ConnectionString;
        SqlConnection con = new SqlConnection(constr);
        String filename;
        

        public AddDetailscs()
        {
            InitializeComponent();
            
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            //open image 

            OpenFileDialog selectPicture = new OpenFileDialog();
            selectPicture.Filter = "JPG Files(*.jpg)|*.jpg|PNG Files(*.png)|*.png|All Files(*.*)|*.*";
            if (selectPicture.ShowDialog() == DialogResult.OK)
            {
                string scancopy = selectPicture.FileName.ToString();
                ipath = scancopy;
                pictureBox1.ImageLocation = scancopy;
            }

            /*  using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "JPEG|*.jpg", ValidateNames = true, Multiselect = false }) {
                  if (ofd.ShowDialog() == DialogResult.OK) {
                      filename = ofd.FileName;
                      lblFileName.Text = filename;
                      pictureBox1.Image = Image.FromFile(filename);
                  }


              }*/
        }
        //convert image to byte code as using byte array
     /*   byte[] convertToBinary(Image img)
        {
            using(MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                return ms.ToArray();
            }
        }*/

        private void btnSave_Click(object sender, EventArgs e)
        {
            try {

                //convert image to byte but using an string
                byte[] imgbyte = null;
                FileStream flstrm = new FileStream(this.ipath, FileMode.Open, FileAccess.Read);
                BinaryReader breader = new BinaryReader(flstrm);
                imgbyte = breader.ReadBytes((int)flstrm.Length);

                SqlCommand cmd1 = con.CreateCommand();
                cmd1.CommandType = CommandType.Text;
                cmd1.CommandText = "insert into Traffic_Control_Signal (name,description,image) values ('" + txtName.Text + "', '"+txtDes.Text+"',@img)";
                cmd1.Parameters.Add("@img", imgbyte);
                con.Open();
                cmd1.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Added");

                txtName.Clear();
                txtDes.Clear();
                txtName.Focus();
               
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void AddDetailscs_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
