namespace Model.EntityFramework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KETQUAXOSO")]
    public partial class KETQUAXOSO
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int VESO { get; set; }

        [Column(TypeName = "date")]
        public DateTime NGAY { get; set; }

        public int MAGIAI { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SOTRUNG { get; set; }

        public virtual GIAI GIAI { get; set; }

        public virtual PHATHANH PHATHANH { get; set; }
    }
}
