//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace dotNetDemo.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;

    public partial class UserInfo
    {
        public int UserId { get; set; }
        //[DisplayName("zhanghao")]
        [Required(ErrorMessage ="This Field is Required")]
        public string Account { get; set; }
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "This Field is Required")]
        public string Password { get; set; }
        public System.DateTime LogInTime { get; set; }
        public string LogInIP { get; set; }
        public int Authority { get; set; }
        public string LogInErrorMsg { get; set; }
    }
}