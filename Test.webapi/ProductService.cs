using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Test.DTO;
using Test.Entity.Models;
using Test.Repostory;

namespace Test.webapi
{
    public class ProductService:ServiceBase<ProductRepsotory,Product,ProductDTO>
    {
    }
}