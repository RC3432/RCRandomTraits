using Terraria;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace RCRandomTraits.Buffs
{

	public class Stealthy : ModBuff
	{
		public override void SetDefaults() {
			DisplayName.SetDefault("Stealthy");
			Description.SetDefault("You are unusually sneaky.\nReduced enemy aggro");
			Main.debuff[Type] = true;
			Main.buffNoTimeDisplay[Type] = true;
			Main.buffNoSave[Type] = false;
		}

		public override void Update(Player player, ref int buffIndex) {
			{
				player.aggro /= 2;
				
				
			}

		}
		

	}
}
