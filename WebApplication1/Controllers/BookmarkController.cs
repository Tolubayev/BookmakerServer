using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using Bookmaker.Models;
using Bookmaker.Filters;

namespace Bookmaker.Controllers
{
    [DataValidation]
    public class BookmarkController : ApiController
    {
        //todo: rename and use later as bookmarks getter
        [HttpGet]
        public HttpResponseMessage  Test()
        {
            return new HttpResponseMessage(HttpStatusCode.OK);
        }

        [HttpPost]
        public HttpResponseMessage Register([FromBody]BookmarkRequest data)
        {
            SaveInSession(data);
            return new HttpResponseMessage(HttpStatusCode.OK);
        }

        private void SaveInSession(BookmarkRequest data)
        {
            
            var dictionary = new Dictionary<int, BookmarkData>();
            if (System.Web.HttpContext.Current.Session[data.Identifier] != null)
            {
                var stored = System.Web.HttpContext.Current.Session[data.Identifier] as Dictionary<int, BookmarkData>;
                if (stored != null)
                {
                    dictionary = stored;
                }
            }

            dictionary.Add(data.Id, data);
            System.Web.HttpContext.Current.Session[data.Identifier] = dictionary;
        }
    }
}
