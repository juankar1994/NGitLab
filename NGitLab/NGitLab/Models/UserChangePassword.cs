using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace NGitLab.Models
{
    public class UserChangePassword
    {
        [DataMember(Name = "id")]
        public int Id;
        
        [DataMember(Name = "password")]
        public string Password;
        
    }
}
