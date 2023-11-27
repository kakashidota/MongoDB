using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongoDBtutorial2.Models
{
    internal class AdressModel
    {
        [BsonId]
        public Guid Id { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string State { get; set; }

    }
}
