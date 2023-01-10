using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Serialization;

namespace PWS_3.Models
{
    [XmlRoot("Student")]
    public class StudentDto
    {
        public int Id { get; set; }

        [NotMapped]
        [XmlIgnore]
        [JsonIgnore]
        public bool IdSpecified { get; set; } = true;

        public string Name { get; set; }

        [NotMapped]
        [XmlIgnore]
        [JsonIgnore]
        public bool NameSpecified { get; set; } = true;

        public string Number { get; set; }

        [NotMapped]
        [XmlIgnore]
        [JsonIgnore]
        public bool NumberSpecified { get; set; } = true;

        [NotMapped]
        [XmlIgnore]
        [XmlArrayItem("Link")]
        public Link[] Links { get; set; }

        public StudentDto(Student student)
        {
            Id = student.Id;
            Number = student.Phone;
            Name = student.Name;
        }

        public StudentDto()
        {
            Id = 0;
            Number = null;
            Name = null;
        }

    }
}