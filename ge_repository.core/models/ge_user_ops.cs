using System;
using System.ComponentModel.DataAnnotations;


namespace ge_repository.core.models{

public class ge_user_ops : _ge_base {
    public Guid Id {get;set;}
    [Display(Name="User Id")] public Guid userId{get;set;} 
    virtual public ge_user user {get;set;}
    [Display(Name ="User Operations")] public string user_operations {get;set;}
     [Display(Name="Project Id")] public Guid? projectId{get;set;} 
    virtual public ge_project project {get;set;}
    [Display(Name="Group Id")] public Guid? groupId{get;set;} 
    virtual public ge_group group {get;set;}        
     public Boolean AddOperations(string operations) {
        string[] ops = operations.Split (";");
        foreach (var op in ops) {
            if (IsValidOperation(op) && !operations.Contains (op)) {
                operations += ";" + op;
            }
        }
        
        return false;
      }

      private Boolean IsValidOperation(string op) {
          
         if (op == Constants.CreateOperationName ||
                op == Constants.ReadOperationName   ||
                op == Constants.UpdateOperationName ||
                op == Constants.DeleteOperationName ||
                op == Constants.DownloadOperationName ||
                op == Constants.RejectOperationName ||
                op == Constants.ApproveOperationName) {
                    return true;
                }
        return false;
     }

       public Boolean HasOperation(string op) {
           return operations.Contains(op);
       } 
       

 }
}
