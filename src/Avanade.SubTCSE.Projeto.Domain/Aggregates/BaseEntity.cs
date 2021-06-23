namespace Avanade.SubTCSE.Projeto.Domain.Aggregates.Employee
{
    public record BaseEntity<Tid>
    {
        public Tid Id { get; set; }
    }
}
