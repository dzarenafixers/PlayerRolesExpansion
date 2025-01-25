using Exiled.API.Features;
using InventorySystem.Items;
using PlayerRoles;

namespace PlayerRolesExpansion.Roles
{
    public static class SpecialGuard
    {
        public static void Setup(Player player)
        {
            player.Role.Set(RoleTypeId.FacilityGuard); // تأكيد تعيين الدور
            player.AddItem(ItemType.GunLogicer);
            player.AddItem(ItemType.ArmorCombat);
            player.Health = 200;
            player.MaxHealth = 200;
            player.Broadcast(10, "You have spawned as a Special Guard with enhanced abilities!");
        }
    }
}