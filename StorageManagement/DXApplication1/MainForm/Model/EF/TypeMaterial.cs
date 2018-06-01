namespace MainForm.Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TypeMaterial")]
    public partial class TypeMaterial
    {
        public long ID { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        public long? SupplierID { get; set; }

    }
}
