using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using System.ComponentModel.DataAnnotations;
namespace Project_.Models
{
    public class SignIn
    {
        [Required(ErrorMessage = "Required")]
        public string userName { get; set; }
        [Required(ErrorMessage = "Required")]
        public string password { get; set; }
        public string message { get; set; }
    }
    public class SignIn_functions
    {
        
        //public static bool credential_verification(SignIn si)
        //{
        //    var client = new MongoClient("mongodb+srv://ahmad:K26BnOx7KXJvFo97@cluster0.d0xqt.mongodb.net/?retryWrites=true&w=majority");
        //    //Get sample_mflix Database  
        //    var db = client.GetDatabase("Project");
        //    //Get movies collection  
        //    var collection = db.GetCollection<BsonDocument>("User_Data");
        //    var result = collection.Find("{username:'"+si.userName+"'}").FirstOrDefault();
        //    if(result == null || result[4] != si.password)
        //    {
        //        return false;
        //    }
        //    else
        //        return true;
        //}
    }
}
