﻿using System;
using System.Collections.Generic;

namespace GraphQL.Models
{
    public partial class RcmClaimPatientDetail
    {
        public long ClaimId { get; set; }
        public int OrganizationId { get; set; }
        public string? PatientName { get; set; }
        public string? PatientSurnameFamilyName { get; set; }
        public string? PatientMembershipNumber { get; set; }
        public DateTime? PatientDob { get; set; }
        public string? MaritalStatus { get; set; }
        public int? VisitType { get; set; }
        public byte? PatientGender { get; set; }
        public string? NationalityId { get; set; }
        public string? PatientNationality { get; set; }
        public string? PatientFileNumber { get; set; }
        public string? Address1 { get; set; }
        public string? Address2 { get; set; }
        public string? TownCity { get; set; }
        public string? PostalCode { get; set; }
        public string? PatientMobileNo { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? PatientIdentificationNo { get; set; }
        public string? PayerPolicyNumber { get; set; }

        public virtual RcmClaim RcmClaim { get; set; } = null!;
    }
}
