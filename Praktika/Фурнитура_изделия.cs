namespace Praktika
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Фурнитура изделия")]
    public partial class Фурнитура_изделия
    {
        [Key]
        [Column("Артикул фурнитуры", Order = 0)]
        [StringLength(150)]
        public string Артикул_фурнитуры { get; set; }

        [Key]
        [Column("Артикул изделия", Order = 1)]
        [StringLength(150)]
        public string Артикул_изделия { get; set; }

        [Required]
        [StringLength(150)]
        public string Размещение { get; set; }

        public double? Ширина { get; set; }

        public double? Длина { get; set; }

        public double? Поворот { get; set; }

        public int Количество { get; set; }

        public virtual Изделие Изделие { get; set; }

        public virtual Фурнитура Фурнитура { get; set; }
    }
}
