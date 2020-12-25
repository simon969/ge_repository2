using System;
using System.ComponentModel.DataAnnotations;



namespace ge_repository.core.models {

    public abstract class _ge_base {
    
        [Display(Name = "Created By")] [StringLength(450)] public string createdId {get;set;} 
        [Display(Name = "Created DateTime")] public DateTime createdDT {get;set;}
     
        [Display(Name = "Last Edited By")] [StringLength(450)] public string editedId {get;set;} 
        [Display(Name = "Last Edited DateTime")] public DateTime? editedDT {get;set;}
        [Display(Name = "Operations Allowed")] [StringLength(255)] public string operations {get;set;}
        [Display (Name = "Processing Flag")] public int pflag {get;set;}
        
    }
       



}  