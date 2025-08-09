using System;

namespace BiblioInheritance
{
    class Resource
    {
        public string Title
        {
            get; private set;
        }
        public string Category
        {
            get; private set;
        }
        public string Status
        {
            get; protected set;
        }
        public Resource(string title, string category)
        {
            this.Title = title;
            this.Category = category;
            this.Status = "Available";
        }
        public virtual void UpdateStatus()
        {
            if (Status == "Available")
            {
                Status = "Out";
            }
            else
            {
                Status = "Available";
            }
        }
        public virtual void GetInfo()
        {
            Console.WriteLine($"Title : {Title}\n Category : {Category}\n Status : {Status}");
        }
    }
}