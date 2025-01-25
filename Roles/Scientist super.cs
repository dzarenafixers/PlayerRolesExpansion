using Exiled.API.Features;

namespace PlayerRolesExpansion.Roles
{
    public static class Scientist
    {
        public static void Setup(Player player)
        {
            player.AddItem(ItemType.Medkit);
            player.AddItem(ItemType.KeycardScientist);
            player.Health = 100;
            player.MaxHealth = 100;
            player.Broadcast(10, "You have spawned as a Scientist with special items!");
        }
    }
}