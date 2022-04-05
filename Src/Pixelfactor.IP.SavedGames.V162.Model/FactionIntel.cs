using System.Collections.Generic;

namespace Pixelfactor.IP.SavedGames.V162.Model
{
    public class FactionIntel
    {
        public List<Sector> Sectors { get; set; } = new List<Sector>();
        public List<Unit> Units { get; set; } = new List<Unit>();
    }
}
