
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
    
public partial class vw_RequisitionsNorms
{

    public System.Guid Id { get; set; }

    public int EmisCode { get; set; }

    public string Description { get; set; }

    public byte GrFrom { get; set; }

    public byte GrTo { get; set; }

    public System.DateTime DateFrom { get; set; }

    public System.DateTime DateTo { get; set; }

    public int MinGrade { get; set; }

    public int MaxGrade { get; set; }

    public string BookYear { get; set; }

    public int Term { get; set; }

    public string Year { get; set; }

    public string Rem_Days { get; set; }

}

}
