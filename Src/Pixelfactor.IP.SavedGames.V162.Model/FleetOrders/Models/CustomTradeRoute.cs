namespace Pixelfactor.IP.SavedGames.V162.Model.FleetOrders.Models
{
    public class CustomTradeRoute
    {
        /// <summary>
        /// Todo replace with enum
        /// </summary>
        public int CargoClassId { get; set; }

        public Unit BuyLocation { get; set; }

        public Unit SellLocation { get; set; }

        public float BuyPriceMultiplier { get; set; }
    }
}
