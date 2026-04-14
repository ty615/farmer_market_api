using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Farmer_Market_Api.Models
{
    public class UpdateRequest
    {
        public string OldName{get;set;}
        public string NewName{get;set;}

    }
}