using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ClientesCLT.Forms
{
    public partial class CLTForm : Form
    {
        public CLTForm()
        {
            InitializeComponent();
        }

        private void CLTinsideForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void menuGameleira_Click(object sender, EventArgs e)
        {
            ClientesForm gameleiraForm = new ClientesForm();

            gameleiraForm.Show();
        }
    }
}
