using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP01
{
    class LivroDeBiblioteca : Livro, ItemDeBiblioteca
    {
        private bool emprestado = false;
        private String localizacao;

        public LivroDeBiblioteca(String titulo, String autor, String editora, short anoEdicao, String localizacao) : base(titulo, autor, editora, anoEdicao)
        {
            this.titulo = titulo;
            this.autor = autor;
            this.editora = editora;
            this.anoEdicao = anoEdicao;
            this.localizacao = localizacao;
        }

        public bool getEmprestado
        {
            get { return emprestado; }
            set { emprestado = value; }
        }

        public string getLocalizacao
        {
            get { return localizacao; }
            set { localizacao = value; }
        }

        public void Devolve() { emprestado = false; }
        public void Empresta() { emprestado = true; }
        public override String getDados() { return base.getDados()+ "Localização: " + localizacao+"\n"; }
    }
}
