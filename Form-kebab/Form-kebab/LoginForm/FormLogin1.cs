using FontAwesome.Sharp;
using Form_kebab.MenuForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_kebab.LoginForm
{
    public partial class FormLogin1 : Form
    {
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\Form-kebab\\Form-kebab\\BaseDataKebab.mdf;Integrated Security=True");
        public FormLogin1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from [dbo].[User] inner join role on[dbo].[User].userrole = role.roletype where Name = @User  and Password = @Password", con);
                cmd.Parameters.AddWithValue("@User", textBox1.Text);
                cmd.Parameters.AddWithValue("@Password", textBox2.Text);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    string usertype = dt.Rows[0][5].ToString();

                    if (usertype == "Admin")
                    {
                        FormMenu mainMenu = new FormMenu();
                        MessageBox.Show("Добро пожаловать админ!");
                        mainMenu.Show();

                        this.Hide();
                    }
                    else if (usertype == "kebab")
                    {
                        FormMenuMen mainMenu = new FormMenuMen();
                        MessageBox.Show("Добро пожаловать Шашлычник!");
                        mainMenu.Show();

                        this.Hide();
                    }

                    else
                    {

                    }
                    con.Close();
                }

            }


        }
    }
}
