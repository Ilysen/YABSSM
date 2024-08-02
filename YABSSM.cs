using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace YABSSM
{
	internal class YABSSM : Mod { }

	internal class YABSSMNPC : GlobalNPC
	{
		public override void ModifyShop(NPCShop shop)
		{
			YABSSMConfig config = GetInstance<YABSSMConfig>();
			if ((int)config.vendorNPC == shop.NpcType)
			{
				if (NPC.downedSlimeKing || config.alternateProgression)
					shop.Add(new Item(ItemID.SlimeCrown) { shopCustomPrice = Item.buyPrice(silver: 50) });

				if (NPC.downedBoss1 || config.alternateProgression)
					shop.Add(new Item(ItemID.SuspiciousLookingEye) { shopCustomPrice = Item.buyPrice(gold: 1) });

				if (NPC.downedBoss2 || (config.alternateProgression && NPC.downedBoss1))
					shop.Add(new Item(WorldGen.crimson ? ItemID.BloodySpine : ItemID.WormFood) { shopCustomPrice = Item.buyPrice(gold: 1) });

				if (NPC.downedBoss3 || (config.alternateProgression && NPC.downedBoss2))
					shop.Add(new Item(ItemID.ClothierVoodooDoll) { shopCustomPrice = Item.buyPrice(gold: 1) });

				if (NPC.downedDeerclops || (config.alternateProgression && NPC.downedBoss3))
					shop.Add(new Item(ItemID.DeerThing) { shopCustomPrice = Item.buyPrice(gold: 5) });

				if (NPC.downedQueenBee || (config.alternateProgression && NPC.downedBoss3))
					shop.Add(new Item(ItemID.Abeemination) { shopCustomPrice = Item.buyPrice(gold: 1) });

				if (Main.hardMode || (config.alternateProgression && NPC.downedQueenBee))
					shop.Add(new Item(ItemType<Content.Items.InnocentBunny>()) { shopCustomPrice = Item.buyPrice(gold: 1) });

				if (NPC.downedQueenSlime || (config.alternateProgression && Main.hardMode))
					shop.Add(new Item(ItemID.QueenSlimeCrystal) { shopCustomPrice = Item.buyPrice(gold: 10) });

				if (NPC.downedMechBoss1 || (config.alternateProgression && NPC.downedQueenSlime))
					shop.Add(new Item(ItemID.MechanicalWorm) { shopCustomPrice = Item.buyPrice(gold: 5) });

				if (NPC.downedMechBoss2 || (!config.alternateProgression && NPC.downedQueenSlime))
					shop.Add(new Item(ItemID.MechanicalEye) { shopCustomPrice = Item.buyPrice(gold: 5) });

				if (NPC.downedMechBoss3 || (config.alternateProgression && NPC.downedQueenSlime))
					shop.Add(new Item(ItemID.MechanicalSkull) { shopCustomPrice = Item.buyPrice(gold: 5) });

				if (NPC.downedPlantBoss || (config.alternateProgression && (NPC.downedMechBoss1 && NPC.downedMechBoss2 && NPC.downedMechBoss3)))
					shop.Add(new Item(ItemType<Content.Items.PepperyFruit>()) { shopCustomPrice = Item.buyPrice(gold: 10) });

				if (NPC.downedEmpressOfLight || (config.alternateProgression && NPC.downedPlantBoss))
					shop.Add(new Item(ItemID.EmpressButterfly) { shopCustomPrice = Item.buyPrice(gold: 10) });

				if (NPC.downedGolemBoss || (config.alternateProgression && NPC.downedPlantBoss))
					shop.Add(new Item(ItemID.LihzahrdPowerCell) { shopCustomPrice = Item.buyPrice(gold: 10) });

				if (NPC.downedFishron || (config.alternateProgression && NPC.downedPlantBoss))
					shop.Add(new Item(ItemID.TruffleWorm) { shopCustomPrice = Item.buyPrice(gold: 10) });

				if (NPC.downedHalloweenTree || (config.alternateProgression && NPC.downedPlantBoss))
					shop.Add(new Item(ItemID.PumpkinMoonMedallion) { shopCustomPrice = Item.buyPrice(gold: 10) });

				if (NPC.downedChristmasTree || (config.alternateProgression && NPC.downedPlantBoss))
					shop.Add(new Item(ItemID.NaughtyPresent) { shopCustomPrice = Item.buyPrice(gold: 10) });

				if (NPC.downedMoonlord || (config.alternateProgression && NPC.downedAncientCultist))
					shop.Add(new Item(ItemType<Content.Items.CrackedRelic>()) { shopCustomPrice = Item.buyPrice(gold: 20) });
			}
		}
	}
}
