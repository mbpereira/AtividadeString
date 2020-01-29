using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Contracts;

namespace WindowsFormsApp1.Views
{
    public partial class FerramentaDeTexto : Form, INotificavel
    {
        private IFerramentaDeTexto _processador;
        public FerramentaDeTexto(string nomeFerramenta, Form owner, IFerramentaDeTexto processador)
        {
            InitializeComponent();
            ferramenta.Text = nomeFerramenta;
            Owner = owner;
            _processador = processador;
            CentralizarLabel(textoSincronizado);
            CentralizarLabel(ferramenta);
        }

        private void texto_TextChanged(object sender, EventArgs e)
        {
            IPrincipal notificador = (IPrincipal) Owner;
            notificador.Transmitir(texto.Text);
        }

        public void Notificar(string message)
        {
            texto.Text = message;
            textoSincronizado.Text = _processador.Processar(message);
            CentralizarLabel(textoSincronizado);
        }

        private void CentralizarLabel(Label label)
        {
            label.Left = (Width - label.Width) / 2;
        }

        private void botalLadoALado_Click(object sender, EventArgs e)
        {
            Organizar(Enums.DisposicaoDeJanelas.LadoALado);
        }

        private void botaoCascata_Click(object sender, EventArgs e)
        {
            Organizar(Enums.DisposicaoDeJanelas.Cascata);
        }

        private void Organizar(Enums.DisposicaoDeJanelas tipoOrganizacao)
        {
            IPrincipal organizador = (IPrincipal)Owner;
            organizador.Organizar(tipoOrganizacao);
        }
    }
}
