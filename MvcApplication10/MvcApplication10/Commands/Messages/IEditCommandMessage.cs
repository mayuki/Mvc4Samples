using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MvcApplication10.Commands.Messages
{
    public interface IEditCommandMessage
    {
        [Required]
        [DisplayName("名前")]
        String Name { get; set; }

        [DisplayName("いろいろ")]
        [DataType(DataType.MultilineText)]
        String Description { get; set; }
    }
}