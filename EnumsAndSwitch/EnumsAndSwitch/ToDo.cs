namespace EnumsAndSwitch
{
    internal class ToDo
    {
        public string Description { get; set; }
        public int EstimatedHours { get; set; }
        public Status Status { get; set; }
    }
    enum Status
    {
        NotStarted,
        InProgress,
        OnHold,
        Completed,
        Deleted
        
    }
}