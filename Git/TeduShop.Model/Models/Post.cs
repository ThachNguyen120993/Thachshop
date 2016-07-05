using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TeduShop.Model.Abstract;

namespace TeduShop.Model.Models
{
    [Table("Posts")]
    public class Post : Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }
       [Required]
        [MaxLenght(256)]
        public string Name { set; get; }
        [Column(TypeName = "varchar")]
        [Required]
        [MaxLenght(256)]
        public string Alias { set; get; }
        [Required]
        public int CategoryID { set; get; }
        [MaxLenght(256)]
        public string Image { set; get; }
        [MaxLenght(500)]
        public string Description { set; get; }
        public bool HomeFlag { set; get; }
        public bool HotFlag { set; get; }
        public int ViewCount { set; get; }
        [ForeignKey("CategoryID")]
        public virtual PosttCategory PosttCategory { set; get; }

    }
}