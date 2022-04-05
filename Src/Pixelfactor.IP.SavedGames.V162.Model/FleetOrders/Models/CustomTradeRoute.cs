namespace Pixelfactor.IP.SavedGames.V162.Model.FleetOrders.Models
{
    public class CustomTradeRoute
    {
        public CargoClass CargoClass { get; set; }

        public Unit BuyLocation { get; set; }

        public Unit SellLocation { get; set; }

        public float BuyPriceMultiplier { get; set; }
    }
}
