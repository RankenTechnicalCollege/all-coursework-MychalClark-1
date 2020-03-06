namespace PT1
{
    interface ILoan
    {
        double MakePayment();
        double ApplyInterest();

        string Name { get; }
        string Type { get; }
            double Balance { get; }
    }
}
