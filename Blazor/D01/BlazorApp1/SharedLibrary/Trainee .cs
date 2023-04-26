using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedLibrary
{
    public  class Trainee
    {
        public  int ID { get; set; }
        [Required]
        [StringLength(30, ErrorMessage = "Too long FName!!")]
        public string? Name { get; set; }
        [Required]
        public Gender Gender { get; set; }
        [Required]
        [EmailAddress( ErrorMessage = "Confirm your email")]
        public string? email { get; set; }
        [Required]
        [StringLength(11,ErrorMessage = "Invalid MobileNo ")]
        [MaxLength(11)]
        public string  ?MobileNo { get; set; }
        [Required]
        public bool IsGraduated { get; set; }

        [ForeignKey("Track")]
        [Required]
        public int TrackId { get; set; }
        public virtual Track? Track { get; set; }
    }
}
