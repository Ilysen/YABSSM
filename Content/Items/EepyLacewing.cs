using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Audio;
using Terraria.ID;
using Terraria.ModLoader;

namespace YABSSM.Content.Items
{
	public class EepyLacewing : ModItem
	{
		public override void SetStaticDefaults()
		{
			Item.ResearchUnlockCount = 3;
			ItemID.Sets.SortingPriorityBossSpawns[Type] = 12;
		}

		public override void SetDefaults()
		{
			Item.width = 32;
			Item.height = 26;
			Item.maxStack = 20;
			Item.rare = ItemRarityID.Orange;
			Item.useAnimation = 30;
			Item.useTime = 30;
			Item.useStyle = ItemUseStyleID.HoldUp;
			Item.consumable = true;
		}

		public override void ModifyResearchSorting(ref ContentSamples.CreativeHelper.ItemGroup itemGroup)
		{
			itemGroup = ContentSamples.CreativeHelper.ItemGroup.BossSpawners;
		}

		public override bool CanUseItem(Player player)
		{
			return Main.hardMode && player.ZoneHallow && !NPC.AnyNPCs(636);
		}

		public override bool? UseItem(Player player)
		{
			if (player.whoAmI == Main.myPlayer)
			{
				SoundEngine.PlaySound(SoundID.NPCDeath1, player.position);
				if (Main.netMode != NetmodeID.MultiplayerClient)
				{
					Vector2 vector = player.Center + new Vector2(0f, -200f) + Main.rand.NextVector2Circular(50f, 50f);
					NPC.SpawnBoss((int)vector.X, (int)vector.Y, NPCID.HallowBoss, player.whoAmI);
				}
				else
					NetMessage.SendData(MessageID.SpawnBossUseLicenseStartEvent, number: player.whoAmI, number2: NPCID.HallowBoss);
			}
			return null;
		}
	}
}
