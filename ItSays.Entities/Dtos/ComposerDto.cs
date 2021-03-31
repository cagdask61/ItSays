﻿using ItSays.Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace ItSays.Entities.Dtos
{
    public class ComposerDto : IDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
    }
}
