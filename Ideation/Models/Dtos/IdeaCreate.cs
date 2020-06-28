using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ideation.Models.Dtos
{
    public class IdeaCreate
    {

        public string Idea { get; set; }

        public int MeetingId { get; set; }
        
    }
}