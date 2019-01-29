using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeGeneric.Model
{
   public class Donation:BaseEntity
    {
        [Display(Name = "Bağışçı")]
        public string Owner { get; set; }
        [Display(Name = "Fidan")]
        public int TreeTypeId { get; set; }
        [Display(Name = "Fidan")]
        public virtual TreeType TreeType { get; set; }
        [Display(Name = "Bölge")]
        public int RegionId { get; set; }
        [Display(Name = "Bölge")]
        public virtual Region Region { get; set; }
        [Display(Name = "Adet")]
        public int Quantity { get; set; }
        [Display(Name = "Ağaç Adı")]
        public string TreeName { get; set; }
        [Display(Name = "Ağaç açıklama")]
        public string TreeDescription { get; set; }
        [Display(Name = "Ağaç ücreti")]
        public decimal TreePrice { get; set; }
        [Display(Name = "Ekim ücreti")]
        public decimal PlantingPrice { get; set; }
        [Display(Name = "Komisyon")]
        public decimal Commision { get; set; }
        [Display(Name = "Birim fiyat")]
        public decimal UnitPrice { get { return TreePrice + PlantingPrice + Commision; } }
        [Display(Name = "Toplam fiyat")]
        public decimal TotalPrice { get { return UnitPrice * Quantity; } }
        public virtual ICollection<Planting> Plantings { get; set; }
    }
}
