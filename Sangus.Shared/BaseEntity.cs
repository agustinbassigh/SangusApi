using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Sangus.Shared
{
    public class BaseEntity
    {
        [Key]
        public int Id { get; set; }

    }
}
