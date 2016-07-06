using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeduShop.Model.Abstract;

namespace TeduShop.Model.Models
{
    [Table("PosttCategories")]
    public class PosttCategory : Auditable
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
        [MaxLenght(500)]
        public string Description { set; get; }

        public int ParentID { set; get; }
        public int DisplayOrder { set; get; }
        [MaxLenght(256)]
        public string Image { set; get; }
        public bool HomeFlag { set; get; }
        public virtual IEnumerable<Post> Post { set; get; }

    }
}
