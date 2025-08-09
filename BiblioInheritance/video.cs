using System;

namespace BiblioInheritance
{
    class Video : Resource
    {
        public string Director
        {
            get; set;
        }
        public int runtime
        {
            get; set;
        }
        public string mediaType
        {
            get; set;
        }
        public Video(string title, string category, string Director, string mediaType, int runtime) : base(title, category)
        {
            this.Director = Director;
            this.mediaType = mediaType;
            this.runtime = runtime;
        }
        public override void GetInfo()
        {
            Console.WriteLine($"Title : {Title}\n Category : {Category}\n Status : {Status}\n Director :{Director}\n MediaType :{mediaType}\n runtime : {runtime}");
        }
    }
}