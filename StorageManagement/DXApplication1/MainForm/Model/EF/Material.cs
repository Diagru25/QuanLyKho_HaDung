namespace MainForm.Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Material")]
    public partial class Material
    {
        public long ID { get; set; }

        [StringLength(100)]
        public string Name { get; set; }

        public decimal? Price { get; set; }

        [StringLength(50)]
        public string Unit { get; set; }

        public long? TypeMaterialID { get; set; }
    }
}
