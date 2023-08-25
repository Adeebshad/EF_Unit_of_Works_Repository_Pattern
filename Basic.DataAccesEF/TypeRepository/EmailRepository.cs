﻿using Basic.Domain.Interfaces;
using Basic.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic.DataAccesEF.TypeRepository
{
    public class EmailRepository : GenericRepository<Email>, IEmailRepository
    {
        public EmailRepository(PeopleContext context) : base(context) { }
    }
}
