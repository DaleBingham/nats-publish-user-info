namespace nats_publish_user_info.Models
{
    public class User : BaseClass
    {
        public User () {

        }
        public string FirstName {get;set;}
        public string LastName {get;set;}
        public string Address {get;set;}
        public string City {get;set;}
        public string State {get;set;}
        public string ZIP {get;set;}
        public string Email  {get;set;}
        public string Twitter {get;set;}
        public string Facebook {get;set;}
        public string SnapChat {get;set;}
        public string Instagram {get;set;}
    }
}