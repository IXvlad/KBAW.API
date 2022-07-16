using System.Collections.Generic;

namespace KBAW.DataAccess.ApplicationDb;

public class DatabaseOptions
{
    public IDictionary<string, string> ConnectionStrings { get; set; }
}