using CS321_W4D1_BookAPI.Data;
using CS321_W4D1_BookAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CS321_W4D1_BookAPI.Services
{
    public class PublisherService : IPublisherService
    {
        private readonly BookContext _bookContext;

        public PublisherService(BookContext bookContext)
        {
            _bookContext = bookContext;
        }

        public Publisher Add(Publisher publisher)
        {
            _bookContext.Publishers.Add(publisher);
            _bookContext.SaveChanges();
            return publisher;
        }

        public Publisher Get(int id)
        {
            return _bookContext.Publishers.Find(id);
        }

        public IEnumerable<Publisher> GetAll()
        {
            return _bookContext.Publishers.ToList();
        }

        public Publisher Update(Publisher updatedPublisher)
        {
            var currentPublisher = _bookContext.Publishers.Find(updatedPublisher.Id);
            if (currentPublisher == null) return null;
            _bookContext.Entry(currentPublisher)
                .CurrentValues
                .SetValues(updatedPublisher);
            _bookContext.Publishers.Update(currentPublisher);
            _bookContext.SaveChanges();
            return currentPublisher;
        }

        public void Remove(Publisher publisher)
        {
            throw new NotImplementedException();
        }
    }
}
