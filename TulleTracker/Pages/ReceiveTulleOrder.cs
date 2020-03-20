using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using TulleTracker.Classes;

namespace TulleTracker.Pages
{
    public partial class ReceiveTulleOrder : Form
    {
        Order o = new Order();
        Tulle owner;

        public ReceiveTulleOrder(Tulle formOwner)
        {
            InitializeComponent();
            owner = formOwner;
            SerialPort mySerialPort = new SerialPort("COM1");

            mySerialPort.BaudRate = 9600;
            mySerialPort.Parity = Parity.None;
            mySerialPort.StopBits = StopBits.One;
            mySerialPort.DataBits = 8;
            mySerialPort.Handshake = Handshake.None;
            mySerialPort.RtsEnable = true;

            try {
                mySerialPort.Open();
            }
            catch (Exception)
            {
                MessageBox.Show("Receiving window already open.");
                this.Close();
            }
        }

        private void orderNumber_TextChanged(object sender, EventArgs e)
        {
            if (orderNumber.Text.Length >=5)
            {
                if (o.ReceiveShipment(orderNumber.Text.ToString()))
                {
                    tbScannedOrders.Text += orderNumber.Text + " - Received\n";
                    orderNumber.Text = "";
                }
                else
                {
                    tbScannedOrders.Text += orderNumber.Text + " - Not Received: Order Not Found\n";
                    orderNumber.Text = "";
                }
            }
        }


        /* Refreshes the DGV as form closes
        **********************************/
        private void ReceiveTulleOrder_FormClosing(object sender, FormClosingEventArgs e)
        {
            owner.RefreshOrderDGV();
        }
    }
}
