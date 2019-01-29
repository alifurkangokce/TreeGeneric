using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeGeneric.Model
{
   public class Planting:BaseEntity
    {
        [Display(Name = "Dikici Kullanıcı")]
        public int PlanterUserId { get; set; }
        [Display(Name = "Dikici Kullanıcı")]
        public virtual User PlanterUser { get; set; }
        [Display(Name = "Bağış")]
        public int DonationId { get; set; }
        [Display(Name = "Bağış")]
        public virtual Donation Donation { get; set; }

        [Display(Name = "Paylaşımlar")]
        public virtual ICollection<Post> Posts { get; set; }


        [Display(Name = "Dikim Tarihi")]
        public DateTime PlantingDate { get; set; }
        [Display(Name = "Enlem")]
        public string Lat { get; set; }
        [Display(Name = "Boylam")]
        public string Long { get; set; }
        [Display(Name = "Ekim Kodu")]
        public string PlantingCode { get; set; }
    }
}
