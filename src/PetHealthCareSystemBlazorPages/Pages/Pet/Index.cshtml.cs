﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BusinessObject.Entities;
using Service.IServices;
using Service.Services;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;
using BusinessObject.DTO.Pet;

namespace PetHealthCareSystemRazorPages.Pages.Pet
{
    public class IndexModel : PageModel
    {
        private readonly IPetService _petService;

        public IndexModel(IPetService petService)
        {
            _petService = petService;
        }

        public IList<PetResponseDto> Pet { get; set; }

        public async Task OnGetAsync()
        {
            Pet = await _petService.GetAllPetsForCustomerAsync(2002);

        }
    }
}