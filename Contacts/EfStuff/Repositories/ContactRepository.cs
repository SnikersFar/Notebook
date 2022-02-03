using Contacts.EfStuff.DbModel;

namespace Contacts.EfStuff.Repositories
{
    public class ContactRepository : BaseRepository<Contact>
    {
        public ContactRepository(WebContext webContext) : base(webContext)
        {
        }
    }
}
