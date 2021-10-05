namespace PhysicalPersonDirectory.Domain.Entities
{
    public class RelationPerson
    {
        public int Id { get; set; }
        public int PersonId { get; set; }
        public Person Person { get; set; }
        public int RelatedPersonId { get; set; }
        public Person RelatedPerson { get; set; }
    }
    enum ReletionshipType
    {
        Employee,
        Relative,
        Familiar,
        Other
    }
}
