using System;
using System.Collections.Generic;

namespace Project1.Models.ViewModels
{
    public class QuadrantsViewModel
    {
       public IEnumerable<TaskItem> QuadrantI { get; set; }
       public IEnumerable<TaskItem> QuadrantII { get; set; }
       public IEnumerable<TaskItem> QuadrantIII { get; set; }
       public IEnumerable<TaskItem> QuadrantIV { get; set; }
    }
}
