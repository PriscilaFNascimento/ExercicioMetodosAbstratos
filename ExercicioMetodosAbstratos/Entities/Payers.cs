using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioMetodosAbstratos.Entities
{
    abstract class Payers
    {
        public string Name { get; set; }
        public double AnualIncome { get; set; }

        protected Payers()
        {
        }

        protected Payers(string name, double anualIncome)
        {
            Name = name;
            AnualIncome = anualIncome;
        }

        public abstract double Taxes();
    }
}
