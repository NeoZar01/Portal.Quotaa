
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace DoE.Quota.Repositories.Data.EF
{

using System;
    using System.Collections.Generic;
    
public partial class vw_RequisitionsDashboard
{

    public int EmisCode { get; set; }

    public string BookYear { get; set; }

    public Nullable<int> Submitted { get; set; }

    public Nullable<decimal> Sub_TotalPrice { get; set; }

    public Nullable<int> InDrafts { get; set; }

    public Nullable<decimal> TotalP_InDrf { get; set; }

    public Nullable<int> Rejected { get; set; }

    public Nullable<decimal> TotalP_Reject { get; set; }

    public Nullable<int> Aprroved { get; set; }

    public Nullable<decimal> TotalP_Approved { get; set; }

}

}
