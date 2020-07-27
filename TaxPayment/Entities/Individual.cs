namespace TaxPayment.Entities
{
    class Individual : TaxPayer
    {
        public double HealthExpenditures { get; private set; }
        public Individual(string name, double anualIncome, double healthExpenditures) : base(name, anualIncome)
        {
            HealthExpenditures = healthExpenditures;
        }
        public override double Tax()
        {
            double inc = 0;
            if (AnualIncome < 20000)
            {
                inc = AnualIncome * 0.15;
            }
            else
            {
                inc = AnualIncome * 0.25;
            }
            if (HealthExpenditures != 0)
            {
                return inc - (HealthExpenditures * 0.50);
            }
            else
            {
                return inc;
            }
        }

    }
}
