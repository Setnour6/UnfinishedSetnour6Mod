using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace UnfinishedSetnour6Mod.Items.Accessories
{
	// Token: 0x02000016 RID: 22
	public class TheStaticBlack : ModItem
	{
		// Token: 0x06000056 RID: 86 RVA: 0x000040E4 File Offset: 0x000022E4
		public override void SetStaticDefaults()
		{
			// base.DisplayName.SetDefault("Black Static");
			// base.Tooltip.SetDefault("[c/7D766E:You feel glitchy from within... ]\n[c/694A8A:Uh oh... ]\nEnemies take 500 times contact damage\nAll damage and critical strike chance increased by 500%\n[c/999999:Critical strike boost may not affect other mods besides Calamity ]\nDamage reduction increased by 500%\nIncreases life and mana regeneration by too much\n+4000 Max Life and +1000 Max Mana\nGrants immunity to knockback, fall damage, and fire blocks\nGrants immunity to almost all vanilla debuffs\nIncreases length of invincibility after taking damage... hopefully\nEffects of Philosopher's Stone... hopefully");
			ItemID.Sets.ItemNoGravity[base.Item.type] = true;
			Main.RegisterItemAnimation(base.Item.type, new DrawAnimationVertical(4, 15));
		}

		// Token: 0x06000057 RID: 87 RVA: 0x0000413C File Offset: 0x0000233C
		public override void SetDefaults()
		{
			base.Item.width = 24;
			base.Item.height = 28;
			base.Item.value = 1000000;
			base.Item.rare = -1;
			base.Item.expert = false;
			base.Item.accessory = true;
			base.Item.defense = 500;
			base.Item.lifeRegen = 400;
		}

		// Token: 0x06000058 RID: 88 RVA: 0x000041B8 File Offset: 0x000023B8
		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.thorns += 500f;
			player.GetDamage(DamageClass.Generic) += 5f;
			player.GetCritChance(DamageClass.Generic) += 500;
			player.GetCritChance(DamageClass.Ranged) += 500;
			player.GetCritChance(DamageClass.Magic) += 500;
			player.GetCritChance(DamageClass.Throwing) += 500;
			Mod Calamity = ModLoader.GetMod("CalamityMod");
			if (Calamity != null)
			{
				Calamity.Call(new object[] { "AddRogueCrit", player, 500 });
			}
			player.statLifeMax2 += 4000;
			player.statManaMax2 += 800;
			player.manaRegen = 100;
			player.lifeRegen += 400;
			player.accRunSpeed = 20f;
			player.moveSpeed += 25f;
			player.noKnockback = true;
			player.endurance += 5f;
			player.pStone = true;
			player.pStone = true;
			player.fireWalk = true;
			player.longInvince = true;
			player.lavaImmune = true;
			player.noFallDmg = true;
			//player.starCloak = true;
			player.longInvince = true;
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

		// Token: 0x06000059 RID: 89 RVA: 0x000044DE File Offset: 0x000026DE
		public override void VerticalWingSpeeds(Player player, ref float ascentWhenFalling, ref float ascentWhenRising, ref float maxCanAscendMultiplier, ref float maxAscentMultiplier, ref float constantAscend)
		{
			ascentWhenFalling = 0.85f;
			ascentWhenRising = 0.25f;
			maxCanAscendMultiplier = 1f;
			maxAscentMultiplier = 3f;
			constantAscend = 0.135f;
		}

		// Token: 0x0600005A RID: 90 RVA: 0x00004506 File Offset: 0x00002706
		public override void HorizontalWingSpeeds(Player player, ref float speed, ref float acceleration)
		{
			speed = 18f;
			acceleration *= 3.5f;
		}

		// Token: 0x0600005B RID: 91 RVA: 0x0000451C File Offset: 0x0000271C
		public override void ModifyTooltips(List<TooltipLine> list)
		{
			foreach (TooltipLine line2 in list)
			{
				if (line2.Mod == "Terraria" && line2.Name == "ItemName")
				{
					line2.OverrideColor = new Color?(new Color(40, 50, 60, Main.DiscoB - Main.DiscoB * 18));
				}
			}
		}

		// Token: 0x0600005C RID: 92 RVA: 0x000022B6 File Offset: 0x000004B6
		public TheStaticBlack()
		{
		}
	}
}
