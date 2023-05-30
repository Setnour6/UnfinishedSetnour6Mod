using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace UnfinishedSetnour6Mod.Items.Potions
{
	// Token: 0x02000011 RID: 17
	public class BluePotion : ModItem
	{
		// Token: 0x0600003B RID: 59 RVA: 0x00003626 File Offset: 0x00001826
		public override void SetStaticDefaults()
		{
			base.DisplayName.SetDefault("Blue Potion");
			base.Tooltip.SetDefault("Grants immunity to almost all vanilla debuffs\nShhhh- don't tell Red about this");
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00003648 File Offset: 0x00001848
		public override void SetDefaults()
		{
			base.item.UseSound = SoundID.Item3;
			base.item.useStyle = 2;
			base.item.useTurn = true;
			base.item.useAnimation = 17;
			base.item.useTime = 17;
			base.item.maxStack = 30;
			base.item.consumable = true;
			base.item.width = 20;
			base.item.height = 30;
			base.item.value = Item.sellPrice(0, 1, 0, 0);
			base.item.rare = 9;
			base.item.buffType = base.mod.BuffType("BluePotionBuff");
			base.item.buffTime = 108000;
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00003718 File Offset: 0x00001918
		public override void ModifyTooltips(List<TooltipLine> list)
		{
			foreach (TooltipLine line2 in list)
			{
				if (line2.mod == "Terraria" && line2.Name == "ItemName")
				{
					line2.overrideColor = new Color?(new Color(0, Main.DiscoG, 255 - (int)((double)Main.DiscoG * 0.03)));
				}
			}
		}

		// Token: 0x0600003E RID: 62 RVA: 0x000037B0 File Offset: 0x000019B0
		public override void AddRecipes()
		{
			ModRecipe modRecipe = new ModRecipe(base.mod);
			modRecipe.AddIngredient(678, 30);
			modRecipe.AddIngredient(1612, 1);
			modRecipe.AddIngredient(288, 30);
			modRecipe.AddIngredient(1353, 30);
			modRecipe.AddIngredient(1921, 1);
			modRecipe.AddIngredient(1356, 30);
			modRecipe.AddIngredient(1355, 30);
			modRecipe.AddIngredient(500, 30);
			modRecipe.AddIngredient(2272, 1);
			modRecipe.AddIngredient(2610, 1);
			modRecipe.AddIngredient(2948, 1);
			modRecipe.AddIngredient(2925, 1);
			modRecipe.AddIngredient(3467, 50);
			modRecipe.AddTile(243);
			modRecipe.SetResult(this, 1);
			modRecipe.AddRecipe();
		}

		// Token: 0x0600003F RID: 63 RVA: 0x000022B6 File Offset: 0x000004B6
		public BluePotion()
		{
		}
	}
}
