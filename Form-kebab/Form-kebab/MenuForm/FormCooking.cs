using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Form_kebab.Cooking;
using Form_kebab.LoginForm;

namespace Form_kebab.MenuForm
{
    public partial class FormCooking : Form
    {
       
        
        public FormCooking()
        {
            InitializeComponent();
        }
        
        private void FormCooking_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "baseDataKebabDataSet2.Готовые_Блюда". При необходимости она может быть перемещена или удалена.
            this.готовые_БлюдаTableAdapter.Fill(this.baseDataKebabDataSet2.Готовые_Блюда);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "baseDataKebabDataSet3.Рецепт". При необходимости она может быть перемещена или удалена.
            this.рецептTableAdapter.Fill(this.baseDataKebabDataSet3.Рецепт);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "baseDataKebabDataSet1.Блюда". При необходимости она может быть перемещена или удалена.
            this.блюдаTableAdapter.Fill(this.baseDataKebabDataSet1.Блюда);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var cookingAdd = new CookingAdd();
            cookingAdd.Owner = this;
            cookingAdd.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            this.блюдаTableAdapter.Fill(baseDataKebabDataSet1);
            this.готовые_БлюдаTableAdapter.Fill(baseDataKebabDataSet2);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Удалить запись?", "Удаление", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (DialogResult.OK == dr)
            {

                var a = dataGridView1.SelectedCells[0].RowIndex;
                this.dataGridView1.Rows.RemoveAt(a);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var changeForm = new cookChangeForm();
            changeForm.Owner = this;
            changeForm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            DataRow nRow = this.baseDataKebabDataSet2.Tables[0].NewRow();
            string temp = this.dataGridView1.SelectedCells[0].Value.ToString();
            int rc = this.dataGridView1.SelectedCells[0].RowIndex;
            nRow[1] = temp;
            this.baseDataKebabDataSet2.Tables[0].Rows.Add(nRow);
            



        }

        private void button6_Click(object sender, EventArgs e)
        {
            var rezept = new rezept();
            rezept.Owner = this;
            rezept.Show();
        }

        
    }
}
