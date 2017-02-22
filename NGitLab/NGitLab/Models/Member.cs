using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace NGitLab.Models
{
    [DataContract]
    public class Member
    {
        [DataMember(Name = "id")]
        public int Id;

        [DataMember(Name = "username")]
        public string Username;

        [DataMember(Name = "name")]
        public string Name;

        [DataMember(Name = "state")]
        public string State;

        [DataMember(Name = "created_at")]
        public DateTime CreatedAt;

        [DataMember(Name = "access_level")]
        public int AccessLevel;

    }
}
