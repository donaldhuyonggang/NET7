namespace 项目结构Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Admin")]
    public partial class Admin
    {
        
        [Key]
        [StringLength(50)]
        public string LoginUID { get; set; }

        [StringLength(50)]
        public string LoginPWD { get; set; }
    }
}
