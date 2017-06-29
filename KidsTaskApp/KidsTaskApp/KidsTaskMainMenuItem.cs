using System;

namespace KidsTaskApp
{

    public class KidsTaskMainMenuItem
    {
        public KidsTaskMainMenuItem()
        {
            TargetType = typeof(KidsTaskMainDetail);
        }
        public KidsTaskMainMenuItem(int Id, string Title, Type TargetType)
        {
            this.Id = Id;
            this.Title = Title;
            this.TargetType = TargetType;
        }
        public int Id { get; set; }
        public string Title { get; set; }

        public Type TargetType { get; set; }
    }
}