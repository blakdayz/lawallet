// Decompiled with JetBrains decompiler
// Type: LaWallet.Common.Features.Licenses.LicenseRendererContract
// Assembly: LaWallet.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6C53008C-F244-4870-B273-86A700706661
// Assembly location: C:\Users\isphelp\Documents\lawallet\assemblies\LaWallet.Common.dll

using LaWallet.Common.Features.Rendering;
using System;
using System.Collections.Generic;

namespace LaWallet.Common.Features.Licenses
{
  public class LicenseRendererContract
  {
    public string DriversLicenseNumber { get; set; }

    public LouisianaCredential LouisianaCredential { get; set; }

    public string AuditNumber { get; set; }

    public string FirstName { get; set; }

    public string MiddleName { get; set; }

    public string LastName { get; set; }

    public string Suffix { get; set; }

    public DateTime DateOfBirth { get; set; }

    public string AddressLine1 { get; set; }

    public string AddressLine2 { get; set; }

    public string City { get; set; }

    public string State { get; set; }

    public string ZipCode { get; set; }

    public string County { get; set; }

    public string SexType { get; set; }

    public string Height { get; set; }

    public string Weight { get; set; }

    public string EyeColor { get; set; }

    public bool IsMinor { get; set; }

    public bool IsOrganDonor { get; set; }

    public bool IsVeteran { get; set; }

    public string LicenseClass { get; set; }

    public bool IsSexOffender { get; set; }

    public bool IsCajun { get; set; }

    public bool IsHardship { get; set; }

    public bool IsRealID { get; set; }

    public bool IsDuplicate { get; set; }

    public bool IsLimitedTerm { get; set; }

    public LicenseDocumentContract LicenseDocument { get; set; }

    public List<LicenseMediaContract> LicenseMedia { get; set; }

    public List<LicenseEndorsementContract> LicenseEndorsements { get; set; }

    public List<LicenseRestrictionContract> LicenseRestrictions { get; set; }

    public bool IsHandicap
    {
      get
      {
        return false;
      }
    }

    public bool IsSeatBeltExempt
    {
      get
      {
        return false;
      }
    }

    public bool IsUndocumentedAlien
    {
      get
      {
        return false;
      }
    }

    public LicenseRendererContract()
    {
      this.LicenseMedia = new List<LicenseMediaContract>();
      this.LicenseEndorsements = new List<LicenseEndorsementContract>();
      this.LicenseRestrictions = new List<LicenseRestrictionContract>();
      this.LouisianaCredential = new LouisianaCredential(LouisianaCredentialType.Unknown, Orientation.Landscape);
    }
  }
}
