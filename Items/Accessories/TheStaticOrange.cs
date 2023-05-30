using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace UnfinishedSetnour6Mod.Items.Accessories
{
	// Token: 0x02000019 RID: 25
	[AutoloadEquip(new EquipType[] { 10 })]
	public class TheStaticOrange : ModItem
	{
		// Token: 0x06000069 RID: 105 RVA: 0x00004C40 File Offset: 0x00002E40
		public override void SetStaticDefaults()
		{
			base.DisplayName.SetDefault("Orange Static");
			base.Tooltip.SetDefault("[c/7D766E:You feel glitchy from within... ]\n[c/694A8A:You feel as if you have so many friends ]\nMinion and Sentry damage increased by 100%\nMax number of minions and Sentries increased by 6\nMinion knockback increased");
			ItemID.Sets.ItemNoGravity[base.item.type] = true;
			Main.RegisterItemAnimation(base.item.type, new DrawAnimationVertical(4, 15));
		}

		// Token: 0x0600006A RID: 106 RVA: 0x00004C98 File Offset: 0x00002E98
		public override void SetDefaults()
		{
			base.item.width = 24;
			base.item.height = 28;
			base.item.value = 1000000;
			base.item.rare = -11;
			base.item.expert = false;
			base.item.accessory = true;
			base.item.defense = 4;
			base.item.knockBack = 7.5f;
		}

		// Token: 0x0600006B RID: 107 RVA: 0x00004D10 File Offset: 0x00002F10
		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.minionDamage += 1f;
			player.maxMinions += 6;
			player.minionKB += 6f;
			player.maxTurrets += 6;
		}

		// Token: 0x0600006C RID: 108 RVA: 0x00004D60 File Offset: 0x00002F60
		public override void ModifyTooltips(List<TooltipLine> list)
		{
			foreach (TooltipLine line2 in list)
			{
				if (line2.mod == "Terraria" && line2.Name == "ItemName")
				{
					line2.overrideColor = new Color?(new Color(255, 150, 0));
				}
			}
		}

		// Token: 0x0600006D RID: 109 RVA: 0x00004DE8 File Offset: 0x00002FE8
		public override void AddRecipes()
		{
			ModRecipe modRecipe = new ModRecipe(base.mod);
			modRecipe.AddIngredient(base.mod.GetItem("StaticalEssence"), 3);
			modRecipe.AddIngredient(3467, 250);
			modRecipe.AddIngredient(3381, 1);
			modRecipe.AddIngredient(3382, 1);
			modRecipe.AddIngredient(3383, 1);
			modRecipe.AddIngredient(3530, 30);
			modRecipe.AddIngredient(3538, 1);
			modRecipe.AddIngredient(1572, 1);
			modRecipe.AddIngredient(1802, 1);
			modRecipe.AddIngredient(3571, 1);
			modRecipe.AddIngredient(3569, 1);
			modRecipe.AddTile(412);
			modRecipe.SetResult(this, 1);
			modRecipe.AddRecipe();
		}

		// Token: 0x0600006E RID: 110 RVA: 0x000022B6 File Offset: 0x000004B6
		public TheStaticOrange()
		{
		}
	}
}
