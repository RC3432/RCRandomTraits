using Terraria;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace RCRandomTraits.Buffs
{

	public class ExpertFisher : ModBuff
	{
		public override void SetDefaults() {
			DisplayName.SetDefault("Adept Fisherman");
			Description.SetDefault("You are much for effective at fishing than the average human.\nYou can determine whats on your hook.\nLines never break.\nIncreases fishing power.");
			Main.debuff[Type] = true;
			Main.buffNoTimeDisplay[Type] = true;
			Main.buffNoSave[Type] = false;
		}

		public override void Update(Player player, ref int buffIndex) {
			{
				player.sonarPotion = true;
				player.accFishingLine = true;
				player.fishingSkill *= 2;
			}

		}
		

	}
}
