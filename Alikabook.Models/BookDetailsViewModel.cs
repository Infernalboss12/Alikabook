﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alikabook.Models
{
    public class BookDetailsViewModel
    {
        public BookInfo Book { get; set; }
        public List<BookInfo> RelatedBooks { get; set; }
        public UserBookRating? UserBookRating { get; set; }
    }
}
