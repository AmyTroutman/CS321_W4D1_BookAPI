﻿using CS321_W4D1_BookAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CS321_W4D1_BookAPI.Services
{
    interface IPublisherService
    {
        //create
        Publisher Add(Publisher publisher);
        //Read
        Publisher Get(int id);
        //Update
        Publisher Update(Publisher publisher);
        //delete
        void Remove(Publisher publisher);
        //list
        IEnumerable<Publisher> GetAll();
    }
}
