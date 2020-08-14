using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientDB
{
    public partial class Form1 : Form
    {
        private ClientDB CDB;
        public Form1()
        {
            InitializeComponent();
            CDB = new ClientDB("Do NothingPty Ltd");
        }

        private void AddClientButton_Click(Object sender, EventArgs e)
        {
            if (!CDB.AddClient(ClientNameTextBox.Text))
            {
                MessageBox.Show("Cannot add this client!");
            }
        }

        private void RemoveClientButton_Click(object sender, EventArgs e)
        {
            if (!CDB.RemoveClient(ClientNameTextBox.Text))
            {
                MessageBox.Show("Cannot remove this client!");
            }
        }

        private void IsAClientButton_Click(object sender, EventArgs e)
        {
            if (CDB.IsAClient(ClientNameTextBox.Text))
            {
                MessageBox.Show("Our client!");
            }
            else
            {
                MessageBox.Show("Not our client!");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ClientDB_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
