using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Form_kebab.BaseDataKebabDataSet1TableAdapters;
using Form_kebab.MenuForm;

namespace Form_kebab.Cooking
{
    public partial class CookingAdd : Form
    {
       
        public CookingAdd()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormCooking main = this.Owner as FormCooking;
            if (main != null)
            {
                
                DataRow nRow = main.baseDataKebabDataSet1.Tables[0].NewRow();
                if(textBox1.Text != "")
                    for (int i = 1; ; i++)
                    {
                        nRow[1] = textBox1.Text;
                        try
                        {
                            main.baseDataKebabDataSet1.Tables[0].Rows.Add(nRow);

                                i++;
                            break;
                            
                        }
                        catch
                        {
                            textBox1.Text += i.ToString();
                            continue;
                        }
                    }
            }
                
        }

        private void CookingAdd_Load(object sender, EventArgs e)
        {
           

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
