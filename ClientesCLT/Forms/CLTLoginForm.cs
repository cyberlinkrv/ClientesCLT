using ClientesCLT.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientesCLT
{
    public partial class CLTLoginForm : Form
    {
        public CLTLoginForm()
        {
            InitializeComponent();
        }

        private async void CLTLogin_Load(object sender, EventArgs e)
        {

            await Task.Delay(5000); //Espera 5 segundos
           // Close(); // flecha o formulario
            this.Hide(); //Oculta o formulario

            var logs = new CLTForm(); //stancia o novo formulario
            logs.Show(); //Carrega o nosso novo formulario.
        }
    }
}
