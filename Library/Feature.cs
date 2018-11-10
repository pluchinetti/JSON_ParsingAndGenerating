namespace Library
{
    public class Feature
    {
        public string Title {get; set;}

        public bool Status {get; set;}

        public Feature(string title, bool status)
        {
            this.Title = title;
            this.Status = status;
        }
    }
}