using System;
using System.Collections.Generic;
using System.Text;

namespace ICE.SDKtoAPI.LenderApiContractsV1
{
    public class Role
    {
        public string RoleName { get; set; }
        public string RoleId { get; set; }
        public string Id { get; set; }
        public bool? WriteAccess { get; set; }
        public string Abbreviation { get; set; } = string.Empty;
        public string MilestoneId { get; set; }
        public string MilestoneType { get; set; }
        public string MilestoneName { get; set; }
        public bool? Required { get; set; }
    }
    public class RoleExtended
    {
        public bool Protected { get; set; }
        public string RoleAbbr { get; set; }
        public int RoleId { get; set; }
        public string RoleName { get; set; }
        public List<RolePersona> Personas { get; set; }
        //"userGroups": []
    }
    public class RolePersona
    {
        public string Name { get; set; }
        public int Id { get; set; }
    }
}
