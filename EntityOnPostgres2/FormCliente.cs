using System;
using System.Windows.Forms;
using Business;
using Entities.Models;

namespace EntityOnPostgres2
{
    public partial class FormCliente : ClientesIntermadiate
    {
        public FormCliente()
        {
            InitializeComponent();
            new DataProvider();
        }

        private void textBox1_TextChanged(object sender, System.EventArgs e)
        {
            using (var dataProvider = new DataProvider())
            {
               
            }
        }

    }
}
