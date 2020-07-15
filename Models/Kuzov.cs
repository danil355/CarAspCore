using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DZ_CAR.Models
{
    public enum Kuzov
    {
        [Display(Name = "Седан")]
        Sedan,

        [Display(Name = "Купе")]
        Coupe,

        [Display(Name = "Минивэн")]
        Minivan,

        [Display(Name = "Спейс вагон")]
        SpaceWagon,

        [Display(Name = "Лимузин")]
        Limousine
    }
}
