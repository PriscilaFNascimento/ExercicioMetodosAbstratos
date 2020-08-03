
namespace ExercicioMetodosAbstratos.Entities
{
    class Individual : Payers
    {
        public double HealthExpenditures { get; set; }

        public Individual()
        {
        }

        public Individual(string name, double anualIncome, double healthExpenditures) : base(name, anualIncome)
        {
            HealthExpenditures = healthExpenditures;
        }

        public override double Taxes()
        {
            double tax,  health = 0.0;

            if(AnualIncome < 20000)
            {
                tax = AnualIncome * 0.15;
            }
            else
            {
                tax = AnualIncome * 0.25;
            }

            //Health Expenditures
            if(HealthExpenditures != 0.0)
            {
                health = HealthExpenditures * 0.5;
            }

            //Return total tax
            return tax - health;
        }
    }
}
