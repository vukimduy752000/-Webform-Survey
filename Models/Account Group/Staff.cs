﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SurveyWebform.Models.Account_Group
{
    public class Staff
    {
        [Key]
        public int Staff_Id { get; set; }

        [Required]
        public string Staff_Username { get; set; }

        [Required]
        public string Staff_Password { get; set; }
    }
}