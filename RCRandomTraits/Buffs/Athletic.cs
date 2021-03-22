using Terraria;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace RCRandomTraits.Buffs
{

	public class Athletic : ModBuff
	{
		public override void SetDefaults() {
			DisplayName.SetDefault("Athletic");
			Description.SetDefault("You are unusually strong.\n+5% melee damage\nAbility to climb walls and swim.\nIncreases Knockback");
			Main.debuff[Type] = true;
			Main.buffNoTimeDisplay[Type] = true;
			Main.buffNoSave[Type] = false;
		}

		public override void Update(Player player, ref int buffIndex) {
			{
				player.meleeCrit += 4;
				player.meleeDamage *= 1.05f;
				player.kbBuff = true;
				player.spikedBoots += 1;
				player.accFlipper = true;
			}

		}
		

	}
}
