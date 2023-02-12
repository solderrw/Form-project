using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;
using FontAwesome.Sharp;
using Form_kebab.MenuForm;
using Color = System.Drawing.Color;

namespace Form_kebab.MenuForm
{
    public partial class FormMenuMen : Form
    {

        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentCjildForm;

        public FormMenuMen()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 39);
            PanelMenu.Controls.Add(leftBorderBtn);
        }
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 116);
            public static Color color4 = Color.FromArgb(96, 77, 228);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 164, 251);
        }

        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();

                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(105, 105, 105);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;


                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();

                iconCurrentoChildForm.IconChar = currentBtn.IconChar;
                iconCurrentoChildForm.IconColor = color;
            }
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(128, 128, 128);
                currentBtn.ForeColor = Color.White;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.White;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
            }
        }

        private void OpenCildFrom(Form childForm)
        {
            if (currentCjildForm != null)
            {
                currentCjildForm.Close();
            }
            currentCjildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            paneldd.Controls.Add(childForm);
            paneldd.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            

        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenCildFrom(new FormHome());
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            OpenCildFrom(new FormM());
        }

        private void BtnGot_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
            OpenCildFrom(new FormCooking());
        }

        private void BtnStol_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color4);
            OpenCildFrom(new FormStol());
        }

        

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            iconCurrentoChildForm.IconChar = IconChar.Home;
            iconCurrentoChildForm.IconColor = Color.MediumSeaGreen;
           
        }

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            
        }

        
    }

}
    
