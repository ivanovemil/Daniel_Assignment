using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmailGET.Models
{
    public class EmailRepository : EmailInterface
    {
    
        private List<EmailModel> email = new List<EmailModel>();
   
        public EmailModel GetEmail(int emailId)
        {
            return email.Find(e => e._id == emailId);
        }

        public IEnumerable<EmailModel> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}