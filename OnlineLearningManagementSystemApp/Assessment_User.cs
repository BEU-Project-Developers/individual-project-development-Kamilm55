//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OnlineLearningManagementSystemApp
{
    using System;
    using System.Collections.Generic;
    
    public partial class Assessment_User
    {
        public long AssessmentUserID { get; set; }
        public long UserID { get; set; }
        public long AssessmentID { get; set; }
        public string Grade { get; set; }
    
        public virtual Assessment Assessment { get; set; }
        public virtual User User { get; set; }
    }
}