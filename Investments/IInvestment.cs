namespace TradingStrategy.Investments
{
    public interface IInvestment
    {
        string Id { get; }
        string Name { get; set; }
        double Quantity { get; set; }
        Stock Stock { get; set; }
    }
}
