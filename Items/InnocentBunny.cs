using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace YABSSM.Items
{
    public class InnocentBunny : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Innocent, Helpless Bunny");
            Tooltip.SetDefault("Irresistible to evil demons");
        }

        public override void SetDefaults()
        {
            item.width = 28;
            item.height = 26;
            item.maxStack = 20;
            item.value = Item.sellPrice(0, 0, 1, 0);
            item.rare = 5;
            item.useAnimation = 30;
            item.useTime = 30;
            item.useStyle = 4;
            item.consumable = true;
        }

        public override bool CanUseItem(Player player)
        {
            return player.ZoneUnderworldHeight && !NPC.AnyNPCs(NPCID.WallofFlesh);
        }

        public override bool UseItem(Player player)
        {
            NPC.SpawnOnPlayer(player.whoAmI, NPCID.WallofFlesh);
            Main.PlaySound(SoundID.Roar, player.position, 0);
            return true;
        }
    }
}