// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ContactViewModel.cs" company="">
//   
// </copyright>
// <summary>
//   Defines the ContactViewModel type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace stoyanstoyanov_Web.ViewModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Threading.Tasks;

    public class ContactViewModel
    {
        [Required]
        [StringLength(150, MinimumLength = 2)]
        public string Name { get; set; }

        [Required]
        [EmailAddress]
        [StringLength(150, MinimumLength = 5)]
        public string Email { get; set; }

        [Required]
        [StringLength(512, MinimumLength = 10)]
        public string Message { get; set; }
    }
}
