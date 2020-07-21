using System.Linq;

namespace mvc_Migration.Models
{
    public interface IEmailRepository
    {
        IQueryable<Email> Emails {get;}
    }
}
