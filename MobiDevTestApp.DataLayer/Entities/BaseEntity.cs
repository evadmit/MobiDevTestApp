using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MobiDevTestApp.DataLayer.Entities
{
    public abstract class BaseEntity
    {
        [Key]
        public long Id { get; set; }
        public string Title { get; set; }

        [Required(AllowEmptyStrings = true)]
        public DateTime CreationDate { get; set; }
        public BaseEntity()
        {
            CreationDate = DateTime.UtcNow;
        }
    }
}
