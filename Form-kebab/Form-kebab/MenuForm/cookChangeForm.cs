using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_kebab.MenuForm
{
    public partial class cookChangeForm : Form
    {
        public cookChangeForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormCooking main = this.Owner as FormCooking;
            if (main != null)
            {
                int temp = main.dataGridView1.SelectedCells[0].RowIndex;
            DataRow nRow = main.baseDataKebabDataSet1.Tables[0].NewRow();
            int rc = main.dataGridView1.RowCount + 1;
            main.baseDataKebabDataSet1.Tables[0].Rows[temp][1] = textBox1.Text;

            nRow[0] = rc;
            nRow[1] = textBox1.Text;

            main.блюдаTableAdapter.Update(main.baseDataKebabDataSet1.Блюда);
            main.baseDataKebabDataSet1.Tables[0].AcceptChanges();
            main.dataGridView1.Refresh();
            textBox1.Text = "";

            Close();
            }
            else
            {
                MessageBox.Show("Заполните все строки!");
            }
        }
         
        
    }
}
