using System.Collections.Generic;

namespace Pixelfactor.IP.SavedGames.V162.Model.FleetOrders.OrderTypes
{
    public class SellCargoOrder : FleetOrder
    {
        public int FreeUnitsCompleteThreshold { get; set; }
        public float MinBuyPriceMultiplier { get; set; }
        public bool SellOnlyListedCargos { get; set; }
        public bool CompleteWhenNoBuyerFound { get; set; }
        public bool CompleteWhenNoCargoToSell { get; set; }
        public Unit ManualBuyerUnit { get; set; }
        public float CustomSellCargoTime { get; set; }
        /// <summary>
        /// TODO: Change to enum
        /// </summary>
        public List<CargoClass> SellCargoClasses { get; set; } = new List<CargoClass>();
        public bool SellEquipment { get; set; }

        public override FleetOrderType OrderType => FleetOrderType.SellCargo;
    }
}
