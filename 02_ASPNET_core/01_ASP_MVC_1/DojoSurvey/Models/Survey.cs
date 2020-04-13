namespace DojoSurvey.Models
{
    public class Survey
    {
        public string Name { get; set; }
        public string DojoLocation { get; set; }
        public string FavLang { get; set; }
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