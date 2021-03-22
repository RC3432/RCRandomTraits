using Terraria;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace RCRandomTraits.Buffs
{

	public class Clumsy : ModBuff
	{
		public override void SetDefaults() {
			DisplayName.SetDefault("Clumsy");
			Description.SetDefault("You are unusually clumsy.\n-20% speed");
			Main.debuff[Type] = true;
			Main.buffNoTimeDisplay[Type] = true;
			Main.buffNoSave[Type] = false;
		}

		public override void Update(Player player, ref int buffIndex) {
			{
				player.moveSpeed *= 0.8f;
			}

		}
		

	}
}
