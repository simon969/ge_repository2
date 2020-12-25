 
using System;
using System.ComponentModel.DataAnnotations;

 
 namespace ge_repository.core.models {

 public class ge_transform : _ge_base {
            public Guid Id {get; set;}
            public Guid? projectId {get;set;}
            public virtual ge_project project {get;set;}
            [Display(Name = "Transform name")]  public string name {get;set;}
            [Display(Name = "Transform description")]  public string description {get;set;}
            [Display(Name = "Primary Xml data")]  public Guid? dataId {get; set;}
            public virtual ge_data data {get;set;}
            [Display(Name = "Xquery query")]  public Guid? queryId {get; set;}
            public virtual ge_data query {get;set;}
            [Display(Name = "Xlst transform")]  public Guid? styleId {get; set;}
            public virtual ge_data style {get;set;}
            [Display(Name = "Additional Xml data")] public string add_data {get;set;}
            [Display(Name = "Stored Procedure")]  public string storedprocedure {get;set;}
             [Display(Name = "Web Service End Point")]  public string service_endpoint {get;set;}
            [Display(Name = "Transform parameters")] public string parameters {get;set;}
            [Display(Name = "Confidentiality")] public Constants.ConfidentialityStatus cstatus {get;set;}
            [Display(Name = "Publish Status")] public Constants.PublishStatus pstatus {get;set;}
            [Display(Name = "Qualitative Status")] public Constants.QualitativeStatus qstatus {get;set;}
            [Display(Name = "Version")] [StringLength(64)] public string version{get;set;} 
            [Display(Name = "Version Status")] public Constants.VersionStatus vstatus {get;set;}

    }
    public class ge_transform_parameters {
        public string host {get;set;}
        public string host_file {get; set;}
        public string host_view {get; set;}
        public string host_download {get; set;}
        public string host_esri {get;set;}
        public string host_logger {get;set;}
        public string host_gint {get;set;}
        public string host_transform {get;set;}
        public string user {get;set;}
        public string version {get;set;}
        public string[] projects {get; set;}
        public string[] holes {get; set;}
        public string[] tables {get; set;}
        public string[] geols {get; set;}
        public string[] options {get;set;}
        public string transformId {get;set;}
        public string projectId {get;set;}
        public string groupId {get;set;}
        public string Id {get;set;}
        public string project {get; set;}
        public string hole {get; set;}
        public string table {get; set;}
        public string geol {get; set;}
        public string flwor {get;set;}
        public string xpath {get;set;}
        public string image {get;set;}
        public string dictionary {get;set;}
        public string script {get;set;}
        public string css {get;set;}
        public string arg_vals {get;set;}

     }
 }
