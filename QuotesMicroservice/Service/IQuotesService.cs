﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuotesMicroservice.Service
{
    public interface  IQuotesService
    {
        public string QuotesForPolicyService(int PropertyValue, int BusinessValue, string PropertyType);
    }
}
