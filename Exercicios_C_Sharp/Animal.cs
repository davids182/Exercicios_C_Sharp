using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_C_Sharp
{
    public class Animal
    {
        public string nome; // raça do animal
        public string tipo; //dono do animal
       

        public string getTipo()
        {

            return this.tipo;

        }

        public void setTipo(string tipo)
        {

            this.tipo = tipo;

        }

                  
        public string getNome()
        {

            return this.nome;

        }

        public void setNome(string nome)
        {

            this.nome = nome;

        }

        public string validaTipo(string tipo)
        {

            if (this.tipo == "cachorro" || this.tipo == "gato" || this.tipo == "peixe")
            {
               return  this.tipo = tipo;
            }else
            { 
              return  this.tipo = "peixe";
            }

        }

       

       

       
    }
}
