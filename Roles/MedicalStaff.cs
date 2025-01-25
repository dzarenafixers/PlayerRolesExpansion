using Exiled.API.Features;

namespace PlayerRolesExpansion.Roles
{
    public static class MedicalStaff
    {
        public static void Setup(Player player)
        {
            player.AddItem(ItemType.SCP500);
            player.AddItem(ItemType.Medkit);
            player.Health = 150;
            player.MaxHealth = 150;
            player.Broadcast(10, "You have spawned as Medical Staff with healing abilities!");
        }
    }
}