﻿using QuotesMicroservice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuotesMicroservice.Repository
{
    public interface IQuotesRepo
    {
      
         public string QuotesForPolicy(int PropertyValue, int BusinessValue, string PropertyType);
 
    }
}
