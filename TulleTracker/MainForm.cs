/*********************************************************
 * KP Restoration VMS                                    *
 * Created 12/12/18 by Kyle Price                        *
 * MainForm.cs - main application form. All other forms  *
 *  open as child forms in the content panel of this form*
 * ******************************************************/

using System;
using System.Windows.Forms;
using TulleTracker.Pages;

namespace KPRestoration
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        

        // Fixes: application remains running after closing window
        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }


        private void btnProducts_Click(object sender, EventArgs e)
        {
            ProductsForm p = new ProductsForm();
            Globals.CreateForm(p, panelContent);
            Text = "Product Manager";
        }

        private void btnTulleOrders_Click(object sender, EventArgs e)
        {
            Tulle t = new Tulle();
            Globals.CreateForm(t, panelContent);
            Text = "Tulle Orders";
        }
    }
}
