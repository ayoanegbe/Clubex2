﻿using System.ComponentModel.DataAnnotations;

namespace Clubex2.Models.AccountViewModels
{
    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
