using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_C_Sharp
{
    class Animal
    {
        protected string dono; //dono do animal
        protected int natureza; // se selvagem ou doméstico
        string tipo; // cahchorro ou gato ou peixe ou etc
        string raca; // raça do animal

        public string getDono()
        {

            return this.dono;

        }

        public void setDono(string agencia)
        {

            this.agencia = agencia;

        }

    }
}
