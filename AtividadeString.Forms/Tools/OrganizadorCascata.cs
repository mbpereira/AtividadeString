using System.Collections.Generic;
using System.Windows.Forms;
using AtividadeString.Contracts;
using System.Drawing;

namespace AtividadeString.Forms.Tools
{
    class OrganizadorCascata : IOrganizador
    {

        public void Organizar(ICollection<Form> janelas)
        {

            int Top = 0, Left = 0;
            foreach(Form janela in janelas)
            {
                
                if(!EstaNaAreaSegura(Top + janela.Height))
                {
                    Top = 0;
                    Left = 0;
                }
                
                janela.Top = Top;
                janela.Left = Left;

                Top += 30;
                Left += 15;

            }
        }

        private bool EstaNaAreaSegura(int posicaoJanela)
        {
            Rectangle areaDeTrabalho = SystemInformation.WorkingArea;
            Size size = areaDeTrabalho.Size;

            if (posicaoJanela > size.Height)
                return false;
            return true;
        }
    }
}
