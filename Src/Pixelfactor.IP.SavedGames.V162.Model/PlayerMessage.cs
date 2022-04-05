namespace Pixelfactor.IP.SavedGames.V162.Model
{
    public class PlayerMessage
    {
        public int Id { get; set; }
        public double EngineTimeStamp { get; set; }
        public bool AllowDelete { get; set; }
        public bool Opened { get; set; }
        public Unit SenderUnit { get; set; }
        public Unit SubjectUnit { get; set; }
        public int MessageTemplateId { get; set; }
        public string ToText { get; set; }
        public string FromText { get; set; }
        public string MessageText { get; set; }
        public string SubjectText { get; set; }
    }
}
