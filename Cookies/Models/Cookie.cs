using System;
using System.ComponentModel.DataAnnotations;

namespace Cookies.Models
{
    public class Cookie
    {
        [Required]
        public string CookieName { get; set; }
        [Required]
        public string CookieValue { get; set; }

    }
}
