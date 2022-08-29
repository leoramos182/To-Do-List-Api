namespace Domain.Entities
{
    internal class Todo : EntityBase
    {
        public string? Title { get; private set; }
        public string? User { get; private set; }
        public bool Done { get; private set; }
        public DateTime Date { get; private set; }
    }
}
