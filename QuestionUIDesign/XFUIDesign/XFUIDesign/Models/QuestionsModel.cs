using System;

namespace XFUIDesign.Models
{
    public class QuestionsModel
    {
        public string Id { get; set; }
        public string ImageUri { get; set; }
        public string Question { get; set; }
        public int Time { get; set; }
        public int Users { get; set; }
        public int Likes { get; set; }

    }
}