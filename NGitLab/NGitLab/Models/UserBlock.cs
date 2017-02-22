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
    public class UserBlock
    {
        [Required]
        [DataMember(Name = "id")]
        public int Id;
    }
}
