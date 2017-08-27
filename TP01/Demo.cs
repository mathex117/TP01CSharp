using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP01
{
    class Demo
    {
        static void Main(string[] args)
        {
            //instancia um novo objeto
            LivroDeBiblioteca l1 = new LivroDeBiblioteca("Introdução à POO usando JAVA", "Prof. Rafael Santos", "Campus/SBC", 2003, "g11p17");

            //se o livro estiver disponível
            if (!l1.getEmprestado)
            {
                //consolida o empréstimo, e avisa o usuário
                l1.Empresta();
                Console.WriteLine("O livro: "+l1.titulo+" foi emprestado com sucesso! Devera ser devolvido em: "+Regras.diasEmprestimo+" dias.");
            }
            else
            {
                //avisa o usuário que o livro não está disponível
                Console.WriteLine("o livro solicitado: "+l1.titulo+" do autor "+l1.autor+" não se encontra disponível");
            }
            Console.ReadKey();
        }
    }
}
