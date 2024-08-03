using System.ComponentModel;
using Terraria.ID;
using Terraria.ModLoader.Config;

namespace YABSSM
{
	public class YABSSMConfig : ModConfig
	{
		public enum PossibleNPCs : short
		{
			ArmsDealer = NPCID.ArmsDealer,
			Clothier = NPCID.Clothier,
			Demolitionist = NPCID.Demolitionist,
			Dryad = NPCID.Dryad,
			DyeTrader = NPCID.DyeTrader,
			GoblinTinkerer = NPCID.GoblinTinkerer,
			Golfer = NPCID.Golfer,
			Mechanic = NPCID.Mechanic,
			Merchant = NPCID.Merchant,
			Painter = NPCID.Painter,
			PartyGirl = NPCID.PartyGirl,
			Stylist = NPCID.Stylist,
			WitchDoctor = NPCID.WitchDoctor,
			Zoologist = NPCID.BestiaryGirl,
		}

		public override ConfigScope Mode => ConfigScope.ServerSide;

		[DefaultValue(PossibleNPCs.Dryad)]
		public PossibleNPCs vendorNPC;

		[DefaultValue(false)]
		public bool alternateProgression;

		/*[DefaultValue(false)]
		[ReloadRequired]
		public bool enableEasterEggs;*/
	}
}
