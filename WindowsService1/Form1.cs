using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsService1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void testeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.testeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.testeDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'testeDataSet.teste'. Você pode movê-la ou removê-la conforme necessário.
            this.testeTableAdapter.Fill(this.testeDataSet.teste);

        }
    }
}
