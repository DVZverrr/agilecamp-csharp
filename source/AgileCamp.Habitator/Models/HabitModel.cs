using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using AgileCamp.Habitator.Controllers;

namespace AgileCamp.Habitator.Models
{
   public class HabitModel
   {
      public string ReturnUrl { get; set; }

      [Display(Name = "Название привычки")]
      public string Name { get; set; }

      [Display(Name = "Начинаем привыкать")]
      [DataType(DataType.Date)]
      public DateTime StartDate { get; set; }

      [DataType(DataType.Date)]
      [Display(Name = "Привыкнуть до")]
      public DateTime EndDate { get; set; }

      [Display(Name = "В чем соль?")]
      public string Description { get; set; }
   }
}