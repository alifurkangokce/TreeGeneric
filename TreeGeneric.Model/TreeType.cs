using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeGeneric.Model
{
    public class TreeType:BaseEntity
    {
        [Display(Name = "Ad")]
        public string Name { get; set; }
        [Display(Name = "Açıklama")]
        public string Description { get; set; }
        [Display(Name = "Foto")]
        public string Photo { get; set; }
        [Display(Name = "Ağaç Ücreti")]
        public decimal TreePrice { get; set; }
        [Display(Name = "Ekim Ücreti")]
        public decimal PlantingPrice { get; set; }
        [Display(Name = "Komisyon")]
        public decimal Commision { get; set; }
        [Display(Name = "Birim Fiyat")]
        public decimal UnitPrice { get { return TreePrice + PlantingPrice + Commision; } }
        [Display(Name = "Aktif mi?")]
        public bool IsActive { get; set; }
        [Display(Name = "Stokta Kalan Adet")]
        public int AvailibilityCount { get; set; }
        public int RegionId { get; set; }
        public virtual Region Region { get; set; }

        public virtual ICollection<Donation> Donations { get; set; }
    }
}
