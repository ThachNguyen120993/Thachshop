using System;

namespace TeduShop.Model.Abstract
{
    public abstract class Auditable : IAuditable
    {
        [MaxLenght(256)]
        public DateTime? CreatedDate { set; get; }

        public string CreatedBy { set; get; }
        public DateTime? UpdatedData { set; get; }

        [MaxLenght(256)]
        public string UpdatedBy { set; get; }
        public bool Status { set; get; }
        [MaxLenght(256)]
        public string MetaKeyword { set; get; }
        [MaxLenght(256)]
        public string MetaDescription { set; get; }
    }
}