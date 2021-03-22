using Terraria;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace RCRandomTraits.Buffs
{

	public class Intellegent : ModBuff
	{
		public override void SetDefaults() {
			DisplayName.SetDefault("Intellegent");
			Description.SetDefault("You are unusually smart.\n+5% magic damage\nIncreased mana regeneration.\nYou understand the time of day, and your position");
			Main.debuff[Type] = true;
			Main.buffNoTimeDisplay[Type] = true;
			Main.buffNoSave[Type] = false;
		}

		public override void Update(Player player, ref int buffIndex) {
			{
				player.magicDamage *= 1.05f;
				player.accWatch += 1;
				player.accDepthMeter += 1;
				player.accCompass += 1;
				player.manaRegenBuff = true;
			}

		}
		

	}
}
