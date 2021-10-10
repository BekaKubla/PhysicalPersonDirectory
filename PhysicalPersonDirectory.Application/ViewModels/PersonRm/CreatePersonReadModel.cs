using PhysicalPersonDirectory.Domain.Entities;
using System;
using System.Collections.Generic;

namespace PhysicalPersonDirectory.Application.ViewModels.PersonRm
{
    public class CreatePersonReadModel
    {

        public CreatePersonReadModel(Person person)
        {
            Id = person.Id;
            NameEn = person.NameEn;
            NameGe = person.NameGe;
            SurnameEn = person.SurnameEn;
            SurnameGe = person.SurnameGe;
            PersonalNumber = person.PersonalNumber;
            DateOfBirth = person.DateOfBirth;
            Adress = person.Adress;
            ImgUrl = person.ImgUrl;
            ContactInfos = person.ContactInfos;
            RelatedTo = person.RelatedTo;
            Relationship = person.Relationship;
        }


        public int Id { get; set; }
        public string NameGe { get; set; }
        public string NameEn { get; set; }
        public string SurnameGe { get; set; }
        public string SurnameEn { get; set; }
        public string PersonalNumber { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Adress { get; set; }
        public string ImgUrl { get; set; }
        public IEnumerable<ContactInfo> ContactInfos { get; set; } = new List<ContactInfo>();
        public IEnumerable<RelationPerson> Relationship { get; set; } = new List<RelationPerson>();
        public IEnumerable<RelationPerson> RelatedTo { get; set; } = new List<RelationPerson>();
    }
}
