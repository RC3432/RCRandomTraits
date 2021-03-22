using Terraria;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace RCRandomTraits.Buffs
{

	public class Aggressive : ModBuff
	{
		public override void SetDefaults() {
			DisplayName.SetDefault("Aggressive");
			Description.SetDefault("20% less defense\n+2 to all damage\nImmune when using a calming potion");
			Main.debuff[Type] = true;
			Main.buffNoTimeDisplay[Type] = true;
			Main.buffNoSave[Type] = false;
		}

		public override void Update(Player player, ref int buffIndex) {
			{
				player.allDamage += 2;
				player.statDefense -= 4;
				player.yoraiz0rEye += 1;
				player.eyeColor = Color.DarkRed;
			}

		}
		

	}
}
