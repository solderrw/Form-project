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
    public partial class rezept : Form
    {
        public rezept()
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
                DataRow nRow = main.baseDataKebabDataSet3.Tables[0].NewRow();
                if (textBox1.Text != "")
                    if (textBox2.Text != "")
                    {
                        for (int i = 1; ; i++)
                        {
                            nRow[1] = textBox1.Text;
                            nRow[2] = textBox2.Text;
                            try
                            {
                                main.baseDataKebabDataSet3.Tables[0].Rows.Add(nRow);

                                i++;
                                break;
                            }
                            catch
                            {
                                textBox1.Text = i.ToString();
                                textBox2.Text = i.ToString();
                                continue;
                            }
                        }
                    }
            }
        }
    }
}
