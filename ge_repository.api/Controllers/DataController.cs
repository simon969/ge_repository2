using AutoMapper;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ge_repository.api.resources;
using ge_repository.api.validations;
using ge_repository.core.models;
using ge_repository.core.services;

namespace ge_repository.api.controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DataController : ControllerBase
    {
        private readonly IDataService _dataService;
        private readonly IMapper _mapper;
        
        public DataController(IDataService dataService, IMapper mapper)
        {
            this._mapper = mapper;
            this._dataService = dataService;
        }

        [HttpGet("")]
        public async Task<ActionResult<IEnumerable<DataResource>>> GetAllData()
        {
            var data = await _dataService.GetAllWithProject();
            var dataResources = _mapper.Map<IEnumerable<ge_data>, IEnumerable<DataResource>>(data);

            return Ok(dataResources);
        }

        [HttpGet("{Id}")]
        public async Task<ActionResult<DataResource>> GetDataById(Guid Id)
        {
            var data = await _dataService.GetDataById(Id);
            var dataResource = _mapper.Map<ge_data, DataResource>(data);

            return Ok(dataResource);
        }

        [HttpPost("")]
        public async Task<ActionResult<DataResource>> CreateData([FromBody] SaveDataResource saveDataResource)
        {
            var validator = new SaveDataResourceValidator();
            var validationResult = await validator.ValidateAsync(saveDataResource);

            if (!validationResult.IsValid)
                return BadRequest(validationResult.Errors); // this needs refining, but for demo it is ok

            var dataToCreate = _mapper.Map<SaveDataResource, ge_data>(saveDataResource);

            var newData = await _dataService.CreateData(dataToCreate);

            var data = await _dataService.GetDataById(newData.Id);

            var dataResource = _mapper.Map<ge_data, DataResource>(data);

            return Ok(dataResource);
        }

        [HttpPut("{Id}")]
        public async Task<ActionResult<DataResource>> UpdateMusic(Guid Id, [FromBody] SaveDataResource saveDataResource)
        {
            var validator = new SaveDataResourceValidator();
            var validationResult = await validator.ValidateAsync(saveDataResource);
            
            var requestIsInvalid = Id != Guid.Empty || !validationResult.IsValid;

            if (requestIsInvalid)
                return BadRequest(validationResult.Errors); // this needs refining, but for demo it is ok
            
            var dataToBeUpdate = await _dataService.GetDataById(Id);

            if (dataToBeUpdate == null)
                return NotFound();

            var music = _mapper.Map<SaveDataResource, ge_data>(saveDataResource);

            await _dataService.UpdateData(dataToBeUpdate, music);

            var updatedMusic = await _dataService.GetDataById(Id);
            var updatedMusicResource = _mapper.Map<ge_data, DataResource>(updatedMusic);
    
            return Ok(updatedMusicResource);
        }

        [HttpDelete("{Id}")]
        public async Task<IActionResult> DeleteData(Guid Id)
        {
            if (Id == Guid.Empty)
                return BadRequest();
            
            var data = await _dataService.GetDataById(Id);

            if (data == null)
                return NotFound();

            await _dataService.DeleteData(data);

            return NoContent();
        }
    }
}