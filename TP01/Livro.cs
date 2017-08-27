using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP01
{
    class Livro
    {
        public String titulo { get; set; }
        public String autor { get; set; }
        public String editora { get; set; }
        public short anoEdicao { get; set; }

        public Livro(String titulo, String autor, String editora, short anoEdicao)
        {
            this.titulo = titulo;
            this.autor = autor;
            this.editora = editora;
            this.anoEdicao = anoEdicao;
        }

        public virtual String getDados()
        {
            return "Título: "+titulo + "\n" +"Autor: "+ autor + "\n" + "Editora: " +editora + "\n" + "Edição: " +anoEdicao + " \n";
        }
    }


    enum multas { diasEmprestimo = 7, acrescimoDeValor = 5, valorMulta = 1 };
}
