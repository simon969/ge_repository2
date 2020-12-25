using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO;
using System.Text;
using System.Collections.Generic;

namespace ge_repository.core.models {

    [Table("ge_data")]
    public partial class ge_data: _ge_location {
        public Guid Id {get;set;}
        [Display(Name = "File Name")] public string filename {get;set;}
        [Display(Name = "File Size (bytes)")]public long filesize {get;set;}
        [Display(Name = "File Extension")][StringLength(8)] public string fileext {get;set;}
        [Display(Name = "File Content Type")][StringLength(128)] public string filetype {get;set;}
        [Display(Name = "Encoding")] [StringLength(6)] public string encoding {get;set;}
        [Display(Name = "Last Modified Date")] public DateTime filedate {get;set;}
        [Display(Name = "Description")] public string description {get;set;}
        [Display(Name = "Keywords")] public string keywords{get;set;}
        [Display(Name = "Project Id")]public Guid projectId {get;set;}
        virtual public ge_project project {set;get;}
        [Display(Name = "Confidentiality")] public Constants.ConfidentialityStatus cstatus {get;set;}
        [Display(Name = "Publish Status")] public Constants.PublishStatus pstatus {get;set;}
        [Display(Name = "Qualitative Status")] public Constants.QualitativeStatus qstatus {get;set;}
        [Display(Name = "Version")] [StringLength(64)] public string version{get;set;} 
        [Display(Name = "Version Status")] public Constants.VersionStatus vstatus {get;set;}

        
       [ForeignKey("Id")]  
        public virtual ge_data_big data { get; set; }   
        
        public string GetContentType()
        {
            var types = new ge_MimeTypes();
            var ext = Path.GetExtension(filename).ToLowerInvariant();
            String type = types[ext];
            
            if (filetype!=null) {
                return filetype;
            }
            
            return type;
          
        }
        public string GetContentFieldName() {
            
            string m_type = GetContentType();

            if (m_type == "text/plain") return "data_string";
            if (m_type == "text/xml") return "data_xml";
               
            return "data_string";
       } 
       
        public string GetExtention()
        {
            return Path.GetExtension(filename).ToLowerInvariant();
        }
        public Encoding GetEncoding() {
            if (encoding =="utf-7") return Encoding.UTF7;
            if (encoding =="utf-8") return Encoding.UTF8;
            if (encoding =="utf-16") return Encoding.Unicode;
            if (encoding =="ascii") return Encoding.ASCII;
            return null;   
        }
        public Boolean SetEncoding(Encoding encode) {
            
            if (encode == null) {
                encoding ="raw";
                return true;
            }
            if (encode == Encoding.UTF7) {
                encoding = "utf-7";
                return true;
            }
            if (encode == Encoding.UTF8) {
                encoding = "utf-8";
                return true;
            }
            if (encode == Encoding.Unicode) {
                encoding = "utf-16";
                return true;
            }

            if (encode == Encoding.ASCII) {
                encoding ="ascii";
                return true;
            }


            return false;
        }
        }
    
        
    [Table("ge_data")]
    public partial class ge_data_big {
        public Guid Id {get;set;}
        public Byte[] data_binary {get;set;}
        public string data_string {get;set;}
        public string data_xml {get;set;}
        public ge_data data {get;set;}
        
       public MemoryStream getMemoryStream(Encoding encode) {

           if (data_binary != null) {
               return new MemoryStream(data_binary); 
           }
           
           if (data_string !=null && encode !=null ) {
               return new MemoryStream(encode.GetBytes(data_string)); 
           }

           if (data_xml !=null && encode !=null) {
              return new MemoryStream(encode.GetBytes(data_xml));
           }

           return null;
       }

       public void toStream (Stream response, Encoding encode) {
            using (Stream responseStream = getMemoryStream(encode))
                {
                // response.AllowWriteStreamBuffering= false;   // to prevent buffering 
                byte[] buffer = new byte[1024]; 
                int bytesRead = 0; 
                while ((bytesRead = responseStream.Read(buffer, 0, buffer.Length)) > 0)  
                { 
                        response.Write(buffer, 0, bytesRead); 
                }
                }
       }

       public String getString(Encoding encode = null) {

            
            if (data_binary != null && encode==Encoding.Unicode) {
               return System.Text.Encoding.Unicode.GetString(data_binary);
            }
            
            if (data_binary != null && encode==Encoding.UTF8) {
               return System.Text.Encoding.UTF8.GetString(data_binary);
            }
            
            if (data_binary != null && encode == null) {
               return System.Text.Encoding.Default.GetString(data_binary);
            }
            
            if (data_string !=null ) {
               return data_string; 
            }

           if (data_xml !=null) {
              return data_xml;
            }

           return null;
       }
              
    }
       
   public class ge_MimeTypes : Dictionary<string, string> 
        {

            public  ge_MimeTypes()
             {
               // Loads more at
               // https://stackoverflow.com/questions/4212861/what-is-a-correct-mime-type-for-docx-pptx-etc
               
                // Documents'
                Add (".doc", "application/msword");
                Add (".docx", "application/vnd.openxmlformats-officedocument.wordprocessingml.document");
                Add (".pdf", "application/pdf");
                Add (".dwg","application/autocad");
                Add (".dgn","application/microstation");
                Add (".dxf","application/dxf");
                Add (".gpj","application/gINT");
                Add (".glb","application/gINT");
                
                //'Slideshows'
                Add (".ppt", "application/vnd.ms-powerpoint");
                Add (".pptx", "application/vnd.openxmlformats-officedocument.presentationml.presentation");
                
                //'Data'
                Add (".xlsx", "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet");
                Add (".xltx", "application/vnd.openxmlformats-officedocument.spreadsheetml.template");
                Add (".xls", "application/vnd.ms-excel");
                Add (".xlt", "application/vnd.ms-excel");
                Add (".xla", "application/vnd.ms-excel");
              

                Add (".csv", "text/plain");
                Add (".xml", "text/xml");
                Add (".xsl", "text/xsl");
                Add (".txt", "text/plain");
                Add (".ags", "text/plain");
                Add (".rtf","text/richtext");
                Add (".kml", "application/vnd.google-earth.kml+xml");
                Add (".json", "text/json");
                
                Add (".htm", "text/html");
                Add (".html", "text/html");
                Add (".css", "text/css");
                Add (".js", "application/javascript");
                Add (".xq", "application/xquery");
                Add (".xqy", "application/xquery");

                Add (".mdb", "application/vnd.ms-access");
                Add (".accdb", "application/vnd.ms-access");
                
                //'Compressed Folders'
                Add (".zip", "application/zip");

                //'Audio'
                Add (".ogg", "application/ogg");
                Add (".mp3", "audio/mpeg");
                Add (".wma", "audio/x-ms-wma");
                Add (".wav", "audio/x-wav");
                
                //'Video'
                Add (".wmv", "audio/x-ms-wmv");
                Add (".swf", "application/x-shockwave-flash");
                Add (".avi", "video/avi");
                Add (".mp4", "video/mp4");
                Add (".mpeg", "video/mpeg");
                Add (".mpg", "video/mpeg");
                Add (".qt", "video/quicktime");

                // 'Images'
                Add (".bmp", "image/bmp");
                Add (".gif", "image/gif");
                Add (".jpeg", "image/jpeg"); 
                Add (".jpg", "image/jpeg");
                Add (".png", "image/png");
                Add (".tif", "image/tiff");
                Add (".tiff", "image/tiff");
            }
        }
    
    }
    
 


 

