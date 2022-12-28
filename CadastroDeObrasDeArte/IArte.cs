using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroDeObrasDeArte
{
    public interface IArte
    {
        string _Nome { get; set; }
        string Descricao { get; set; }

        void Exibir();
    }
}
