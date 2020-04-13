using System.ComponentModel.DataAnnotations;

namespace DojoSurvey.Models
{
    public class Survey
    {
        [Required]
        [MinLength(2)]
        public string Name { get; set; }
        [Required]
        public string DojoLocation { get; set; }
        [Required]
        public string FavLang { get; set; }
        [MaxLength(20)]
        public string Comment { get; set; }

        public Survey() { }
        public Survey(Survey newSurvey)
        {
            Name = newSurvey.Name;
            DojoLocation = newSurvey.DojoLocation;
            FavLang = newSurvey.FavLang;
            Comment = newSurvey.Comment;

        }

    }
}