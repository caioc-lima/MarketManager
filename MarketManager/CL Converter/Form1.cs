using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlServerCe;
using System.Runtime.InteropServices;
using System.IO;
using System.Threading;

namespace MarketManager
{
    public partial class Form1 : Form
    {
        String SN = "";

        private static SqlCeConnection con = new SqlCeConnection(@"Data Source=.\data\data.sdf");

        public Form1()
        {
            InitializeComponent();            
        }

        //private static SqlCeConnection CON_MARKET = new SqlCeConnection(@".\DB\data.sdf");

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void BTN_SLIDE_Click(object sender, EventArgs e)
        {
            if (MENU_VERTICAL.Width == 250)
            {
                MENU_VERTICAL.Width = 55;
                PICTURE_LOGO.Image = Properties.Resources.logo_market;
                PICTURE_LOGO.SizeMode = PictureBoxSizeMode.Normal;
            }
            else
            {
                PICTURE_LOGO.Image = Properties.Resources.logo_market;
                PICTURE_LOGO.SizeMode = PictureBoxSizeMode.Zoom;
                MENU_VERTICAL.Width = 250;
            }
        }

        private void ICON_CLOSE_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ICON_MAXIMIZED_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            ICON_RESTORE.Visible = true;
            ICON_MAXIMIZED.Visible = false;
        }

        private void ICON_RESTORE_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            ICON_MAXIMIZED.Visible = true;
            ICON_RESTORE.Visible = false;

        }

        private void ICON_MINIMIZED_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void MENU_SUPERIOR_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle,0x112,0xf012,0);
        }

        public void OpenFormPanel(object FormFilho)
        {
            if (this.PANEL_CONTENT.Controls.Count > 0)
                    this.PANEL_CONTENT.Controls.RemoveAt(0);
                    Form ff = FormFilho as Form;
                    ff.TopLevel = false;
                    ff.Dock = DockStyle.Fill;
                    this.PANEL_CONTENT.Controls.Add(ff);
                    this.PANEL_CONTENT.Tag = ff;
                    ff.Show();                        
        }

        private void BTN_PRODUCTS_Click(object sender, EventArgs e)
        {
            OpenFormPanel(new Produtos());
        }

        private void PANEL_CONTENT_Paint(object sender, PaintEventArgs e)
        {

        }
        
        private void BTN_CLIENTES_Click(object sender, EventArgs e)
        {
            OpenFormPanel(new Clientes());
        }

        private void BTN_HOME_Click(object sender, EventArgs e)
        {
            OpenFormPanel(new HOME());
        }

        private void BTN_RELATORIO_Click(object sender, EventArgs e)
        {
            OpenFormPanel(new RELATORIO());
        }

        private void BTN_VENDAS_Click(object sender, EventArgs e)
        {
            OpenFormPanel(new VENDAS());
        }

        private void BTN_FORNECEDORES_Click(object sender, EventArgs e)
        {
            OpenFormPanel(new PROVEDORES());
        }

        private void BTN_COMPRAS_Click(object sender, EventArgs e)
        {
            OpenFormPanel(new COMPRAS());

        }
    }
    
}
