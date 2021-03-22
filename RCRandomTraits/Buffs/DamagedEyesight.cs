using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Microsoft.Xna.Framework;

namespace RCRandomTraits.Buffs
{

	public class DamagedEyesight : ModBuff
	{
		public override void SetDefaults() {
			DisplayName.SetDefault("Impaired Vision");
			Description.SetDefault("Your eyes are damaged.\n-5% ranged damage\nReduced visability.\nImmunity to Spelunker, Dangersense, and Hunter");
			Main.debuff[Type] = true;
			Main.buffNoTimeDisplay[Type] = true;
			Main.buffNoSave[Type] = false;
		}

		public override void Update(Player player, ref int buffIndex) {
			{
				player.rangedDamage *= 0.95f;
				player.blind = true;
				player.yoraiz0rDarkness = true;
				player.buffImmune[BuffID.Spelunker] = true;
				player.buffImmune[BuffID.Dangersense] = true;
				player.buffImmune[BuffID.Hunter] = true;

			}

		}
		

	}
}
