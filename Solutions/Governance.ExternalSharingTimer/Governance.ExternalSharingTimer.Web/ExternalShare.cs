//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Governance.ExternalSharingTimer.Web
{
    using System;
    using System.Collections.Generic;
    
    public partial class ExternalShare
    {
        public int Id { get; set; }
        public System.Guid UniqueIdentifier { get; set; }
        public string SiteCollectionUrl { get; set; }
        public string LoginName { get; set; }
        public string InvitedBy { get; set; }
        public System.DateTime OriginalSharedDate { get; set; }
        public Nullable<System.DateTime> RefreshSharedDate { get; set; }
        public Nullable<System.DateTime> LastProcessedDate { get; set; }
        public int UserId { get; set; }
    }
}
