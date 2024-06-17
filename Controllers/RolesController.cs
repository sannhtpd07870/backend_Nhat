﻿using Microsoft.AspNetCore.Mvc;
using System.Data;
using Api_React_Fast_Food_Online.Server.Interfaces;
using Api_React_Fast_Food_Online.Server.DTOs.RolesDTO;
using Api_React_Fast_Food_Online.Server.Mappers;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Authorization;

namespace Api_React_Fast_Food_Online.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("AllowSpecificOrigin")] // Áp dụng chính sách CORS đã đăng ký
    public class RolesController : ControllerBase
    {
        private readonly RolesInterface _rolesInterface;
        public RolesController(RolesInterface rolesInterface)
        {
            _rolesInterface = rolesInterface;
        }


        // GET: api/Roles
        //[Authorize] 
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var roles = await _rolesInterface.GetAllAsync();
            var roleDto = roles.Select(r => r.ToRoleDto());
            return Ok(roleDto);
        }
        // GET: api/Roles/5 
        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetById([FromRoute] int id)
        {
            var role = await _rolesInterface.GetByIdAsync(id);
            if (role == null)
            {
                return NotFound();
            }
            return Ok(role.ToRoleDto());
        }

        // PUT: api/Roles/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut]
        [Route("{id:int}")]
        public async Task<IActionResult> Update([FromRoute] int id, [FromBody] UpdateRolesRequersDto updateDto)
        {
            if (id <= 0)
            {
                return BadRequest("Invalid id");
            }

            var roleModel = await _rolesInterface.UpdateAsync(id, updateDto);

            if (roleModel == null)
            {
                return NotFound();
            }
            return Ok(roleModel.ToRoleDto());
        }

        // POST: api/Roles
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //[DisableCors]
        [HttpPost]
        //[Authorize]
        public async Task<IActionResult> Create([FromBody] CreateRolesRequersDto roleDto)
        {
            var roleModel = roleDto.ToRoleFromCreateDto();
            await _rolesInterface.CreateAsync(roleModel);
            Console.WriteLine("lỗi mọe gì thế");
            return CreatedAtAction(nameof(GetById), new { id = roleModel.Id }, roleModel.ToRoleDto());
            

        }

        // DELETE: api/Roles/5
        [Authorize]
        [HttpDelete]
        [Route("{id:int}")]
        public async Task<IActionResult> Delete([FromRoute] int id)
        {
            var roleModel = await _rolesInterface.DeleteAsync(id);
            if (roleModel == null)
            {
                return NotFound();
            }
            return NoContent();
        }
    }
}
