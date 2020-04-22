using CS321_W4D1_BookAPI.Models;
using System.Collections.Generic;

namespace CS321_W4D1_BookAPI.Services
{
    public interface IPublisherService
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
