using System.Runtime.Serialization;

namespace ThisData.Models
{
    [DataContract]
    public class UserDetails
    {
        [DataMember(Name = "id")]
        public string Id { get; set; }

        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "email")]
        public string Email { get; set; }        
    }
}