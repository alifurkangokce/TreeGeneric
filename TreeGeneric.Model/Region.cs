using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeGeneric.Model
{
    public class Region:BaseEntity
    {
        [Display(Name = "Bölge Adı")]
        public string Name { get; set; }
        [Display(Name = "Açıklama")]
        public string Description { get; set; }
        [Display(Name = "Foto")]
        public string Photo { get; set; }
        [Display(Name = "Enlem")]
        public string Lat { get; set; }
        [Display(Name = "Boylam")]
        public string Long { get; set; }
        [Display(Name = "Kapasite")]
        public int Capacity { get; set; }
        [Display(Name = "Aktif mi?")]
        public bool IsActive { get; set; }
        public virtual ICollection<Donation> Donations { get; set; }
        public virtual ICollection<TreeType> TreeTypes { get; set; }

    }
}
