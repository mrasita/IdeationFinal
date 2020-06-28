using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ideation.Models
{
    public class Ideas
    {
        public int Id { get; set; }

        public string Idea { get; set; }

        public virtual Meeting Meeting { get; set; }

        public virtual User Owner { get; set; }

    }
}