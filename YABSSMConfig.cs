using System.ComponentModel;
using Terraria.ID;
using Terraria.ModLoader.Config;

namespace YABSSM
{
	public class YABSSMConfig : ModConfig
	{
		public enum PossibleNPCs : short
		{
			Clothier = NPCID.Clothier,
			Dryad = NPCID.Dryad,
			Merchant = NPCID.Merchant,
			Demolitionist = NPCID.Demolitionist,
			DyeTrader = NPCID.DyeTrader,
			ArmsDealer = NPCID.ArmsDealer,
			Stylist = NPCID.Stylist,
			Painter = NPCID.Painter,
			GoblinTinkerer = NPCID.GoblinTinkerer,
			WitchDoctor = NPCID.WitchDoctor,
			Mechanic = NPCID.Mechanic,
			PartyGirl = NPCID.PartyGirl
		}

		public override ConfigScope Mode => ConfigScope.ServerSide;

		[Label("Vendor NPC")]
		[Tooltip("Dictates which town NPC sells boss summon items.")]
		[DefaultValue(PossibleNPCs.Clothier)]
		public PossibleNPCs vendorNPC;
	}
}