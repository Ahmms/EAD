using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using System.ComponentModel.DataAnnotations;
using Project_.Models;
using Project_;

namespace Project_.Models

{
    public class SignUp
    {
        [Required(ErrorMessage = "Required")]
        public string firstName { get; set; }
        [Required(ErrorMessage = "Required")]
        public string secondName { get; set; }
        [Required(ErrorMessage = "Required")]
        public string email { get; set; }
        [Required(ErrorMessage = "Required")]
        public string password { get; set; }
        [Required(ErrorMessage = "Required")]
        public string gender { get; set; }
        [Required(ErrorMessage = "Required")]
        public string phone_no { get; set; }
        
    } 
    public class users_repository
    {
        
        //public static void Add_Users(SignUp su)
        //{
        //    // Passing the connection string in MongoClient
        //    var client = new MongoClient("mongodb+srv://ahmad:K26BnOx7KXJvFo97@cluster0.d0xqt.mongodb.net/?retryWrites=true&w=majority");
        //    //Get sample_mflix Database  
        //    var db = client.GetDatabase("Project");
        //    //Get movies collection  
        //    var collection = db.GetCollection<BsonDocument>("User_Data");
        //    var user = new BsonDocument
        //     {
        //        {"first_name",su.firstName},
        //        {"last_name",su.secondName},
        //        {"username",su.email},
        //        {"password",su.password},
        //        {"gender",su.gender},
        //        {"number",su.phone_no }
        //    };
        //    collection.InsertOneAsync(user);
        //}
    }

}
