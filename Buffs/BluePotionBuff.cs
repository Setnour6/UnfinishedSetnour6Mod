using System;
using Terraria;
using Terraria.ModLoader;

namespace UnfinishedSetnour6Mod.Buffs
{
	// Token: 0x0200001C RID: 28
	public class BluePotionBuff : ModBuff
	{
		// Token: 0x0600007B RID: 123 RVA: 0x000053B0 File Offset: 0x000035B0
		public override void SetDefaults()
		{
			base.DisplayName.SetDefault("Blue Potion");
			base.Description.SetDefault("Grants immunity to almost all vanilla debuffs\n'Surprisingly better than that 'other' potion'");
			Main.debuff[base.Type] = false;
			this.canBeCleared = true;
		}

		// Token: 0x0600007C RID: 124 RVA: 0x000053E8 File Offset: 0x000035E8
		public override void Update(Player player, ref int buffIndex)
		{
			player.buffImmune[20] = true;
			player.buffImmune[22] = true;
			player.buffImmune[23] = true;
			player.buffImmune[24] = true;
			player.buffImmune[30] = true;
			player.buffImmune[31] = true;
			player.buffImmune[32] = true;
			player.buffImmune[33] = true;
			player.buffImmune[35] = true;
			player.buffImmune[36] = true;
			player.buffImmune[39] = true;
			player.buffImmune[44] = true;
			player.buffImmune[46] = true;
			player.buffImmune[47] = true;
			player.buffImmune[67] = true;
			player.buffImmune[68] = true;
			player.buffImmune[69] = true;
			player.buffImmune[70] = true;
			player.buffImmune[72] = true;
			player.buffImmune[80] = true;
			player.buffImmune[86] = true;
			player.buffImmune[88] = true;
			player.buffImmune[94] = true;
			player.buffImmune[103] = true;
			player.buffImmune[137] = true;
			player.buffImmune[144] = true;
			player.buffImmune[145] = true;
			player.buffImmune[148] = true;
			player.buffImmune[149] = true;
			player.buffImmune[153] = true;
			player.buffImmune[156] = true;
			player.buffImmune[160] = true;
			player.buffImmune[163] = true;
			player.buffImmune[164] = true;
			player.buffImmune[169] = true;
			player.buffImmune[194] = true;
			player.buffImmune[195] = true;
			player.buffImmune[196] = true;
			player.buffImmune[197] = true;
			player.buffImmune[203] = true;
			player.buffImmune[204] = true;
		}

		// Token: 0x0600007D RID: 125 RVA: 0x000055C2 File Offset: 0x000037C2
		public BluePotionBuff()
		{
		}
	}
}
