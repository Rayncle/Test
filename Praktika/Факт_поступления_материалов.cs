namespace Praktika
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Факт поступления материалов")]
    public partial class Факт_поступления_материалов
    {
        [Key]
        [StringLength(150)]
        public string Номер_поставки { get; set; }

        [StringLength(150)]
        public string Закупаемый_материал { get; set; }

        [StringLength(150)]
        public string Количество { get; set; }

        [StringLength(150)]
        public string Закупочная_цена { get; set; }

        [StringLength(150)]
        public string Сумма { get; set; }
    }
}
