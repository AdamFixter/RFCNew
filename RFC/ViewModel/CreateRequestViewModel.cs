﻿using Microsoft.AspNetCore.Mvc.Rendering;
using RFC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RFC.ViewModel
{
    public class CreateRequestViewModel
    {
        public CreateNew Request { get; set; }
        public List<SelectListItem> CustomerList { get; set; }
    }
}
