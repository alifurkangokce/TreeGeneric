using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeGeneric.Model
{
    [Flags]
    public enum UserType
    {
        [Display(Name = "Bağışçı")]
        Donator = 1,
        [Display(Name = "Dikim Görevlisi")]
        Planter = 2
    }
}
