﻿namespace Pixelfactor.IP.SavedGames.V162.Model
{
    /// <summary>
    /// Data about this specific scenario
    /// </summary>
    public class ScenarioData
    {
        public double NextRandomEventTime { get; set; }
        public bool HasRandomEvents { get; set; }
        public FactionSpawner FactionSpawner { get; set; }
    }
}
