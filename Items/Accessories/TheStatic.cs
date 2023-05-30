using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace UnfinishedSetnour6Mod.Items.Accessories
{
	// Token: 0x02000015 RID: 21
	[AutoloadEquip(new EquipType[] { 10 })]
	public class TheStatic : ModItem
	{
		// Token: 0x06000050 RID: 80 RVA: 0x00003D30 File Offset: 0x00001F30
		public override void SetStaticDefaults()
		{
			base.DisplayName.SetDefault("White Static");
			base.Tooltip.SetDefault("[c/7D766E:You feel glitchy from within... ]\n[c/694A8A:Now you feel like a tank. ]\nEnemies take 25 times contact damage\nDamage reduction increased by 50%\nIncreases life regeneration\nGrants immunity to knockback, fall damage, and fire blocks\nGrants immunity to most debuffs\nAdditionally grants immunity to Suffocation, Venom, Midas, Electrified, and Moon Bite... hopefully\nIncreases length of invincibility after taking damage... hopefully\nEffects of Lava Waders, Spore Sac, and Philosopher's Stone... hopefully");
			ItemID.Sets.ItemNoGravity[base.item.type] = true;
			Main.RegisterItemAnimation(base.item.type, new DrawAnimationVertical(4, 15));
		}

		// Token: 0x06000051 RID: 81 RVA: 0x00003D88 File Offset: 0x00001F88
		public override void SetDefaults()
		{
			base.item.width = 24;
			base.item.height = 28;
			base.item.value = 1000000;
			base.item.rare = 0;
			base.item.expert = false;
			base.item.accessory = true;
			base.item.defense = 20;
			base.item.lifeRegen = 3;
		}

		// Token: 0x06000052 RID: 82 RVA: 0x00003DFC File Offset: 0x00001FFC
		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.thorns += 25f;
			player.lifeRegen += 3;
			player.noKnockback = true;
			player.endurance += 0.5f;
			player.pStone = true;
			player.waterWalk = true;
			player.fireWalk = true;
			player.lavaMax += 480;
			player.longInvince = true;
			player.noFallDmg = true;
			player.starCloak = true;
			player.longInvince = true;
			player.sporeSac = true;
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
			player.buffImmune[68] = true;
			player.buffImmune[69] = true;
			player.buffImmune[70] = true;
			player.buffImmune[72] = true;
			player.buffImmune[144] = true;
			player.buffImmune[145] = true;
		}

		// Token: 0x06000053 RID: 83 RVA: 0x00003F5C File Offset: 0x0000215C
		public override void ModifyTooltips(List<TooltipLine> list)
		{
			foreach (TooltipLine line2 in list)
			{
				if (line2.mod == "Terraria" && line2.Name == "ItemName")
				{
					line2.overrideColor = new Color?(new Color(255, 255, 255));
				}
			}
		}

		// Token: 0x06000054 RID: 84 RVA: 0x00003FE8 File Offset: 0x000021E8
		public override void AddRecipes()
		{
			ModRecipe modRecipe = new ModRecipe(base.mod);
			modRecipe.AddIngredient(base.mod.GetItem("StaticalEssence"), 10);
			modRecipe.AddIngredient(1613, 1);
			modRecipe.AddIngredient(862, 1);
			modRecipe.AddIngredient(535, 1);
			modRecipe.AddIngredient(158, 1);
			modRecipe.AddIngredient(301, 25);
			modRecipe.AddIngredient(3467, 500);
			modRecipe.AddIngredient(3458, 200);
			modRecipe.AddIngredient(3457, 200);
			modRecipe.AddIngredient(3459, 200);
			modRecipe.AddIngredient(3456, 200);
			modRecipe.AddIngredient(3530, 100);
			modRecipe.AddIngredient(3336, 1);
			modRecipe.AddIngredient(908, 1);
			modRecipe.AddTile(412);
			modRecipe.SetResult(this, 1);
			modRecipe.AddRecipe();
		}

		// Token: 0x06000055 RID: 85 RVA: 0x000022B6 File Offset: 0x000004B6
		public TheStatic()
		{
		}
	}
}
