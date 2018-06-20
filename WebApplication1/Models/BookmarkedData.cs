using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Bookmaker.Models
{
    public class BookmarkData : StoredData
    {
        [Required]
        public int Id { set; get; }
    }
}