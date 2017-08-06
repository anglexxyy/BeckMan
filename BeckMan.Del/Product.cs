namespace BeckMan.Del
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Product")]
    public partial class Product
    {
        public int ID { get; set; }

        public int SequnNo { get; set; }

        [Required]
        [StringLength(200)]
        public string Name { get; set; }

        public int Year { get; set; }

        [StringLength(2000)]
        public string Remark { get; set; }
    }
}
