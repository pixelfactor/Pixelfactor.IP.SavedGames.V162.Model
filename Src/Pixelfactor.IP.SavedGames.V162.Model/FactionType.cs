namespace Pixelfactor.IP.SavedGames.V162.Model
{
    public enum FactionType
    {
        None,
        Trader = (1 << 0),
        Scavenger = (1 << 1),
        Miner = (1 << 2),
        /// <summary>
        /// Hunts outlaws
        /// </summary>
        BountyHunter = (1 << 3),
        /// <summary>
        /// Not used in 1.6.2
        /// </summary>
        StationBuilder = (1 << 4),
        Navy = (1 << 5),
        Bandit = (1 << 6),
        PassengerTransport = (1 << 7),
        Explorer = (1 << 8),
        EquipmentDealer = (1 << 9),
        Mercenary = (1 << 10),
        /// <summary>
        /// Not used in 1.6.2
        /// </summary>
        Outlaw = (1 << 11)
    }
}
