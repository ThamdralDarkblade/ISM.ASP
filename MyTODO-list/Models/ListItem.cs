using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyTODO_list.Models
{
    public class ListItem
    {
        [Required(ErrorMessage ="You must specify when the event will occur")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM'/'dd'/'yyyy}", ApplyFormatInEditMode = true)]
        public DateTime When { get; set; }

        [Required(ErrorMessage = "You must enter a description")]
        [MaxLength(150, ErrorMessage =
        "The description must be less than 150 characters.")]
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }

        [Required(ErrorMessage ="You must specify how long the event will last")]
        [Range(1, 180, ErrorMessage ="Events should last between one minute and 3 hours")]
        public int? Duration { get; set; }
    }
}