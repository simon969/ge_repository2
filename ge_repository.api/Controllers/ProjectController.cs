using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

using ge_repository.api.resources;
using ge_repository.api.validations;
using ge_repository.core.models;
using ge_repository.core.services;

namespace ge_repository.api.controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectController : ControllerBase
    {
        private readonly IProjectService _projectService;
        private readonly IMapper _mapper;
        
        public ProjectController(IProjectService projectService, IMapper mapper)
        {
            this._mapper = mapper;
            this._projectService = projectService;
        }

        [HttpGet("")]
        public async Task<ActionResult<IEnumerable<ProjectResource>>> GetAllProjects()
        {
            var projects = await _projectService.GetAllWithGroup();
            var projectResources = _mapper.Map<IEnumerable<ge_project>, IEnumerable<ProjectResource>>(projects);

            return Ok(projectResources);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ProjectResource>> GetProjectById(Guid Id)
        {
            var project = await _projectService.GetProjectById(Id);
            var projectResource = _mapper.Map<ge_project, ProjectResource>(project);

            return Ok(projectResource);
        }

        [HttpPost("")]
        public async Task<ActionResult<ProjectResource>> CreateProject([FromBody] SaveProjectResource saveProjectResource)
        {
            var validator = new SaveProjectResourceValidator();
            var validationResult = await validator.ValidateAsync(saveProjectResource);

            if (!validationResult.IsValid)
                return BadRequest(validationResult.Errors); // this needs refining, but for demo it is ok

            var projectToCreate = _mapper.Map<SaveProjectResource, ge_project>(saveProjectResource);

            var newProject = await _projectService.CreateProject(projectToCreate);

            var project = await _projectService.GetProjectById(newProject.Id);

            var projectResource = _mapper.Map<ge_project, ProjectResource>(project);

            return Ok(projectResource);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<ProjectResource>> UpdateProject(Guid id, [FromBody] SaveProjectResource saveProjectResource)
        {
            var validator = new SaveProjectResourceValidator();
            var validationResult = await validator.ValidateAsync(saveProjectResource);
            
            if (!validationResult.IsValid)
                return BadRequest(validationResult.Errors); // this needs refining, but for demo it is ok

            var projectToBeUpdated = await _projectService.GetProjectById(id);

            if (projectToBeUpdated == null)
                return NotFound();

            var project = _mapper.Map<SaveProjectResource, ge_project>(saveProjectResource);

            await _projectService.UpdateProject(projectToBeUpdated, project);

            var updatedProject = await _projectService.GetProjectById(id);

            var updatedProjectResource = _mapper.Map<ge_project, ProjectResource>(updatedProject);

            return Ok(updatedProjectResource);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteArtist(Guid id)
        {
            var project = await _projectService.GetProjectById(id);

            await _projectService.DeleteProject(project);
            
            return NoContent();
        }
    }
}