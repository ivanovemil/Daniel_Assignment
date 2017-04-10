using EmailGET.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Newtonsoft.Json;


namespace EmailGET.Controllers
{

    public class EmailController : ApiController
    {
       static readonly EmailRepository repo = new EmailRepository();

        public IEnumerable<EmailModel> GetAllEmail()
        {
            return repo.GetAll();
        }

        public EmailModel GetEmail(int emailId)
        {
           EmailModel emailItem = repo.GetEmail(emailId);


            if (emailItem == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            return emailItem;
        }

        static void Main(string[] args)
        {
            using (WebClient wc = new System.Net.WebClient())
            {
                WebClient n = new WebClient();
                var json = n.DownloadString("https://bitbucket.org/!api/2.0/snippets/isave/7Ar7z/50f6885a7a2f603218411b29c3182c4ecd591472/files/Emails.json");
                string valueOriginal = Convert.ToString(json);

            }
        }

    }


}
