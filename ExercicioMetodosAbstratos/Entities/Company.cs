using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioMetodosAbstratos.Entities
{
    class Company : Payers
    {
        public int NumberOfEmployees { get; set; }

        public Company()
        {
        }

        public Company(string name, double anualIncome, int numberOfEmployees) : base(name, anualIncome)
        {
            NumberOfEmployees = numberOfEmployees;
        }

        public override double Taxes()
        {
            double tax;
            if(NumberOfEmployees < 10)
            {
                tax = AnualIncome * 0.16;
            }
            else
            {
                tax = AnualIncome * 0.14;
            }

            return tax;
        }
    }
}
