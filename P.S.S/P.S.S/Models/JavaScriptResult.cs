using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace P.S.S.Models
{
    internal class JavaScriptResult : ContentResult
    {
        public JavaScriptResult(string script)
        {
            this.Content = script;
            this.ContentType = "application/javascript";
        }
    }
}
