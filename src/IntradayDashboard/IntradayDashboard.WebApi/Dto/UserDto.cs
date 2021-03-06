using System;
using System.Collections.Generic;

namespace IntradayDashboard.WebApi.Dto
{
    public class UserDto
    {
        public string Firstname {get;set;}
        public string Lastname {get;set;}
        public string NationalIdentificationNumber {get;set;}
        public string Gender { get; set; }
        public string Guid {get;set;}
        public string KnownAs { get; set; }
        public string Phone {get;set;}
        public DateTime DateOfBirth { get; set; }
        public DateTime LastEnterance { get; set; }
        public string Title {get;set;}
        public ICollection<UserRoleDto> UserRoles {get;set;}
        public int TenantId { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public string DeletedBy { get; set; }
        public DateTime? DeletedOn { get; set; }
    }
}