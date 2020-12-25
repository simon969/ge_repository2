    
    public static class Constants
    {
        public static readonly string CreateOperationName = "Create";
        public static readonly string ReadOperationName = "Read";
        public static readonly string UpdateOperationName = "Update";
        public static readonly string DeleteOperationName = "Delete";
        public static readonly string ApproveOperationName = "Approve";
        public static readonly string RejectOperationName = "Reject";
        public static readonly string DownloadOperationName = "Download";
        public static readonly string AdminOperationName = "Admin";
        public static readonly string ge_repositoryAdministratorRole = "ge_administrator";
        public static readonly string ge_repositoryManagerRole = "ge_manager";
        public static readonly string ge_repositoryProjectRole = "ge_project";

        
/*         public enum PublishStatus {
        UncontrolledPrivate,
        UncontrolledOffice,
        UncontrolledProject,
        ApprovedOffice,
        ApprovedProject
        } */
        public enum PublishStatus {
        Uncontrolled,
        Approved
        
        }
        
        public enum ConfidentialityStatus {
        Owned,
        RequiresClientApproval,
        ThirdParty,
        ClientApproved
        }
        public enum QualitativeStatus {
        ThirdPartyFactual,
        ThirdPartyInterpretive,
        AECOMInterpretive,
        AECOMFactual
        }

        public enum VersionStatus {
          Final,
          Draft,
          Intermediate
        }


        // project and group user operations
        // project_user.user_operations 
        // group_user.user_operations

        public static string[] CRUDDAA_OperationsArray = new string[] {
                                          "Read",
                                          "Read;Download",
                                          "Create;Read;Download",
                                          "Create;Read;Update;Download",
                                          "Create;Read;Update;Download;Delete",
                                          "Create;Read;Update;Download;Delete;Approve;Admin"};
         public static string[] CRUDDAA_OperationsArrayIndividual = new string[] {
                                          "Create","Read","Update","Download","Delete","Admin","Approve"};
        // group and project record operations
        //      ge_group.operation
        //      ge_project.operation
        public static string[] RUD_OperationsArray = new string[] {
                                          "Read",
                                          "Read;Update",
                                          "Read;Update;Delete"}; 
        // data record operations
        //      ge_data.operation 
        public static string[] RUDD_OperationsArray = new string[] {
                                          "Read",
                                          "Read;Download",
                                          "Read;Download;Update",
                                          "Read;Download;Update;Delete"}; 
        
        // project data operations
        //      ge_project.data_operation
       
        public static string[] CRUDD_OperationsArray = new string[] {
                                          "Read",
                                          "Read;Download",
                                          "Create;Read;Download",
                                          "Create;Read;Update;Download",
                                          "Create;Read;Update;Download;Delete"};
        // project operations
        // ge_group.project_operations
        public static string[] CRUD_OperationsArray = new string[] {
                                          "Read",
                                          "Create;Read",
                                          "Create;Read;Update;",
                                          "Create;Read;Update;Delete"};
        
        
        public static int ReadDownloadUpdateDelete  = 3;
        public static int ReadDownloadUpdate  = 2;
        public static int ReadDownload  = 1;
        public static int Read  = 0;

        public enum datumProjection {
       
        // No assigned projection system
        NONE = 0, 
        
        // http://spatialreference.org/ref/epsg/osgb-1936-british-national-grid/  
        // OSGB 1936 British National Grid"  
        OSGB36NG = 27700,
        OSGB36NGODN = 7405,
        
        // WGS84 is used by multiple spacial reference systems
        //http://spatialreference.org/ref/?search=WGS84&srtext=Search
         WGS84 = 101,
        
        // GRS80 is used by multiple spacial reference systems
        //http://spatialreference.org/ref/?search=GRS80&srtext=Search
        GRS80 = 102
      }
  }
      public enum logLEVEL {
        Info,
        Warning,
        Error,
        Fatal
      }
    public static class pflagCODE {
         public const int NORMAL = 0;
         public const int PROCESSING = -1;
    }


      
      public static class msgCODE {

        public const int DATA_UPDATE_USER_PROHIBITED = 102;
        public const int DATA_STATUS_USER_PROHIBITED = 108;
        public const int DATA_READ_USER_PROHIBITED = 103;
        public const int DATA_CREATE_USER_PROHIBITED = 104;
        public const int DATA_DELETE_USER_PROHIBITED = 107;
        public const int DATA_DOWNLOAD_USER_PROHIBITED = 109;
        public const int DATA_OPERATION_UPDATE_PROHIBITED = 111;
        public const int DATA_UPDATE_PROHIBITED = 112;
        public const int DATA_STATUS_PROHIBITED = 118;
        public const int DATA_READ_PROHIBITED = 113;
        public const int DATA_CREATE_PROHIBITED = 114;
        public const int DATA_DELETE_PROHIBITED = 117;
        public const int DATA_DOWNLOAD_PROHIBITED = 119;


        public const int PROJECT_OPERATION_CREATE_ADMINREQ = 501;
        public const int PROJECT_OPERATION_UPDATE_ADMINREQ = 502;
        public const int PROJECT_OPERATION_DELETE_ADMINREQ = 503;
        public const int PROJECT_OPERATION_UPDATE_MINADMIN = 504;
        public const int PROJECT_OPERATION_CREATE_USEREXITS = 505;

        public const int PROJECT_UPDATE_USER_PROHIBITED = 202;
        public const int PROJECT_READ_USER_PROHIBITED = 203;
        public const int PROJECT_APPROVE_USER_PROHIBITED = 204;
        public const int PROJECT_CREATE_USER_PROHIBITED = 205;
        public const int PROJECT_DELETE_USER_PROHIBITED = 207;
        public const int PROJECT_UPDATE_PROHIBITED = 212;
        public const int PROJECT_READ_PROHIBITED = 213;
        public const int PROJECT_APPROVE_PROHIBITED = 214;
        public const int PROJECT_CREATE_PROHIBITED = 215;
        public const int PROJECT_DELETE_PROHIBITED = 217;
        public const int GROUP_OPERATION_READ_ADMINREQ = 321;
        public const int GROUP_OPERATION_CREATE_ADMINREQ = 322;
        public const int GROUP_OPERATION_UPDATE_ADMINREQ = 323;
        public const int GROUP_OPERATION_DELETE_ADMINREQ = 324;
        public const int GROUP_OPERATION_UPDATE_MINADMIN = 325;
        public const int GROUP_OPERATION_CREATE_USEREXITS = 326;
        public const int GROUP_OPERATION_USERNOTEXIST = 327;
        public const int GROUP_READ_USER_PROHIBITED = 301;
        public const int GROUP_CREATE_USER_PROHIBITED = 302;
        public const int GROUP_UPDATE_USER_PROHIBITED = 303;
        public const int GROUP_DELETE_USER_PROHIBITED = 304;
        public const int GROUP_READ_PROHIBITED = 311;
        public const int GROUP_CREATE_PROHIBITED = 312;
        public const int GROUP_UPDATE_PROHIBITED = 313;
        public const int GROUP_DELETE_PROHIBITED = 314;
        public const int GROUP_NOT_EMPTY = 315;
        public const int USER_CREATE_NOTFOUND = 601;
        public const int USER_OPS_CREATE_AMBIGUOUS = 602;
        public const int USER_OPS_NOTFOUND = 603;
        public const int USER_NOTFOUND = 604;
        public const int TRANSFORM_READ_PROHIBITED= 401; 
        public const int TRANSFORM_READ_USER_PROHIBITED = 411; 
        public const int TRANSFORM_CREATE_PROHIBITED= 402; 
        public const int TRANSFORM_CREATE_USER_PROHIBITED = 412; 
        public const int TRANSFORM_UPDATE_PROHIBITED= 403; 
        public const int TRANSFORM_UPDATE_USER_PROHIBITED = 413; 
        public const int TRANSFORM_DELETE_PROHIBITED= 404; 
        public const int TRANSFORM_DELETE_USER_PROHIBITED = 414; 

        public const int TRANSFORM_NO_MATCHING = 431; 
        public const int TRANSFORM_AGS_NONE = 441; 
        public const int TRANSFORM_NOT_COMPATIBLE = 432;

        public const int TRANSFORM_RUN_STOREDPROCEDURE_NOTSUCCESSFULL = 433;
        public const int TRANSFORM_RUN_STOREDPROCEDURE_SUCCESSFULL = 434;

        public const int AGS_UNKNOWN_FILE = 801; 
        public const int AGS_PROCESSING_FILE = 802; 
        public const int AGS_NOTCONNECTED = 803;
        public const int XML_NOTRECEIVED = 804;
        public const int AGS_SENDFAILED = 805;

        public const int GIS_CREATE_UNSUCCESSFULL = 1001;
        public const int GIS_UNEXPECTEDFORMAT = 1002;

        public const int ESRI_NO_VALID_CONNECTION = 2001;

      }