using System.ComponentModel.DataAnnotations;

namespace PhamThiVanAnh.Models
{
    public class Comment
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public string Author{get;set;}

        

        [Required]
        public string Content{get;set;}

      
        public string CreatedAt {get;set;}
}
}