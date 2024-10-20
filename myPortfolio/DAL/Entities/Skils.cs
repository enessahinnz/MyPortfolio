using System.ComponentModel.DataAnnotations;

namespace myPortfolio.DAL.Entities
{
    public class Skils
    {

        [Key] public int SkillId { get; set; }
        public string Title { get; set; }
        public int Value { get; set; }
    }
}
