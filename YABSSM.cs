using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace YABSSM
{
	internal class YABSSM : Mod
	{ }

	internal class YABSSMNPC : GlobalNPC
	{
		public override void SetupShop(int type, Chest shop, ref int nextSlot)
		{
			YABSSMConfig config = GetInstance<YABSSMConfig>();
			if ((int)config.vendorNPC == type)
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
						shop.item[nextSlot].shopCustomPrice = Item.buyPrice(0, 1, 0, 0);
						nextSlot++;
					}
					else
					{
						shop.item[nextSlot].SetDefaults(ItemID.BloodySpine);
						shop.item[nextSlot].shopCustomPrice = Item.buyPrice(0, 1, 0, 0);
						nextSlot++;
					}
				}
				if (NPC.downedBoss3)
				{
					shop.item[nextSlot].SetDefaults(ItemID.ClothierVoodooDoll);
					shop.item[nextSlot].shopCustomPrice = Item.buyPrice(0, 2, 0, 0);
					nextSlot++;
				}
				if (NPC.downedQueenBee)
				{
					shop.item[nextSlot].SetDefaults(ItemID.Abeemination);
					shop.item[nextSlot].shopCustomPrice = Item.buyPrice(0, 2, 0, 0);
					nextSlot++;
				}
				if (Main.hardMode)
				{
					shop.item[nextSlot].SetDefaults(mod.ItemType("InnocentBunny"));
					shop.item[nextSlot].shopCustomPrice = Item.buyPrice(0, 5, 0, 0);
					nextSlot++;
				}
				if (NPC.downedMechBoss1)
				{
					shop.item[nextSlot].SetDefaults(ItemID.MechanicalWorm);
					shop.item[nextSlot].shopCustomPrice = Item.buyPrice(0, 5, 0, 0);
					nextSlot++;
				}
				if (NPC.downedMechBoss2)
				{
					shop.item[nextSlot].SetDefaults(ItemID.MechanicalEye);
					shop.item[nextSlot].shopCustomPrice = Item.buyPrice(0, 5, 0, 0);
					nextSlot++;
				}
				if (NPC.downedMechBoss3)
				{
					shop.item[nextSlot].SetDefaults(ItemID.MechanicalSkull);
					shop.item[nextSlot].shopCustomPrice = Item.buyPrice(0, 5, 0, 0);
					nextSlot++;
				}
				if (NPC.downedPlantBoss)
				{
					shop.item[nextSlot].SetDefaults(mod.ItemType("PepperyFruit"));
					shop.item[nextSlot].shopCustomPrice = Item.buyPrice(0, 10, 0, 0);
					nextSlot++;
				}
				if (NPC.downedGolemBoss)
				{
					shop.item[nextSlot].SetDefaults(ItemID.LihzahrdPowerCell);
					shop.item[nextSlot].shopCustomPrice = Item.buyPrice(0, 10, 0, 0);
					nextSlot++;
				}
				if (NPC.downedFishron)
				{
					shop.item[nextSlot].SetDefaults(ItemID.TruffleWorm);
					shop.item[nextSlot].shopCustomPrice = Item.buyPrice(0, 10, 0, 0);
					nextSlot++;
				}
				if (NPC.downedHalloweenTree)
				{
					shop.item[nextSlot].SetDefaults(ItemID.PumpkinMoonMedallion);
					shop.item[nextSlot].shopCustomPrice = Item.buyPrice(0, 10, 0, 0);
					nextSlot++;
				}
				if (NPC.downedChristmasTree)
				{
					shop.item[nextSlot].SetDefaults(ItemID.NaughtyPresent);
					shop.item[nextSlot].shopCustomPrice = Item.buyPrice(0, 10, 0, 0);
					nextSlot++;
				}
				if (NPC.downedAncientCultist)
				{
					shop.item[nextSlot].SetDefaults(mod.ItemType("CrackedRelic"));
					shop.item[nextSlot].shopCustomPrice = Item.buyPrice(0, 20, 0, 0);
					nextSlot++;
				}
			}
		}
	}
}