using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kaveh.Domain.Models
{
    public class User
    {
        public ObjectId _id { get; set; }
        [BsonRequired]
        public string PersonalCode { get; set; }
        public string Name { get; set; }
        public string Family { get; set; }
        public int Age { get; set; }
        [BsonRequired]      
        public string Username { get; set; }
        [BsonRequired]
        public string Password { get; set; }
        public string ImageUrl { get; set; }
       
    }
}

