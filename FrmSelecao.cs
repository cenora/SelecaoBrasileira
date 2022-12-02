using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SelecaoBrasileira
{
    public partial class FrmSelecao : Form
    {
        List<String> titular;
        List<String> reserva;
        public FrmSelecao()
        {
            InitializeComponent();
            titular = new List<String>();
            reserva = new List<String>();
        }

        private void btnConvocar_Click(object sender, EventArgs e)
        {
            reserva.Add(txtJogador.Text);
            AtualizarQtd();
            lstReserva.DataSource = null; //Reseta o ListBox
            lstReserva.DataSource = reserva;
            lstReserva.Refresh();
            txtJogador.Text = ""; //Limpa o campo
            txtJogador.Focus(); //Faz o campo receber o foco
        }

        private void AtualizarQtd()
        {
            lblQtdReserva.Text = "Qtd. Jogadores: " + reserva.Count.ToString();
            lblQtdTitular.Text = "Qtd. Jogadores: " + titular.Count.ToString();
        }

        private void lstReserva_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int selecionado = lstReserva.SelectedIndex;
            titular.Add(reserva[selecionado]);
            lstTitular.DataSource = null;
            lstTitular.DataSource = titular;
            lstTitular.Refresh();
            reserva.RemoveAt(selecionado);
            lstReserva.DataSource = null; //Reseta o ListBox
            lstReserva.DataSource = reserva;
            lstReserva.Refresh();
            AtualizarQtd();
        }
    }
}
