using Financiera.Commons.Processes;
using Financiera.Domain.Entities;
using System;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace Financiera.Presentation.Forms.Login
{
    public partial class LoginForm : Form
    {
        protected Connection connection = new Connection();
        public static Thread? threadMain;
        public LoginForm()
        {
            InitializeComponent();

        }
        #region Methods

        void IncreaseOpacity(object sender, EventArgs e)
        {
            if (this.Opacity <= 1)  //replace 0.88 with whatever you want
            {
                this.Opacity += 0.01;  //replace 0.01 with whatever you want
            }
            if (this.Opacity == 1) //replace 0.88 with whatever you want
                timerLogin.Stop();
        }
        #endregion

        private void btClose_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void LoginForm_Load(object sender, EventArgs e)
        {
            this.Opacity = .01;
            timerLogin.Interval = 2; //replace 10 with whatever you want
            timerLogin.Tick += IncreaseOpacity;
            timerLogin.Start();//timer1.Start();


        }

        private void LoginForm_Paint_1(object sender, PaintEventArgs e)
        {

            Graphics g = e.Graphics;
            Rectangle area = new Rectangle(0, 0, this.Width, this.Height);
            LinearGradientBrush lgb = new LinearGradientBrush
           (area, (Color.FromArgb(139, 162, 255), Color.FromArgb(255, 89, 192), Color.FromArgb(255, 78, 205), Color.FromArgb(255, 69, 217), Color.FromArgb(255, 63, 230)).Item1,

               (Color.FromArgb(242, 60, 242), Color.FromArgb(211, 63, 254), Color.FromArgb(173, 70, 255), Color.FromArgb(123, 79, 255), Color.FromArgb(0, 88, 255), Color.FromArgb(0, 96, 255)).Item2, LinearGradientMode.BackwardDiagonal);
            g.FillRectangle(lgb, area);



        }

        private void btMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void LoginForm_ResizeBegin(object sender, EventArgs e)
        {
            this.Opacity = 0.5;
        }

        private void LoginForm_ResizeEnd(object sender, EventArgs e)
        {
            this.Opacity = 1.00;
        }

        private void btLogin_Click_1(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(btLogin.Text) && !string.IsNullOrEmpty(txtUser.Texts) && !string.IsNullOrEmpty(txtPassword.Texts))
            {
                string dni = txtDni.Texts, login = txtUser.Texts, password = txtPassword.Texts;

                connection.Connect(dni, password, login);

                if (Connection.State == ConnectionState.Open)
                {
                    MessageBox.Show("Conectado","Estado de conexión",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    this.Close();
                    this.Dispose();
                    return;
                }
                if (Connection.State == ConnectionState.Closed || Connection.StatusRol == false)
                {
                    if (Domain.ContextDB.Message.SqlException)
                    {
                        MessageBox.Show($"{Domain.ContextDB.Message.Exception}", "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show(Domain.ContextDB.Message.Error,"Credenciales",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                    }

                }
            }
            else
            {
                MessageBox.Show("Asegurese de llenar los campos", "Campos vacios", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
