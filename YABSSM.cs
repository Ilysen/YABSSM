using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace YABSSM
{
    class YABSSM : Mod
    {

    }
}

namespace YABSSM.NPCs
{
    class YABSSMNPC : GlobalNPC
    {
        public override void SetupShop(int type, Chest shop, ref int nextSlot)
        {
            if (type == NPCID.Dryad)
            {
                if (NPC.downedSlimeKing)
                {
                    shop.item[nextSlot].SetDefaults(ItemID.SlimeCrown);
                    shop.item[nextSlot].shopCustomPrice = Item.buyPrice(0, 0, 50, 0);
                    nextSlot++;
                }
                if (NPC.downedBoss1)
                {
                    shop.item[nextSlot].SetDefaults(ItemID.SuspiciousLookingEye);
                    shop.item[nextSlot].shopCustomPrice = Item.buyPrice(0, 1, 0, 0);
                    nextSlot++;
                }
                if (NPC.downedBoss2)
                {
                    if (!WorldGen.crimson)
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.WormFood);
                        shop.item[nextSlot].shopCustomPrice = Item.buyPrice(0, 5, 0, 0);
                        nextSlot++;
                    }
                    else
                    {
                        shop.item[nextSlot].SetDefaults(ItemID.BloodySpine);
                        shop.item[nextSlot].shopCustomPrice = Item.buyPrice(0, 5, 0, 0);
                        nextSlot++;
                    }
                }
                if (NPC.downedBoss3)
                {
                    shop.item[nextSlot].SetDefaults(ItemID.ClothierVoodooDoll);
                    shop.item[nextSlot].shopCustomPrice = Item.buyPrice(0, 5, 0, 0);
                    nextSlot++;
                }
                if (NPC.downedQueenBee)
                {
                    shop.item[nextSlot].SetDefaults(ItemID.Abeemination);
                    shop.item[nextSlot].shopCustomPrice = Item.buyPrice(0, 5, 0, 0);
                    nextSlot++;
                }
                if (Main.hardMode)
                {
                    shop.item[nextSlot].SetDefaults(ItemID.GuideVoodooDoll);
                    shop.item[nextSlot].shopCustomPrice = Item.buyPrice(0, 10, 0, 0);
                    nextSlot++;
                }
                if (NPC.downedMechBoss1)
                {
                    shop.item[nextSlot].SetDefaults(ItemID.MechanicalEye);
                    shop.item[nextSlot].shopCustomPrice = Item.buyPrice(0, 10, 0, 0);
                    nextSlot++;
                }
                if (NPC.downedMechBoss2)
                {
                    shop.item[nextSlot].SetDefaults(ItemID.MechanicalWorm);
                    shop.item[nextSlot].shopCustomPrice = Item.buyPrice(0, 10, 0, 0);
                    nextSlot++;
                }
                if (NPC.downedMechBoss3)
                {
                    shop.item[nextSlot].SetDefaults(ItemID.MechanicalSkull);
                    shop.item[nextSlot].shopCustomPrice = Item.buyPrice(0, 10, 0, 0);
                    nextSlot++;
                }
                if (NPC.downedGolemBoss)
                {
                    shop.item[nextSlot].SetDefaults(ItemID.LihzahrdPowerCell);
                    shop.item[nextSlot].shopCustomPrice = Item.buyPrice(0, 25, 0, 0);
                    nextSlot++;
                }
                if (NPC.downedHalloweenTree)
                {
                    shop.item[nextSlot].SetDefaults(ItemID.PumpkinMoonMedallion);
                    shop.item[nextSlot].shopCustomPrice = Item.buyPrice(0, 25, 0, 0);
                    nextSlot++;
                }
                if (NPC.downedChristmasTree)
                {
                    shop.item[nextSlot].SetDefaults(ItemID.NaughtyPresent);
                    shop.item[nextSlot].shopCustomPrice = Item.buyPrice(0, 25, 0, 0);
                    nextSlot++;
                }
                if (NPC.downedMoonlord)
                {
                    shop.item[nextSlot].SetDefaults(ItemID.CelestialSigil);
                    shop.item[nextSlot].shopCustomPrice = Item.buyPrice(0, 50, 0, 0);
                    nextSlot++;
                }
            }
        }
    }
}
