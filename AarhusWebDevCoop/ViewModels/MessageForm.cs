using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AarhusWebDevCoop.ViewModels
{
    public class MessageForm
    {
        [Required]
        public string Sender { get; set; }
        [Required]
        public string Message { get; set; }
    }
}