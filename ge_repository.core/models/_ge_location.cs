using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace ge_repository.core.models {
    public static class limEasting {
        public const double MIN=0.0;
        public const double MAX=700000.0;
    }
    public static class limNorthing {
        public const double MIN=0.0;
        public const double MAX=1300000.0;
    }
     public static class limLongitude {
        public const double MIN=-180.0;
        public const double MAX=180.0;
     
     }
     public static class limLatitude {
        public const double MIN=-90.0;
        public const double MAX=90.0;
     
     }
    public static class limLevel {
        public const double MIN=-180.0;
        public const double MAX=180.0;
     
     }
    public static class limX {
        public const double MIN = -1e6;
        public const double MAX = 1e6;
     
     }
     public static class limY {
        public const double MIN = -1e6;
        public const double MAX = 1e6;
     
     }
     public static class limZ {
        public const double MIN = -1e6;
        public const double MAX = 1e6;
     
     }

    public abstract class _ge_location : _ge_base {
    [Display(Name = "Name")] [StringLength(255)]public string locName {get;set;}
    [Display(Name = "Address")][StringLength(255)] public string locAddress {get;set;}
    [Display(Name=  "PostCode")][StringLength(255)] public string locPostcode {get;set;}
    [Display(Name = "Map Reference")] [StringLength(255)]public string locMapReference {get;set;}
    [Display(Name = "Eastings")][Range (limEasting.MIN,limEasting.MAX)] public double? locEast{get;set;}
    [Display(Name = "Northings")][Range (limNorthing.MIN,limNorthing.MAX)] public double? locNorth{get;set;}
    [Display(Name = "Level")][Range (limLevel.MIN,limLevel.MAX)] public double? locLevel{get;set;}
    [Display(Name = "Datum Projection")] public Constants.datumProjection datumProjection {get;set;}
    [Display(Name = "Latitude")][Range (limLatitude.MIN,limLatitude.MAX)] public double? locLatitude{get;set;}
    [Display(Name = "Longitude")][Range (limLongitude.MIN,limLongitude.MAX)] public double? locLongitude{get;set;}
    [Display(Name = "Ellipsoid Height")][Range (limLongitude.MIN,limLongitude.MAX)] public double? locHeight{get;set;}

    [Display(Name = "X")][Range (limX.MIN,limX.MAX)] public double? locX{get;set;} 
    [Display(Name = "Y")][Range (limY.MIN,limY.MAX)] public double? locY{get;set;} 
    [Display(Name = "Z")][Range (limZ.MIN,limZ.MAX)] public double? locZ{get;set;}
    [Display(Name= "Folder")] [StringLength(255)] public string folder {get;set;} 
    [Display(Name= "Other Database Location Ref")] [StringLength(255)] public string locOtherDb {get;set;} 
}

}
