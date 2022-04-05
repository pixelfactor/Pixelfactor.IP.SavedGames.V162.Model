using Pixelfactor.IP.SavedGames.V162.Model.Factions;
using Pixelfactor.IP.SavedGames.V162.Model.Factions.Bounty;
using System.Collections.Generic;

namespace Pixelfactor.IP.SavedGames.V162.Model
{
    public class Faction
    {
        public int Id { get; set; }

        /// <summary>
        /// Set to false if using a custom name
        /// </summary>
        public bool HasGeneratedName { get; set; }

        /// <summary>
        /// The id of the name that was generated for this faction. Stops duplicates being generated<br />
        /// Applies when <see cref="HasGeneratedName"/>
        /// </summary>
        public int GeneratedNameId { get; set; }

        /// <summary>
        /// The id of the name that was generated for this faction. Stops duplicates being generated<br />
        /// Applies when <see cref="HasGeneratedName"/>
        /// </summary>
        public int GeneratedSuffixId { get; set; }

        public bool HasCustomName { get; set; }

        /// <summary>
        /// Applies when <see cref="HasCustomName"/>
        /// </summary>
        public string CustomName { get; set; }

        /// <summary>
        /// Applies when <see cref="HasCustomName"/>
        /// </summary>
        public string CustomShortName { get; set; }

        /// <summary>
        /// Money
        /// </summary>
        public int Credits { get; set; }

        public string Description { get; set; }

        public bool IsCivilian { get; set; }

        /// <summary>
        /// Trader, miner etc
        /// </summary>
        public FactionType FactionType { get; set; }

        /// <summary>
        /// 0 - 1
        /// </summary>
        public float Aggression { get; set; }

        /// <summary>
        /// 0 - 1
        /// </summary>
        public float Virtue { get; set; }

        /// <summary>
        /// 0 - 1
        /// </summary>
        public float Greed { get; set; }

        /// <summary>
        /// 0 - 1
        /// </summary>
        public float TradeEfficiency { get; set; }

        /// <summary>
        /// Determines if can declare was
        /// </summary>
        public bool DynamicRelations { get; set; }

        /// <summary>
        /// Whether to show job board at stations
        /// </summary>
        public bool ShowJobBoards { get; set; }

        /// <summary>
        /// If new jobs are created
        /// </summary>
        public bool CreateJobs { get; set; }

        /// <summary>
        /// The RP is a limit on how many ships/stations the faction can build. Increasing this will increase the factions potential power
        /// </summary>
        public float RequisitionPointMultiplier { get; set; }

        /// <summary>
        /// Destroy faction when no ships/stations left
        /// </summary>
        public bool DestroyWhenNoUnits { get; set; }

        /// <summary>
        /// 0 - 1<br />
        /// Determines strength of NPCs when pilotting. Not used for much in v1.6.2
        /// </summary>
        public float MinNpcCombatEfficiency { get; set; }

        /// <summary>
        /// 0 - 1<br />
        /// Determines strength of NPCs when pilotting. Not used for much in v1.6.2
        /// </summary>
        public float MaxNpcCombatEfficiency { get; set; }

        /// <summary>
        /// Artificial bonus to the potential power of this faction
        /// </summary>
        public int AdditionalRpProvision { get; set; }

        /// <summary>
        /// Not used for much in 1.6.2
        /// </summary>
        public bool TradeIllegalGoods { get; set; }

        /// <summary>
        /// Time entered the game in seconds
        /// </summary>
        public double SpawnTime { get; set; }

        /// <summary>
        /// Stat for debug
        /// </summary>
        public int HighestEverNetWorth { get; set; }

        public FactionCustomSettings CustomSettings { get; set; }
        public FactionStats Stats { get; set; }
        public List<Sector> AutopilotExcludedSectors { get; set; } = new List<Sector>();
        public FactionIntel Intel { get; set; }
        public FactionRelationData Relations { get; set; }
        public FactionOpinionData Opinions { get; set; }

        public Person Leader { get; set; }
        public FactionAI FactionAI { get; set; }
        public FactionBountyBoard BountyBoard { get; set; }
        public List<FactionTransaction> Transactions { get; set; } = new List<FactionTransaction>();
    }
}
