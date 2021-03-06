﻿using System.Collections.Generic;
using CS321_W4D1_BookAPI.Models;

namespace CS321_W4D1_BookAPI.Services
{
    public interface IBookService
    {
        // CRUDL - create (add), read (get), update, delete (remove), list

        // create
        Book Add(Book todo); 
        // read
        Book Get(int id);
        // update
        Book Update(Book todo); 
        // delete
        void Remove(Book todo);
        // list
        IEnumerable<Book> GetAll();
        //list author's books
        IEnumerable<Book> GetBooksForAuthor(int authorId);
        //list publisher's books
        IEnumerable<Book> GetBooksForPublisher(int publisherId);

    }
}
