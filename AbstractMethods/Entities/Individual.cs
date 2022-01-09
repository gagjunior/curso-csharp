namespace AbstractMethods.Entities
{
    class Individual : TaxPayer
    {
        public double HealthExpenditures { get; set; }

        public Individual(string name, double anualIncome, double healthExpenditures) 
            : base(name, anualIncome)
        {
            HealthExpenditures = healthExpenditures;
        }

        public override double Tax()
        {
            double incomeTax = 0.0;
            double healthDiscount = 0.0;

            if (AnualIncome < 20000.00)
            {
                incomeTax = AnualIncome * 0.15;
            }
            else
            {
                incomeTax = AnualIncome * 0.25;
            }

            if (HealthExpenditures > 0)
            {
                healthDiscount = HealthExpenditures * 0.50;
            }

            return incomeTax - healthDiscount;
        }
    }
}
