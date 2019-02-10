using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace YABSSM.Items
{
    public class PepperyFruit : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Peppery Fruit");
            Tooltip.SetDefault("Its aroma may attract giant plants");
        }

        public override void SetDefaults()
        {
            item.width = 34;
            item.height = 34;
            item.maxStack = 20;
            item.value = Item.sellPrice(0, 0, 1, 0);
            item.rare = 3;
            item.useAnimation = 30;
            item.useTime = 30;
            item.useStyle = 4;
            item.consumable = true;
        }

        public override bool CanUseItem(Player player)
        {
            return Main.hardMode && player.ZoneJungle && !NPC.AnyNPCs(NPCID.Plantera);
        }

        public override bool UseItem(Player player)
        {
            NPC.SpawnOnPlayer(player.whoAmI, NPCID.Plantera);
            Main.PlaySound(SoundID.Roar, player.position, 0);
            return true;
        }
    }
}