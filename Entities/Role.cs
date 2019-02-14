namespace WebApi.Entities
{
    //because the [Authorize] attribute requires roles to be passed as strings so no enum allowed
    public static class Role
    {
        public const string Admin = "Admin";
        public const string User = "User";
    }
}