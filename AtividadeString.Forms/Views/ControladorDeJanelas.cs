using System;
using System.Collections.Generic;
using System.Windows.Forms;
using AtividadeString.Core.Contracts;
using AtividadeString.Core.Enums;
using AtividadeString.Forms.Factory;
using AtividadeString.Core.Tools.Text;
using AtividadeString.Forms.Tools;
using MatrixCalculator.Core.Models;
using MatrixCalculator.Core;

namespace AtividadeString.Views
{
    public partial class ControladorDeJanelas : Form, IPrincipal
    {
        // alterar interface de IPrincipal para INotificador
        // INotificador.notificar deverá receber dois parâmetros: TipoNotificacao, Mensagem

        private string _cached;
        private IList<Form> _janelas;
        private FabricaOrganizador _fabrica;

        public ControladorDeJanelas() : this(new List<Form>(), FabricaOrganizador.CriarFabrica())
        {
        }

        public ControladorDeJanelas(IList<Form> janelas, FabricaOrganizador fabrica)
        {
            _cached = "";
            _janelas = janelas;
            _fabrica = fabrica;
            InitializeComponent();
        }

        private void botaoSair_Click(object sender, EventArgs e) => Close();

        private void botaoCarregarJanelas_Click(object sender, EventArgs e)
        {
            if (limparJanelas.Checked)
            {
                _cached = ""; 
                limparJanelas.Checked = false;
                LimparJanelas();
            }
            CriarJanelas();
            InicializarJanelas();
            AtualizarQuantidade();
            Transmitir(_cached);
        }
        public void JanelaClosing(object sender, System.Windows.Forms.FormClosingEventArgs e) => FecharJanela((Form)sender);



        public void Organizar(DisposicaoDeJanelas tipo)
        {
            IOrganizador organizador = _fabrica.CriarOrganizador(tipo);
            organizador.Organizar(_janelas);
        }

        private void CriarJanelas()
        {
            Matrix pin = new Matrix(2, 2, new double[,] { { 1, 2 }, { 3, 4 } });
            Core.Tools.Complementary.Criptografador crip = new Core.Tools.Complementary.Criptografador(pin);
            
            RemovedorDeDuplicidades removedor = new RemovedorDeDuplicidades();
            
            _janelas.Add(new FerramentaDeTexto("Inversor de Texto", this, new InversorDeTexto()));
            _janelas.Add(new FerramentaDeTexto("Removedor de duplicidades", this, removedor));
            _janelas.Add(new FerramentaDeTexto("Ordenador de Caracteres Unicos", this, new OrdenadorDeCaracteresUnicos(removedor)));
            _janelas.Add(new FerramentaDeTexto("Caseador de Texto", this, new TrocadorDeCase()));
            _janelas.Add(new FerramentaDeTexto("Criptografador de Texto", this, new Criptografador(crip)));
            _janelas.Add(new FerramentaDeTexto("Descriptografador de Texto", this, new Descriptografador(crip)));
        }

        private void LimparJanelas()
        {
            while(_janelas.Count > 0)
            {
                Form janela = _janelas[0];
                janela.Close();
            }
        }

        private void InicializarJanelas()
        {
            foreach (Form form in _janelas)
            {
                form.FormClosing += JanelaClosing;

                form.Show();
            }
        }

        
        public void FecharJanela(Form janela)
        {
            _janelas.Remove(janela);
            AtualizarQuantidade();
        }

        private void AtualizarQuantidade () => quantidadeDeJanelas.Text = _janelas.Count.ToString();
        

        public void Transmitir(string message)
        {
            _cached = message;

            foreach(INotificavel janela in _janelas)
            {
                janela.Notificar(message);
            }
        }


    }
}
