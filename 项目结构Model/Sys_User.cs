namespace 项目结构Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Sys_User
    {
        [Key]
        public int UserId { get; set; }

        [StringLength(50)]
        public string UserName { get; set; }

        public int? RoleId { get; set; }

        [StringLength(50)]
        public string LoginId { get; set; }

        [StringLength(50)]
        public string LoginPwd { get; set; }

        public bool IsAdmin { get; set; }

        public virtual Sys_Role Sys_Role { get; set; }
    }
}
