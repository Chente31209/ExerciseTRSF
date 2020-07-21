using System.Linq;

namespace mvc_Migration.Models
{
    public class EmaliRepository:IEmailRepository
    {
         private EmailContext context;
        public EmaliRepository(EmailContext ctx) {
            context = ctx;
        }

        public IQueryable<Email> Emails {get {
            return context.Emails;
        }}
    }
}