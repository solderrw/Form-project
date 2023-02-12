using Form_kebab.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_kebab.MenuForm
{
    public partial class AdminAdd : Form
    {
      
        public AdminAdd()
        {
            InitializeComponent();
        }

        private void AdminAdd_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "baseDataKebabDataSet2.User". При необходимости она может быть перемещена или удалена.
            this.userTableAdapter2.Fill(this.baseDataKebabDataSet2.User);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "baseDataKebabDataSet1.User". При необходимости она может быть перемещена или удалена.
            this.userTableAdapter1.Fill(this.baseDataKebabDataSet1.User);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "baseDataKebabDataSet.User". При необходимости она может быть перемещена или удалена.
            this.userTableAdapter.Fill(this.baseDataKebabDataSet.User);
            




            Edit(false);
        }

        private void Edit(bool value)
        {
            txt_Name.Enabled = value;
            txt_Password.Enabled = value;
            textBox1.Enabled = value;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Edit(true);
               baseDataKebabDataSet.User.AddUserRow(baseDataKebabDataSet.User.NewUserRow());
               userBindingSource.MoveLast();
                txt_Name.Focus();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
               baseDataKebabDataSet.User.RejectChanges();
            }
            
                
            

                
            


        }

        private void button2_Click(object sender, EventArgs e)
        {
           userBindingSource.RemoveCurrent();
                
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Edit(true);
            txt_Name.Focus();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                Edit(false);
               userBindingSource.EndEdit();
               userTableAdapter.Update(baseDataKebabDataSet.User);
                dataGridView1.Refresh();
                txt_Name.Focus();

            }
            catch (Exception ex)
            {
               MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
               baseDataKebabDataSet.User.RejectChanges();
            }

        }
    }
}
