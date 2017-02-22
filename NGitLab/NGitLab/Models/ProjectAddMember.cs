using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace NGitLab.Models
{
    [DataContract]
    public class ProjectAddMember
    {
        [Required]
        [DataMember(Name = "id")]
        public int Id;
        
        [Required]
        [DataMember(Name = "user_id")]
        public int UserID;
        
        [Required]
        [DataMember(Name = "access_level")]
        public AccessLevel AccessLevel;

        [DataMember(Name = "expires_at")]
        public string ExpiresAt;
    }
}
