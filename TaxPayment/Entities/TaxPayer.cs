namespace TaxPayment.Entities
{
    abstract class TaxPayer
    {
        public string Name { get; private set; }
        public double AnualIncome { get; protected set; }

        public TaxPayer(string name, double anualIncome)
        {
            Name = name;
            AnualIncome = anualIncome;
        }
        public abstract double Tax();
    }
}
