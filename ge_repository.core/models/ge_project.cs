using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace ge_repository.core.models {
   
    public class ge_project : _ge_location {
        public Guid Id {get;set;}
        [Display(Name = "Project Name")] [StringLength(255)] public string name{get;set;}
        [Display(Name = "Project Description")][StringLength(255)] public string description {get;set;}
        [Display(Name = "Keywords")] [StringLength(255)] public string keywords{get;set;}
        [Display(Name = "Project Start Date")] public DateTime start_date{get;set;}
        [Display(Name = "Project End Date")] public DateTime? end_date {get;set;}
        [Display(Name ="Home Page")] public Guid? homepageId {get;set;}
        [Display(Name = "Confidentiality")] public Constants.ConfidentialityStatus cstatus {get;set;}
        [Display(Name = "Publish Status")] public Constants.PublishStatus pstatus {get;set;}
        [Display(Name = "Project Data Manager")]  [StringLength(450)] public string managerId {get;set;}
        [Display(Name = "Version Expression")] [ StringLength(255)] public string verex {get;set;}
        [Display(Name = "Other Database Connections")] public Guid? otherDbConnectId {get;set;}
      
        [Display(Name = "Esri Connections")] public Guid? esriConnectId {get;set;}
   
        [Display(Name = "Group Id")] public Guid groupId {get;set;}
        public virtual ge_group group {get;set;}
        public virtual ICollection<ge_user_ops> users {get;set;}
        public virtual ICollection<ge_data> data { get; set; }
        public virtual ICollection<ge_transform> transform {get;set;}
        [Display(Name = "Data Operations Allowed")] [StringLength(255)] public string data_operations {get;set;}
        
    public ge_project() {
        verex = "P{0:00}.{1:00}";
    }
    }

    
    // public dbConnectDetails otherDbConnection(string DataType) {

    //         if (string.IsNullOrEmpty(otherDatabase)) {
    //             return new dbConnectDetails(DataType);
    //         }
    //         try {

    //         OtherDbConnections OtherDb = JsonConvert.DeserializeObject<OtherDbConnections>(otherDatabase);
            
    //         foreach (dbConnectDetails value in OtherDb.OtherDbConnects) {
    //             if (value.Type==DataType) {
    //                 return value;
    //             }
    //         }

    //        return new dbConnectDetails(DataType);

    //         } catch (Exception e) {
    //             return new dbConnectDetails(DataType); 
    //         }
    // }
    // public void otherDbConnection(dbConnectDetails newValue) {
    //         try {

    //         OtherDbConnections OtherDb = JsonConvert.DeserializeObject<OtherDbConnections>(otherDatabase);
            
    //      //   if (OtherDb.connections==null) {
    //      //       OtherDb.connections = new List<dbConnectDetails>();
    //      //   }

    //         foreach (dbConnectDetails value in OtherDb.OtherDbConnects) {
    //             if (value.Type==newValue.Type) {
    //                 OtherDb.OtherDbConnects.Remove(value);
    //                 break;
    //             }
    //         }
            
    //         OtherDb.OtherDbConnects.Add (newValue);
    //         otherDbConnection(OtherDb);

    //         } catch (Exception e) {
                
    //         }
    // }
    
    // public void otherDbConnection(OtherDbConnections otherDatabases) {
    //         otherDatabase  = JsonConvert.SerializeObject(otherDatabases);
    // }
    // public int? gINTProjectID() {

    //                 var gc = otherDbConnection(gINTTables.DB_DATA_TYPE);

    //                 if (gc != null) {
    //                     return gc.ProjectId;
    //                 } 

    //                 return null;
    //     }

    // public void gINTProjectID(int? value) {
                    
    //                 if (value==null) {
    //                     return;
    //                 }

    //                 var gc = otherDbConnection(gINTTables.DB_DATA_TYPE);
    //                 gc.ProjectId = value.Value;
    //                 otherDbConnection(gc);
    //     }
    // }
    
    
}
