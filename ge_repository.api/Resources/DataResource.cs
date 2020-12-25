namespace ge_repository.api.resources
{
    public class DataResource
    {
        public int Id { get; set; }
        public string FileName { get; set; }
        
        public ProjectResource Project { get; set; }
    } 
}