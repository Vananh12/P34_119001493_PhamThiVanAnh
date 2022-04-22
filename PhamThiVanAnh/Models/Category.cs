using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PhamThiVanAnh.Models
{
    public class Category
    {
        [Key]
        public int ID { get; set; }

       [Required]
       [StringLength(200)]
        public string Name {get;set;}
        
      
}
}