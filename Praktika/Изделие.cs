namespace Praktika
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Изделие
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Изделие()
        {
            Заказанные_изделия = new HashSet<Заказанные_изделия>();
            Фурнитура_изделия = new HashSet<Фурнитура_изделия>();
            Ткань = new HashSet<Ткань>();
        }

        [Key]
        [StringLength(150)]
        public string Артикул { get; set; }

        [Required]
        [StringLength(255)]
        public string Наименование { get; set; }

        public double Ширина { get; set; }

        public double Длина { get; set; }

        [Column(TypeName = "image")]
        public byte[] Изображение { get; set; }

        [StringLength(255)]
        public string Комментарий { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Заказанные_изделия> Заказанные_изделия { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Фурнитура_изделия> Фурнитура_изделия { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ткань> Ткань { get; set; }
    }
}
