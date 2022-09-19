namespace Project_.Models.Interface
{
    public interface IUserRepository
    {
        public bool credential_verification(SignIn si);
        public void Add_Users(UserDatum ud);

    }
}
