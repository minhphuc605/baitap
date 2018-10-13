namespace Model.EntityFramework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PHATHANH")]
    public partial class PHATHANH
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PHATHANH()
        {
            KETQUAXOSOes = new HashSet<KETQUAXOSO>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int VESO { get; set; }

        public int MALOAI { get; set; }

        public int SOLUONG { get; set; }

        public int? MADAILY { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NGAY { get; set; }

        public int? SLBANDUOC { get; set; }

        [Column(TypeName = "money")]
        public decimal? SOTIENPHAITHANHTOAN { get; set; }

        public virtual DAILY DAILY { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KETQUAXOSO> KETQUAXOSOes { get; set; }

        public virtual LOAIVESO LOAIVESO { get; set; }
    }
}
