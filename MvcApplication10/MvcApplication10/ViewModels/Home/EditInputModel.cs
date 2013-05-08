using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using MvcApplication10.Commands.Messages;

namespace MvcApplication10.ViewModels.Home
{
    public class EditInputModel : IEditCommandMessage
    {
        [Required]
        [DisplayName("名前")]
        public String Name { get; set; }

        [DisplayName("いろいろ")]
        [DataType(DataType.MultilineText)]
        public String Description { get; set; }
    }
}