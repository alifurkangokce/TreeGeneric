using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeGeneric.Model
{
   public class User:BaseEntity
    {
        [Display(Name = "Ad")]
        public string FirstName { get; set; }
        [Display(Name = "Soyad")]
        public string LastName { get; set; }
        [Display(Name = "Eposta")]
        public string Email { get; set; }
        [Display(Name = "Şifre")]
        public string Password { get; set; }
        [Display(Name = "Onaylandı mı?")]
        public bool IsEmailConfirmed { get; set; }
        [Display(Name = "Eposta Onay Kodu")]
        public string EmailConfirmationCode { get; set; }
        [Display(Name = "Eposta Onay Tarihi")]
        public DateTime? EmailConfirmationDate { get; set; }
        [Display(Name = "Doğum Tarihi")]
        public DateTime? BirthDate { get; set; }
        [Display(Name = "Cinsiyet")]
        public Gender? Gender { get; set; }
        [Display(Name = "Telefon")]
        public string Phone { get; set; }
        [Display(Name = "Kullanıcı Tipi")]
        public UserType UserType { get; set; }
        [Display(Name = "Aktif mi?")]
        public bool IsActive { get; set; }
        public virtual ICollection<Planting> Plantings { get; set; }
    }
}
