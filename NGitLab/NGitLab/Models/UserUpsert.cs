using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace NGitLab.Models
{
    [DataContract]
    public class UserUpsert
    {
        
        [Required]
        [DataMember(Name = "email")]
        public string Email;

        [Required]
        [DataMember(Name = "password")]
        public string Password;

        [Required]
        [DataMember(Name = "username")]
        public string Username;

        [Required]
        [DataMember(Name = "name")]
        public string Name;

        [DataMember(Name = "organization")]
        public string Organization;

        [DataMember(Name = "projects_limit")]
        public int ProjectsLimit;

        [DataMember(Name = "admin")]
        public bool IsAdmin;

        [DataMember(Name = "can_create_group")]
        public bool CanCreateGroup;

        [DataMember(Name = "skip_confirmation")]
        public bool SkipConfirmation;

        [DataMember(Name = "reset_password")]
        public bool ResetPassword;
    }
}