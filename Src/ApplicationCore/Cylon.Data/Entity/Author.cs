﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Cylon.Data.Entity
{
    public class Author : BaseEntity
    {
        public string FirstName
        {
            get;
            set;
        }
        public string LastName
        {
            get;
            set;
        }
        public string Email
        {
            get;
            set;
        }
        public virtual ICollection<Book> Books
        {
            get;
            set;
        }
    }
}
