using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TagHunter.Models;
using TagHunter.Models.Metodo;

namespace TagHunter
{
    public partial class frmTagHunter : Form
    {
        public List<Cliente> listaAnterior { get; set; }
        public List<Cliente> listaAtual { get; set; }

        public frmTagHunter()
        {
            InitializeComponent();
        }



        private void btSalvar_Click(object sender, EventArgs e)
        {
            if (dgInformacoes.CurrentCell == null)
                MessageBox.Show("Por favor, selecionar o registro a ser salvo");
        }
        private void frmTagHunter_Load(object sender, EventArgs e)
        {
            Atualizar();
        }
        private void btAtualizar_Click(object sender, EventArgs e)
        {
            Atualizar();
        }
        private void Atualizar()
        {
            listaAnterior = new List<Cliente>();
            listaAtual = new List<Cliente>();
            listaAnterior.Clear();
            listaAtual.Clear();

            listaAnterior = Finder.Load();
            dgInformacoes.DataSource = Finder.Load();
            dgInformacoes.Columns[2].ReadOnly = false;
            dgInformacoes.Columns[3].ReadOnly = false;
            dgInformacoes.Columns[4].ReadOnly = false;
            dgInformacoes.Columns[5].ReadOnly = false;
            
        }
    }
}
