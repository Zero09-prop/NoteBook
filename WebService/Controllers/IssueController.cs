﻿using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NoteBook.DataAccess.Model;
using NoteBook.DataAccess.Repository;


namespace NoteBook.WebService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class IssueController : ControllerBase
    {
        private readonly IssueRepo _db = new IssueRepo();

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Issue>>> Get()
        {
            return await _db.GetAllAsync();
        }

        // GET api/users/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Issue>> Get(int id)
        {
            Issue iss = await _db.GetOneAsync(id);
            if (iss == null)
                return NotFound();
            return new ObjectResult(iss);
        }

        // POST api/users
        [HttpPost]
        public async Task<ActionResult<Issue>> Post(Issue iss)
        {
            if (iss == null)
            {
                return BadRequest();
            }

            _db.AddAsync(iss);
            await _db.SaveChangesAsync();
            return Ok(iss);
        }

        // PUT api/users/
        [HttpPut]
        public async Task<ActionResult<Issue>> Put(Issue iss)
        {
            if (iss == null)
            {
                return BadRequest();
            }
            if (_db.GetOneAsync(iss.Id).Result == null)
            {
                return NotFound();
            }

            _db.Update(iss);
            await _db.SaveChangesAsync();
            return Ok(iss);
        }

        // DELETE api/users/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Issue>> Delete(int id)
        {
            Issue iss = _db.GetOneAsync(id).Result;
            if (iss == null)
            {
                return NotFound();
            }
            _db.Delete(iss);
            await _db.SaveChangesAsync();
            return Ok(iss);
        }
    }
}