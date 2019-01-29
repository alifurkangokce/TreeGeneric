using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeGeneric.Model
{
    public class Post:BaseEntity
    {
        [Display(Name = "Fotoğraf")]
        public string Photo { get; set; }
        [Display(Name = "Açıklama")]
        public string Description { get; set; }
        [Display(Name = "Dikim")]
        public int? PlantingId { get; set; }
        [Display(Name = "Dikim")]
        public virtual Planting Planting { get; set; }

    }
}
