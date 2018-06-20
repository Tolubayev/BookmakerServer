using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Bookmaker.Models
{
    public class StoredData
    {
       
            [Url]
            public string Avatar { set; get; }
            [Required]
            public string Name { set; get; }
       
    }
}