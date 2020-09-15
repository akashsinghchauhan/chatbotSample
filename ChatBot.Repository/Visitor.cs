using System.ComponentModel.DataAnnotations;

namespace ChatBot.Repository
{
    public class Visitor
    {
        [Key]
        public long Id { get; set; }
        [MaxLength(50)]
        public string Name { get; set; }
        [MaxLength(50)]
        public string Gender { get; set; }
        [MaxLength(50)]
        public string Age { get; set; }
    }
}
