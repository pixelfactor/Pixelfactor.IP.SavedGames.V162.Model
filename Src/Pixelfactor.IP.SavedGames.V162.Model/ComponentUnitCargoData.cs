using System.Collections.Generic;

namespace Pixelfactor.IP.SavedGames.V162.Model
{
    /// <summary>
    /// The cargo this ship/station is carrying
    /// </summary>
    public class ComponentUnitCargoData
    {
        public List<ComponentUnitCargoDataItem> Items { get; set; } = new List<ComponentUnitCargoDataItem>();
    }
}
