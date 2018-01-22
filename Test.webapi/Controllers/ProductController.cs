using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Test.DTO;
using Test.Entity.Models;
using Test.Repostory;

namespace Test.webapi.Controllers
{
    public class ProductController : BaseController<ProductRepsotory,Product,ProductDTO>
    {
    }
}
