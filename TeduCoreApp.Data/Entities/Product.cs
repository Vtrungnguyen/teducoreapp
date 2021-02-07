using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using TeduCoreApp.Data.Enums;
using TeduCoreApp.Data.Interfaces;

namespace TeduCoreApp.Data.Entities
{
    public class Product : DomainEntity<int>, ISwitchable, IDateTracking, IHasSeoMetaData
    {

        public string Name { get; set; }
        public int CategoryId { get; set; }
        public string Image { get; set; }
        public decimal Price { get; set; }
        public decimal PromotionPrice { get; set; }
        public decimal OriginalPrice { get; set; }
        public string Description { get; set; }
        public string Content { get; set; }
        public bool? HomeFlag { get; set; }
        public bool HotFlag { get; set; }
        public int? ViewCount { get; set; }
        public string Tags { get; set; }
        public string Unit { get; set; }

        [ForeignKey("CategoryId")]
        public virtual ProductCategory ProductCategory { set; get; }

        public Status Status { set; get; }
        public DateTime DateCreated { set; get; }
        public DateTime DateModified { set; get; }
        public string SeoPageTitle { set; get; }
        public string SeoAlias { set; get; }
        public string SeoKeyWords { set; get; }
        public string SeoDescription { set; get; }


    }
}