﻿using BookSocial.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookSocial.DataAccess.DataAccessInterface
{
    public interface IBookRepository : IRepository<Book>
    {

    }
}