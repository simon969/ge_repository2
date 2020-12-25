using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace ge_repository.core.models{
    public class ge_user  {
        public string Id {get; set;}
        public string Email {get; set;}

        [Display(Name = "First Name")] public string FirstName { get; set; }
        [Display(Name = "Last Name")] public string LastName { get; set; }
        [Display(Name = "Last Logged in")] public DateTime LastLoggedIn {get;set;}

      //  public virtual ICollection<ge_user_ops> user_ops {get;set;} 

   public ge_user()  { }       
   public ge_user (string firstName, string lastName, string email, string phoneNumber) {
       
        Email = email.ToLower();
        FirstName = firstName;
        LastName =lastName;
    }

   [Display (Name="Full Name")] public String FullName () {
        return (FirstName + " " + LastName);

    }

 }

 
 }