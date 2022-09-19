using Project_.Models.Interface;

namespace Project_.Models.Repository
{
    public class UserRepository: IUserRepository
    {
        public bool credential_verification(SignIn si)
        {
            var Db = new ProjectContext();
            var result1 = (from emp in Db.UserData where emp.Mail == si.userName && emp.Pswd == si.password select emp.Pswd).FirstOrDefault();
            if (result1 == null) { return false; }
            else return true;
        }
        public void Add_Users(UserDatum ud)
        {
            var context = new ProjectContext();
            context.UserData.Add(ud);
            context.SaveChanges();
        }
    }
}
