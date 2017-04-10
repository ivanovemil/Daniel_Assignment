using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailGET.Models
{
    interface EmailInterface
    {
        IEnumerable<EmailModel> GetAll();
        EmailModel GetEmail(int _id);
    }
}
