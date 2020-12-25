using AutoMapper;
using ge_repository.api.resources;
using ge_repository.core.models;

namespace ge_repository.api.mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // Domain to Resource
            CreateMap<ge_data, DataResource>();
            CreateMap<ge_project, ProjectResource>();
            
            // Resource to Domain
            CreateMap<DataResource, ge_data>();
            CreateMap<SaveDataResource, ge_data>();
            CreateMap<ProjectResource, ge_project>();
            CreateMap<SaveProjectResource, ge_data>();
        }
    }
}