using System;

namespace Contacts.EfStuff.DbModel
{
    public class Contact : BaseModel
    {
        public string Name { get; set; }
        public string MobilePhone { get; set; }
        public string JobTitle { get; set; }
        public DateTime BirthDay { get; set; }
    }
}
