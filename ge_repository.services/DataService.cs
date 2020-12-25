using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ge_repository.core;
using ge_repository.core.models;
using ge_repository.core.services;

namespace ge_repository.services
{
    public class DataService : IDataService
    {
        private readonly IUnitOfWork _unitOfWork;
        public DataService(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }

        public async Task<ge_data> CreateData(ge_data newData)
        {
            await _unitOfWork.Data.AddAsync(newData);
            await _unitOfWork.CommitAsync();
            return newData;
        }

        public async Task DeleteData(ge_data data)
        {
            _unitOfWork.Data.Remove(data);
            await _unitOfWork.CommitAsync();
        }

        public async Task<IEnumerable<ge_data>> GetAllWithProject()
        {
            return await _unitOfWork.Data
                .GetAllWithProjectAsync();
        }

        public async Task<ge_data> GetDataById(Guid id)
        {
            return await _unitOfWork.Data
                .GetByIdAsync(id);
        }

        public async Task<IEnumerable<ge_data>> GetDataByProjectId(Guid projectId)
        {
            return await _unitOfWork.Data
                .GetAllByProjectIdAsync(projectId);
        }

        public async Task UpdateData(ge_data dataToBeUpdated, ge_data data)
        {
            dataToBeUpdated.filename = data.filename;
            dataToBeUpdated.filesize = data.filesize;

            await _unitOfWork.CommitAsync();
        }
    }
}