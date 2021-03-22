using Terraria;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace RCRandomTraits.Buffs
{

	public class Acrobatic : ModBuff
	{
		public override void SetDefaults() {
			DisplayName.SetDefault("Athletic");
			Description.SetDefault("You are unusually swift.\nAllows you to dash\nAllows you to double jump");
			Main.debuff[Type] = true;
			Main.buffNoTimeDisplay[Type] = true;
			Main.buffNoSave[Type] = false;
		}

		public override void Update(Player player, ref int buffIndex) {
			{
				player.dash = 2;
				player.doubleJumpSail = true;
				player.autoJump = true;
			}

		}
		

	}
}
