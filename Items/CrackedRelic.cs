using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace YABSSM.Items
{
    public class CrackedRelic : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Cracked Relic");
            Tooltip.SetDefault("A clay tablet thrumming with energy\nInstantly summons the impending doom");
        }

        public override void SetDefaults()
        {
            item.width = 40;
            item.height = 40;
            item.maxStack = 20;
            item.value = Item.sellPrice(0, 0, 25, 0);
            item.rare = 10;
            item.useAnimation = 30;
            item.useTime = 30;
            item.useStyle = 4;
            item.consumable = true;
        }

        public override bool CanUseItem(Player player)
        {
            return Main.hardMode && !NPC.AnyNPCs(NPCID.MoonLordCore);
        }

        public override bool UseItem(Player player)
        {
            NPC.SpawnOnPlayer(player.whoAmI, NPCID.MoonLordCore);
            Main.PlaySound(SoundID.Roar, player.position, 0);
            return true;
        }
    }
}