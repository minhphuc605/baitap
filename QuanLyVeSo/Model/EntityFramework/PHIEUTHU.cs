namespace Model.EntityFramework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PHIEUTHU")]
    public partial class PHIEUTHU
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MAPHIEUTHU { get; set; }

        public int? MADAILY { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NGAY { get; set; }

        [StringLength(10)]
        public string SOTIEN { get; set; }

        public virtual DAILY DAILY { get; set; }
    }
}
