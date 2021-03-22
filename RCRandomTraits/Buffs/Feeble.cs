using Terraria;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace RCRandomTraits.Buffs
{

	public class Feeble : ModBuff
	{
		public override void SetDefaults() {
			DisplayName.SetDefault("Feeble");
			Description.SetDefault("You are unusually weak.\n-5% melee damage\nTakes 5% more damage.");
			Main.debuff[Type] = true;
			Main.buffNoTimeDisplay[Type] = true;
			Main.buffNoSave[Type] = false;
		}

		public override void Update(Player player, ref int buffIndex) {
			{
				player.endurance -= 0.05f;
				player.meleeDamage *= 0.95f;
			}

		}
		

	}
}
