using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ge_repository.core;
using ge_repository.core.models;
using ge_repository.core.services;

namespace ge_repository.services
{
    public class ProjectService : IProjectService
    {
        private readonly IUnitOfWork _unitOfWork;
        public ProjectService(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }

        public async Task<ge_project> CreateProject(ge_project newProject)
        {
            await _unitOfWork.Project.AddAsync(newProject);
            await _unitOfWork.CommitAsync();
            return newProject;
        }

        public async Task DeleteProject(ge_project project)
        {
            _unitOfWork.Project.Remove(project);
            await _unitOfWork.CommitAsync();
        }

        public async Task<IEnumerable<ge_project>> GetAllWithGroup()
        {
            return await _unitOfWork.Project
                .GetAllWithGroupAsync();
        }

        public async Task<ge_project> GetProjectById(Guid id)
        {
            return await _unitOfWork.Project
                .GetByIdAsync(id);
        }

        public async Task<IEnumerable<ge_project>> GetProjectByGroupId(Guid groupId)
        {
            return await _unitOfWork.Project
                .GetAllWithGroupIdAsync(groupId);
        }

        public async Task UpdateProject(ge_project from, ge_project to)
        {
            to.name = from.name;
            to.managerId = from.managerId;

            await _unitOfWork.CommitAsync();
        }
    }
}