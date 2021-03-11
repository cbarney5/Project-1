using System;
using System.ComponentModel.DataAnnotations;

namespace Project1.Models
{
    public class TaskItem
    {
       [Key]
       [Required]
       public int TaskId { get; set; }

       [Required]
       public string TaskDescription { get; set; }

       [Required]
       public bool Urgent { get; set; }

       [Required]
       public bool Important { get; set; }

        public string GetQuadrant()
        {
            string quadrantName = "";
            if (Urgent && Important)
            {
                quadrantName = "Quadrant I";
            }
            else if (!Urgent && Important)
            {
                quadrantName = "Quadrant II";
            }
            else if (Urgent && !Important)
            {
                quadrantName = "Quadrant III";
            }
            else if (!Urgent && !Important)
            {
                quadrantName = "Quadrant IV";
            }

            return quadrantName;
        }
    }
}
