# PlayerRolesExpansion - Custom Roles

This project adds custom roles to **SCP: Secret Laboratory** using the **EXILED** framework. Custom roles are created and configured through code.

## Available Roles

### 1. **Special Guard**
- **Description**: A guard with enhanced abilities and powerful equipment.
- **Details**:
  - Role: `FacilityGuard`
  - Weapons: `GunLogicer`
  - Armor: `ArmorCombat`
  - Health: `200`
  - Message: "You have spawned as a Special Guard with enhanced abilities!"

```csharp
using Exiled.API.Features;
using InventorySystem.Items;
using PlayerRoles;

namespace PlayerRolesExpansion.Roles
{
    public static class SpecialGuard
    {
        public static void Setup(Player player)
        {
            player.Role.Set(RoleTypeId.FacilityGuard); // Confirm role assignment
            player.AddItem(ItemType.GunLogicer);
            player.AddItem(ItemType.ArmorCombat);
            player.Health = 200;
            player.MaxHealth = 200;
            player.Broadcast(10, "You have spawned as a Special Guard with enhanced abilities!");
        }
    }
}
# ________________________________________________________________

### codes more roles
### 2. Scientist

Description: A scientist equipped with special tools for research and survival.

Details:

Items: Medkit, KeycardScientist

Health: 100

Message: "You have spawned as a Scientist with special items!"

csharp
Copy
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
3. Medical Staff
Description: A member of the medical team with healing abilities.

Details:

Items: SCP500, Medkit

Health: 150

Message: "You have spawned as Medical Staff with healing abilities!"

csharp
Copy
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


###How to Use

Download and install the EXILED framework on your SCP: Secret Laboratory server.

Add the custom role files to your server's plugins folder.

Modify the code to add or adjust roles as needed.

Restart the server to apply the changes.

Contributing
If you'd like to contribute to this project, feel free to fork the repository and submit a pull request with your changes. Make sure to follow the coding standards and include documentation for any new features.

### License
# This project is licensed under the MIT License. See the LICENSE file for details.


---

### How to Use This:
1. Copy the entire content above.
2. Create a new file in your repository named `README.md`.
3. Paste the content into the file.
4. Save and commit the file to your repository.

This will display the documentation in a clean and professional format on GitHub or any other platform that supports Markdown. Let me know if you need further assistance! 😊
# enjoy
