//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ChatApp.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class GroupChatRoom
    {
        public int Id { get; set; }
        public int GroupId { get; set; }
        public int UserId { get; set; }
        public string GroupName { get; set; }
        public Nullable<System.DateTime> LastModified { get; set; }
    }
}