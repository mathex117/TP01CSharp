using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP01
{
    interface ItemDeBiblioteca
    {
        bool getEmprestado { get; set; }
        String getLocalizacao { get; set; }
        void Empresta();
        void Devolve();
    }
}
