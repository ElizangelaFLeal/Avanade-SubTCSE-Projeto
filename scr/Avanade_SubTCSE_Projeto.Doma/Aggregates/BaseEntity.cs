namespace Avanade_SubTCSE_Projeto.Doma.Aggregates
{
    public record BaseEntity<Tid>
    {
        public Tid Id { get; set; }
    }
}
