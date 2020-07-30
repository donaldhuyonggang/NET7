namespace 项目结构Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Sys_Resource
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Sys_Resource()
        {
            Sys_Resource1 = new HashSet<Sys_Resource>();
            Sys_Role = new HashSet<Sys_Role>();
        }

        [Key]
        public int ResourceId { get; set; }

        [StringLength(50)]
        public string ResourceName { get; set; }

        [StringLength(50)]
        public string ResourcePath { get; set; }

        public int? ParentId { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sys_Resource> Sys_Resource1 { get; set; }

        public virtual Sys_Resource Sys_Resource2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sys_Role> Sys_Role { get; set; }
    }
}
