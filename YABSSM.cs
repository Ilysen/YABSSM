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
				var slimeCrownCondition = new Condition("Mods.YABSSM.Conditions.SellKingSlime", () => NPC.downedSlimeKing || config.alternateProgression);
				shop.Add(new Item(ItemID.SlimeCrown) { shopCustomPrice = Item.buyPrice(silver: 50) }, slimeCrownCondition);

				var eocCondition = new Condition("Mods.YABSSM.Conditions.SellEoC", () => NPC.downedBoss1 || config.alternateProgression);
				shop.Add(new Item(ItemID.SuspiciousLookingEye) { shopCustomPrice = Item.buyPrice(gold: 1) });

				var evilBossCondition = new Condition("Mods.YABSSM.Conditions.SellEvilBoss", () => NPC.downedBoss2 || (config.alternateProgression && NPC.downedBoss1));
				shop.Add(new Item(WorldGen.crimson ? ItemID.BloodySpine : ItemID.WormFood) { shopCustomPrice = Item.buyPrice(gold: 1) });

				var skeletronCondition = new Condition("Mods.YABSSM.Conditions.SellSkeletron", () => NPC.downedBoss3);
				shop.Add(new Item(ItemType<Content.Items.ClothierPlushie>()) { shopCustomPrice = Item.buyPrice(gold: 1) }, skeletronCondition);
				/*Item toAdd;
				if (config.enableEasterEggs && Main.rand.NextBool(50))
					toAdd = new Item(ItemType<Content.Items.ClothierPlushie>()) { shopCustomPrice = Item.buyPrice(gold: 1) };
				else
					toAdd = new Item(ItemType<Content.Items.ClothierFumo>()) { shopCustomPrice = Item.buyPrice(gold: 1) };
				shop.Add(toAdd, skeletronCondition);*/

				var deerclopsCondition = new Condition("Mods.YABSSM.Conditions.SellDeerclops", () => NPC.downedDeerclops || (config.alternateProgression && NPC.downedBoss3));
				shop.Add(new Item(ItemID.DeerThing) { shopCustomPrice = Item.buyPrice(gold: 5) }, deerclopsCondition);

				var queenBeeCondition = new Condition("Mods.YABSSM.Conditions.SellQueenBee", () => NPC.downedQueenBee || (config.alternateProgression && NPC.downedBoss3));
				shop.Add(new Item(ItemID.Abeemination) { shopCustomPrice = Item.buyPrice(gold: 1) }, queenBeeCondition);

				var wofCondition = new Condition("Mods.YABSSM.Conditions.SellWoF", () => Main.hardMode || (config.alternateProgression && NPC.downedQueenBee));
				shop.Add(new Item(ItemType<Content.Items.InnocentBunny>()) { shopCustomPrice = Item.buyPrice(gold: 1) }, wofCondition);

				var queenSlimeCondition = new Condition("Mods.YABSSM.Conditions.SellQueenSlime", () => NPC.downedQueenSlime || (config.alternateProgression && Main.hardMode));
				shop.Add(new Item(ItemID.QueenSlimeCrystal) { shopCustomPrice = Item.buyPrice(gold: 5) }, queenSlimeCondition);

				var destroyerCondition = new Condition("Mods.YABSSM.Conditions.SellDestroyer", () => NPC.downedMechBoss1 || (config.alternateProgression && Main.hardMode));
				shop.Add(new Item(ItemID.MechanicalWorm) { shopCustomPrice = Item.buyPrice(gold: 5) }, destroyerCondition);

				var twinsCondition = new Condition("Mods.YABSSM.Conditions.SellTwins", () => NPC.downedMechBoss2 || (config.alternateProgression && Main.hardMode));
				shop.Add(new Item(ItemID.MechanicalEye) { shopCustomPrice = Item.buyPrice(gold: 5) }, twinsCondition);

				var skeletronPrimeCondition = new Condition("Mods.YABSSM.Conditions.SellSkeletronPrime", () => NPC.downedMechBoss3 || (config.alternateProgression && Main.hardMode));
				shop.Add(new Item(ItemID.MechanicalSkull) { shopCustomPrice = Item.buyPrice(gold: 5) }, skeletronPrimeCondition);

				var planteraCondition = new Condition("Mods.YABSSM.Conditions.SellPlantera", () => NPC.downedPlantBoss || (config.alternateProgression && (NPC.downedMechBoss1 && NPC.downedMechBoss2 && NPC.downedMechBoss3)));
				shop.Add(new Item(ItemType<Content.Items.PepperyFruit>()) { shopCustomPrice = Item.buyPrice(gold: 10) }, planteraCondition);

				var eolCondition = new Condition("Mods.YABSSM.Conditions.SellEoL", () => NPC.downedEmpressOfLight || (config.alternateProgression && NPC.downedPlantBoss));
				shop.Add(new Item(ItemType<Content.Items.EepyLacewing>()) { shopCustomPrice = Item.buyPrice(gold: 10) }, eolCondition);

				var golemCondition = new Condition("Mods.YABSSM.Conditions.SellGolem", () => NPC.downedGolemBoss || (config.alternateProgression && NPC.downedPlantBoss));
				shop.Add(new Item(ItemID.LihzahrdPowerCell) { shopCustomPrice = Item.buyPrice(gold: 10) }, golemCondition);

				var fishronCondition = new Condition("Mods.YABSSM.Conditions.SellFishron", () => NPC.downedFishron || (config.alternateProgression && NPC.downedPlantBoss));
				shop.Add(new Item(ItemID.TruffleWorm) { shopCustomPrice = Item.buyPrice(gold: 10) }, fishronCondition);

				var pumpkinCondition = new Condition("Mods.YABSSM.Conditions.SellPumpkinMoon", () => NPC.downedHalloweenKing || (config.alternateProgression && NPC.downedPlantBoss));
				shop.Add(new Item(ItemID.PumpkinMoonMedallion) { shopCustomPrice = Item.buyPrice(gold: 10) }, pumpkinCondition);

				var frostCondition = new Condition("Mods.YABSSM.Conditions.SellFrostMoon", () => NPC.downedChristmasTree || (config.alternateProgression && NPC.downedPlantBoss));
				shop.Add(new Item(ItemID.NaughtyPresent) { shopCustomPrice = Item.buyPrice(gold: 10) }, frostCondition);

				var moonLordCondition = new Condition("Mods.YABSSM.Conditions.SellMoonLord", () => NPC.downedMoonlord || (config.alternateProgression && NPC.downedAncientCultist));
				shop.Add(new Item(ItemType<Content.Items.CrackedRelic>()) { shopCustomPrice = Item.buyPrice(gold: 20) }, moonLordCondition);
			}
		}
	}
}
