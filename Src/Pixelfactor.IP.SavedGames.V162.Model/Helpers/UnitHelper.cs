using Pixelfactor.IP.SavedGames.V162.Model;

namespace Pixelfactor.IP.SavedGames.V162.Model.Helpers
{
    public static class UnitHelper
    {
        /// <summary>
        /// HACK due to bad save format
        /// </summary>
        /// <param name="unitClass"></param>
        /// <returns></returns>
        public static bool IsProjectile(UnitClass unitClass)
        {
            return unitClass.ToString().Contains("Projectile");
        }
    }
}
