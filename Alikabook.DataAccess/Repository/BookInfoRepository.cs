﻿using Alikabook.DataAccess.Data;
using Alikabook.DataAccess.Repository.IRepository;
using Alikabook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Alikabook.DataAccess.Repository
{
    public class BookInfoRepository : Repository<BookInfo>, IBookInfoRepository
    {
        private ApplicationDbContext _db;

        public BookInfoRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(BookInfo obj)
        {
            _db.BookInfos.Update(obj);
        }
    }
}
