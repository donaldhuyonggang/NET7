namespace 项目结构Model
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class NET41 : DbContext
    {
        public NET41()
            : base("name=NET41")
        {
        }

        public virtual DbSet<Admin> Admin { get; set; }
        public virtual DbSet<Goods> Goods { get; set; }
        public virtual DbSet<Goods_Type> Goods_Type { get; set; }

        public virtual DbSet<Sys_Resource> Sys_Resource { get; set; }
        public virtual DbSet<Sys_Role> Sys_Role { get; set; }
        public virtual DbSet<Sys_User> Sys_User { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Sys_Resource>()
                .HasMany(e => e.Sys_Resource1)
                .WithOptional(e => e.Sys_Resource2)
                .HasForeignKey(e => e.ParentId);

            modelBuilder.Entity<Sys_Resource>()
                .HasMany(e => e.Sys_Role)
                .WithMany(e => e.Sys_Resource)
                .Map(m => m.ToTable("Sys_Right").MapLeftKey("ResourceId").MapRightKey("RoleId"));
        }
    }
}
