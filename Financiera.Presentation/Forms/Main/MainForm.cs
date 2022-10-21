using Financiera.Presentation.Forms.UsControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Financiera.Presentation.Forms.Main
{
    public partial class MainForm : Form
    {
        UsClients usClients = new UsClients();
        UsCounts usAcounts = new UsCounts();
        public MainForm()
        {
            InitializeComponent();
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("¿Seguro que desea salir?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            } 
            
        }

        private void btMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelActions_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void MainForm_Paint(object sender, PaintEventArgs e)
        {
           // Graphics g = e.Graphics;
           // Rectangle area = new Rectangle(0, 0, this.Width, this.Height);
           // LinearGradientBrush lgb = new LinearGradientBrush
           //(area, (Color.FromArgb(210, 230, 216), Color.FromArgb(207, 231, 219), Color.FromArgb(205, 231, 221), Color.FromArgb(204, 231, 224), Color.FromArgb(202, 231, 227), Color.FromArgb(201, 231, 229), Color.FromArgb(201, 231, 232), Color.FromArgb(201, 231, 234)
           //, Color.FromArgb(201, 231, 237), Color.FromArgb(202, 230, 239), Color.FromArgb(203, 230, 240), Color.FromArgb(205, 229, 242)).Item1,

           //    (Color.FromArgb(207, 228, 243), Color.FromArgb(210, 228, 244), Color.FromArgb(212, 227, 245), Color.FromArgb(215, 226, 245), Color.FromArgb(218, 225, 245), Color.FromArgb(221, 224, 244), Color.FromArgb(225, 223, 243)
           //    , Color.FromArgb(228, 223, 242), Color.FromArgb(231, 222, 241), Color.FromArgb(234, 221, 239), Color.FromArgb(237, 220, 237)).Item2, LinearGradientMode.BackwardDiagonal);
           // g.FillRectangle(lgb, area);

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
           
            usClients.Width = 0;          
            usAcounts.Width = 0;
           
        }

        private void timerOpen_Tick(object sender, EventArgs e)
        {
            
            if(usClients.Width <= panelMain.Width-1)
            {
                usClients.Width += 50;
               
            }
            else
            {
                timerOpen.Stop();
            }
        }

        private void rjCircularPictureBox1_Click(object sender, EventArgs e)
        {
            var ls = panelMain.Controls.Contains(usAcounts);
            if (ls == true)
            {
                panelMain.Controls.Remove(usAcounts);
                timerOpen.Start();
            }
           
           
        }

        private void panelOptions_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelOptions_MouseEnter(object sender, EventArgs e)
        {
           //timerPanelOptions.Start();

        }

       

        private void panelOptions_MouseLeave(object sender, EventArgs e)
        {

            panelOptions.Width = 82;
            
        }

        #region CLoseAnimation
        private void lbClients_MouseEnter(object sender, EventArgs e)
        {
            //panelOptions.Width = 202;
        }

        private void lbCounts_MouseEnter(object sender, EventArgs e)
        {
            //panelOptions.Width = 202;
        }

        private void lbCards_MouseEnter(object sender, EventArgs e)
        {
            //panelOptions.Width = 202;
        }

        private void pboxClients_MouseEnter(object sender, EventArgs e)
        {
            //panelOptions.Width = 202;
        }

        private void pbCounts_MouseEnter(object sender, EventArgs e)
        {
            //panelOptions.Width = 202;
        }

        private void pbCards_MouseEnter(object sender, EventArgs e)
        {
            //panelOptions.Width = 202;
        }

        private void label4_MouseEnter(object sender, EventArgs e)
        {
            //panelOptions.Width = 202;
        }

        private void pbLogout_MouseEnter(object sender, EventArgs e)
        {
            //panelOptions.Width = 202;
        }
        #endregion

        private void timerMenuClose_Tick(object sender, EventArgs e)
        {
           
        }

        private void pbCounts_Click(object sender, EventArgs e)
        {
            OnClick(sender, e);
           
           
        }

        private void timerOpenUsCounts_Tick(object sender, EventArgs e)
        {
            if (usAcounts.Width <= panelMain.Width - 1)
            {
                usAcounts.Width += 50;

            }
            else
            {
                timerOpenUsCounts.Stop();
            }
        }

        private void OnClick(object sender, EventArgs e)
        {
            var bt = (PictureBox)sender;

            switch (bt.Name)
            {
                case "pboxClients":                  
                    this.panelMain.Controls.Clear();
                    this.panelMain.Controls.Add(usClients);
                    usClients.Width = 0;
                    timerOpen.Start();
                    break;

                case "pboxCounts":
                    this.panelMain.Controls.Clear();                 
                    this.panelMain.Controls.Add(usAcounts);
                    usAcounts.Width = 0;
                    timerOpenUsCounts.Start();
                    break;
                case "pboxCards":

                    break;
            }
        }

        private void pboxClients_Click(object sender, EventArgs e)
        {
            OnClick(sender, e);
        }
    }
}
