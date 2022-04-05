using Pixelfactor.IP.SavedGames.V162.Model.Factions;
using Pixelfactor.IP.SavedGames.V162.Model.Factions.FactionAITypes;
using System;

namespace Pixelfactor.IP.SavedGames.V162.Model
{
    public static class CreateFactionAIFromType
    {
        public static FactionAI Create(FactionAIType factionAIType)
        {
            switch (factionAIType)
            {
                case FactionAIType.Navy:
                    {
                        return new FactionAINavy();
                    }
                case FactionAIType.Trader:
                    {
                        return new FactionAITrader();
                    }
                case FactionAIType.Miner:
                    {
                        return new FactionAIMiner();
                    }
                case FactionAIType.Patroller:
                    {
                        return new FactionAIPatroller();
                    }
                case FactionAIType.StationBuilder:
                    {
                        return new FactionAIStationBuilder();
                    }
                case FactionAIType.Generic:
                    {
                        return new FactionAI();
                    }
                default:
                    {
                        throw new NotImplementedException($"Unknown faction AI type {(int)factionAIType}");
                    }
            }
        }
    }
}
