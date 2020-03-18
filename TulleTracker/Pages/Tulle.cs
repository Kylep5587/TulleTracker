using KPRestoration;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TulleTracker.Classes;

namespace TulleTracker.Pages
{
    public partial class Tulle : Form
    {
        public Tulle()
        {
            InitializeComponent();
        }

        private void nToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TulleOrder form = new TulleOrder();
            form.ShowDialog();
        }

        private void Tulle_Load(object sender, EventArgs e)
        {
            Order o = new Order();
            DatabaseHelper db = new DatabaseHelper();
            MySqlCommand getTotalsCMD = new MySqlCommand("SELECT COUNT(*) FROM TULLE_ORDERS", db.conn);
            MySqlCommand getPendingCMD = new MySqlCommand("SELECT COUNT(*) FROM TULLE_ORDERS WHERE orderStatus = 'Pending'", db.conn);
            MySqlCommand getShippedCMD = new MySqlCommand("SELECT COUNT(*) FROM TULLE_ORDERS WHERE orderStatus = 'Shipped'", db.conn);
            db.OpenConnection();
            totalOrders.Text = getTotalsCMD.ExecuteScalar().ToString();
            pendingOrders.Text = getPendingCMD.ExecuteScalar().ToString();
            shippedOrders.Text = getShippedCMD.ExecuteScalar().ToString();
            db.CloseConnection();

            foreach (var item in Enum.GetValues(typeof(Globals.TulleColors)))
            {

                string[] rollNumbers = new string[2];

                switch (item.ToString())
                {
                    case "LTPink":
                        ltPinkQty.Text = o.ExecuteColorSearch("LT Pink");
                        if (ltPinkQty.Text != "-")
                        {
                            rollNumbers = o.CalculateCases(Convert.ToInt32(ltPinkQty.Text));
                            ltPinkCases.Text = rollNumbers[0];
                            ltPinkNeeded.Text = rollNumbers[1];
                        }
                        break;
                    case "LTBlue":
                        ltBlueQty.Text = o.ExecuteColorSearch("LT Blue");
                        if (ltBlueQty.Text != "-")
                        {
                            rollNumbers = o.CalculateCases(Convert.ToInt32(ltBlueQty.Text));
                            ltBlueCases.Text = rollNumbers[0];
                            ltBlueNeeded.Text = rollNumbers[1];
                        }
                        break;
                    case "AppleGreen":
                        agQty.Text = o.ExecuteColorSearch("Apple Green");
                        if (agQty.Text != "-")
                        {
                            rollNumbers = o.CalculateCases(Convert.ToInt32(agQty.Text));
                            agCases.Text = rollNumbers[0];
                            agNeeded.Text = rollNumbers[1];
                        }
                        break;
                    case "NavyBlue":
                        nbQty.Text = o.ExecuteColorSearch("Navy Blue");
                        if (nbQty.Text != "-")
                        {
                            rollNumbers = o.CalculateCases(Convert.ToInt32(nbQty.Text));
                            navyCases.Text = rollNumbers[0];
                            navyNeeded.Text = rollNumbers[1];
                        }
                        break;
                    case "Black":
                        blackQty.Text = o.ExecuteColorSearch("Black");
                        if (blackQty.Text != "-")
                        {
                            rollNumbers = o.CalculateCases(Convert.ToInt32(blackQty.Text));
                            blackCases.Text = rollNumbers[0];
                            blackNeeded.Text = rollNumbers[1];
                        }
                        break;
                    case "Blue":
                        blueQty.Text = o.ExecuteColorSearch("Blue");
                        if (blueQty.Text != "-")
                        {
                            rollNumbers = o.CalculateCases(Convert.ToInt32(blueQty.Text));
                            blueCases.Text = rollNumbers[0];
                            blueNeeded.Text = rollNumbers[1];
                        }
                        break;
                    case "Burgundy":
                        burgundyQty.Text = o.ExecuteColorSearch("Burgundy");
                        if (burgundyQty.Text != "-")
                        {
                            rollNumbers = o.CalculateCases(Convert.ToInt32(burgundyQty.Text));
                            burgundCases.Text = rollNumbers[0];
                            burgundyNeeded.Text = rollNumbers[1];
                        }
                        break;
                    case "Fuchsia":
                        fuchsiaQty.Text = o.ExecuteColorSearch("Fuchsia");
                        if (fuchsiaQty.Text != "-")
                        {
                            rollNumbers = o.CalculateCases(Convert.ToInt32(fuchsiaQty.Text));
                            fuchsiaCases.Text = rollNumbers[0];
                            fuchsiaNeeded.Text = rollNumbers[1];
                        }
                        break;
                    case "Green":
                        greenQty.Text = o.ExecuteColorSearch("Green");
                        if (greenQty.Text != "-")
                        {
                            rollNumbers = o.CalculateCases(Convert.ToInt32(greenQty.Text));
                            greenCases.Text = rollNumbers[0];
                            greenNeeded.Text = rollNumbers[1];
                        }
                        break;
                    case "Ivory":
                        ivoryQty.Text = o.ExecuteColorSearch("Ivory");
                        if (ivoryQty.Text != "-")
                        {
                            rollNumbers = o.CalculateCases(Convert.ToInt32(ivoryQty.Text));
                            ivoryCases.Text = rollNumbers[0];
                            ivoryNeeded.Text = rollNumbers[1];
                        }
                        break;
                    case "Lavender":
                        lavenderQty.Text = o.ExecuteColorSearch("Lavender");
                        if (lavenderQty.Text != "-")
                        {
                            rollNumbers = o.CalculateCases(Convert.ToInt32(lavenderQty.Text));
                            lavenderCases.Text = rollNumbers[0];
                            lavenderNeeded.Text = rollNumbers[1];
                        }
                        break;
                    case "Orange":
                        orangeQty.Text = o.ExecuteColorSearch("Orange");
                        if (orangeQty.Text != "-")
                        {
                            rollNumbers = o.CalculateCases(Convert.ToInt32(orangeQty.Text));
                            orangeCases.Text = rollNumbers[0];
                            orangeNeeded.Text = rollNumbers[1];
                        }
                        break;
                    case "Pink":
                        pinkQty.Text = o.ExecuteColorSearch("Pink");
                        if (pinkQty.Text != "-")
                        {
                            rollNumbers = o.CalculateCases(Convert.ToInt32(pinkQty.Text));
                            pinkCases.Text = rollNumbers[0];
                            pinkNeeded.Text = rollNumbers[1];
                        }
                        break;
                    case "Purple":
                        purpleQty.Text = o.ExecuteColorSearch("Purple");
                        if (purpleQty.Text != "-")
                        {
                            rollNumbers = o.CalculateCases(Convert.ToInt32(purpleQty.Text));
                            purpleCases.Text = rollNumbers[0];
                            purpleNeeded.Text = rollNumbers[1];
                        }
                        break;
                    case "Red":
                        redQty.Text = o.ExecuteColorSearch("Red");
                        if (redQty.Text != "-")
                        {
                            rollNumbers = o.CalculateCases(Convert.ToInt32(redQty.Text));
                            redCases.Text = rollNumbers[0];
                            redNeeded.Text = rollNumbers[1];
                        }
                        break;
                    case "Silver":
                        silverQty.Text = o.ExecuteColorSearch("Silver");
                        if (silverQty.Text != "-")
                        {
                            rollNumbers = o.CalculateCases(Convert.ToInt32(silverQty.Text));
                            silverCases.Text = rollNumbers[0];
                            silverNeeded.Text = rollNumbers[1];
                        }
                        break;
                    case "Turquoise":
                        turquoiseQty.Text = o.ExecuteColorSearch("Turquoise");
                        if (turquoiseQty.Text != "-")
                        {
                            rollNumbers = o.CalculateCases(Convert.ToInt32(turquoiseQty.Text));
                            turquoiseQty.Text = rollNumbers[0];
                            turquoiseQty.Text = rollNumbers[1];
                        }
                        break;
                    case "White":
                        whiteQty.Text = o.ExecuteColorSearch("White");
                        if (whiteQty.Text != "-")
                        {
                            rollNumbers = o.CalculateCases(Convert.ToInt32(whiteQty.Text));
                            whiteCases.Text = rollNumbers[0];
                            whiteNeeded.Text = rollNumbers[1];
                        }
                        break;
                    case "Yellow":
                        yellowQty.Text = o.ExecuteColorSearch("Yellow");
                        if (yellowQty.Text != "-")
                        {
                            rollNumbers = o.CalculateCases(Convert.ToInt32(yellowQty.Text));
                            yellowCases.Text = rollNumbers[0];
                            yellowNeeded.Text = rollNumbers[1];
                        }
                        break;
                }

            }
            
        }
    }
}
