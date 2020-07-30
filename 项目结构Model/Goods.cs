namespace 项目结构Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Goods
    {
        public int GoodsId { get; set; }

        [StringLength(50)]
        public string GoodsName { get; set; }

        public double? Price { get; set; }

        public int? Num { get; set; }

        public int? TypeId { get; set; }

        public virtual Goods_Type Goods_Type { get; set; }
    }
}
