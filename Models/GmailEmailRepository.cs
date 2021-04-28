using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SilentAthleticsWebApp.Models
{
    public class GmailEmailRepository
    {

        string emailAccount = System.Environment.GetEnvironmentVariable("SilentAthleticsEmailAccount");
        string emailPassword = System.Environment.GetEnvironmentVariable("AccountCorrespondence");
    }
}
