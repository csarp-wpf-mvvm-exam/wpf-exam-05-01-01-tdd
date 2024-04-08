﻿using Kreta.Backend.Repos;
using Kreta.Shared.Assamblers;
using Kreta.Shared.Dtos;
using Kreta.Shared.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Kreta.Backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SchoolClassController : BaseController<SchoolClass, SchoolClassDto>
    {
        private readonly ISchoolClassRepo? _schoolClassRepo;
        public SchoolClassController(SchoolClassAssambler? assambler, ISchoolClassRepo? repo) : base(assambler, repo)
        {
            _schoolClassRepo = repo;
        }

        [HttpGet("included")]
        public async Task<IActionResult> SelectAllIncludedAsync()
        {
            List<SchoolClass>? schoolClasses = new();
            if (_schoolClassRepo != null && _assambler is not null)
            {
                try
                {
                    schoolClasses = await _schoolClassRepo.SelectAllIncluded().ToListAsync();
                    return Ok(schoolClasses.Select(entity => _assambler.ToDto(entity)));
                }
                catch (Exception ex)
                {

                }
            }
            return BadRequest("Az adatok elérhetetlenek!");
        }

        [HttpGet("getbytypeofeducationid/{typeOfEducationID}")]
        public async Task<IActionResult> GetByTypeOfEducationId(Guid typeOfEducationID)
        {
            List<SchoolClass>? schoolClasses = new();
            if (_schoolClassRepo != null && _assambler is not null)
            {
                try
                {
                    schoolClasses = await _schoolClassRepo.GetSchoolClassBy(typeOfEducationID).ToListAsync();
                    return Ok(schoolClasses.Select(entity => _assambler.ToDto(entity)));
                }
                catch (Exception ex)
                {

                }
            }
            return BadRequest("Az adatok elérhetetlenek!");
        }

        [HttpGet("withouttypeofeducation")]
        public async Task<IActionResult> SelectWithoutTypeOfEducation()
        {
            List<SchoolClass>? schoolClasses = new();
            if (_schoolClassRepo != null && _assambler is not null)
            {
                try
                {
                    schoolClasses = await _schoolClassRepo.SelectWithoutTypeOfEducation().ToListAsync();
                    return Ok(schoolClasses.Select(entity => _assambler.ToDto(entity)));
                }
                catch (Exception ex)
                {

                }
            }
            return BadRequest("Az adatok elérhetetlenek!");
        }
    }
}
