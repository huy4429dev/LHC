using System;

namespace DVN.Models
{
    public class  Post
    {
        public int Id{get;set;}
        public string Title{get;set;}
        public string Thumbnail{get;set;}
        public string Description{get;set;}
        public string Content{get;set;}
        public int UserId{get;set;}
        public virtual User User{get;set;}
        public DateTime CreatedAt{get;set;}
        public DateTime UpdatedAt{get;set;}
        

    }
}