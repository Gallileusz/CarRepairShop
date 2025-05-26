using CarRepairShop.Domain.Entities;

namespace CarRepairShop
{
    public static class CurrentUser
    {
        public static Users Data { get; private set; }

        public static void SetUser(Users user) => Data = user;

    }
}
