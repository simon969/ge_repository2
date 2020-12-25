using System;
using ge_repository.core.models;

public class ge_config

{
    public string[] libraryProjectId {get; set; }
    public string inviteUserPassword {get; set;}
    public string defaultAGSversion {get;set;}
    public long defaultMaxFileSize {get;set;}
    public string defaultEFDBTimeOut {get;set;}
    public string[] xpath_proj {get;set;}
    public string[] xpath_hole {get;set;}
    public string[] xpath_geol {get;set;}
    public string[] stored_procedures {get;set;}

    public ge_transform_parameters[] transform_parameters {get;set;}
    public Guid[] templateProjectId_ToGuid (Guid? addGUID = null) {
        
        int length = length = libraryProjectId.Length;
        
        if (addGUID !=null) {
             length++;
        }
        
        Guid[] libraryGUID = new Guid[length];

        for (int i=0;i<libraryProjectId.Length;i++) {
            Guid g =  new Guid(libraryProjectId[i]);
           libraryGUID[i] = g;             
        }
        
        if (addGUID !=null) {
             libraryGUID[length-1] = addGUID.Value;
        }
        
        return libraryGUID;
    }

}


