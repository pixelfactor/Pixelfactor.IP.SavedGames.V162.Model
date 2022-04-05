namespace Pixelfactor.IP.SavedGames.V162.Model
{
    /// <summary>
    /// A message that shows up after a certain amount of time
    /// </summary>
    public class PlayerDelayedMessage
    {
        public PlayerMessage Message { get; set; }
        /// <summary>
        /// The scenario time in seconds when to show the message
        /// </summary>
        public double ShowTime { get; set; }
    }
}
