using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ModLoader;

namespace UnfinishedSetnour6Mod.Items.Accessories
{
	// Token: 0x02000014 RID: 20
	[AutoloadEquip(new EquipType[] { 9 })]
	public class StaticWings : ModItem
	{
		// Token: 0x06000048 RID: 72 RVA: 0x00003ABC File Offset: 0x00001CBC
		public override void SetStaticDefaults()
		{
			base.DisplayName.SetDefault("Static Wings");
			base.Tooltip.SetDefault("Allows incredible flight and slow fall");
			Main.RegisterItemAnimation(base.item.type, new DrawAnimationVertical(4, 15));
		}

		// Token: 0x06000049 RID: 73 RVA: 0x00003AF6 File Offset: 0x00001CF6
		public override void SetDefaults()
		{
			base.item.width = 22;
			base.item.height = 20;
			base.item.rare = 11;
			base.item.accessory = true;
		}

		// Token: 0x0600004A RID: 74 RVA: 0x00003B2B File Offset: 0x00001D2B
		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			if (player.velocity.Y == 0f)
			{
				player.accRunSpeed = 12f;
				player.moveSpeed += 1f;
			}
			player.wingTimeMax = 600;
		}

		// Token: 0x0600004B RID: 75 RVA: 0x00003B67 File Offset: 0x00001D67
		public override void VerticalWingSpeeds(Player player, ref float ascentWhenFalling, ref float ascentWhenRising, ref float maxCanAscendMultiplier, ref float maxAscentMultiplier, ref float constantAscend)
		{
			ascentWhenFalling = 1.1f;
			ascentWhenRising = 0.7f;
			maxCanAscendMultiplier = 5f;
			maxAscentMultiplier = 3f;
			constantAscend = 0.8f;
			base.VerticalWingSpeeds(player, ref ascentWhenFalling, ref ascentWhenRising, ref maxCanAscendMultiplier, ref maxAscentMultiplier, ref constantAscend);
		}

		// Token: 0x0600004C RID: 76 RVA: 0x00003B9E File Offset: 0x00001D9E
		public override void HorizontalWingSpeeds(Player player, ref float speed, ref float acceleration)
		{
			speed = 25f;
			acceleration *= 30f;
			base.HorizontalWingSpeeds(player, ref speed, ref acceleration);
		}

		// Token: 0x0600004D RID: 77 RVA: 0x00003BBC File Offset: 0x00001DBC
		public override void ModifyTooltips(List<TooltipLine> list)
		{
			foreach (TooltipLine line2 in list)
			{
				if (line2.mod == "Terraria" && line2.Name == "ItemName")
				{
					line2.overrideColor = new Color?(new Color(170, 160, 170));
				}
			}
		}

		// Token: 0x0600004E RID: 78 RVA: 0x00003C48 File Offset: 0x00001E48
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(base.mod);
			recipe.AddIngredient(base.mod.GetItem("StaticalEssence"), 8);
			recipe.AddIngredient(3467, 500);
			recipe.AddIngredient(3458, 20);
			recipe.AddIngredient(3457, 20);
			recipe.AddIngredient(3459, 20);
			recipe.AddIngredient(3456, 20);
			recipe.AddIngredient(3530, 50);
			recipe.AddIngredient(2609, 1);
			recipe.AddIngredient(3883, 1);
			recipe.AddIngredient(575, 60);
			if (ModLoader.GetMod("AlchemistNPC") != null)
			{
				recipe.AddIngredient(ModLoader.GetMod("AlchemistNPC").ItemType("EmagledFragmentation"), 120);
			}
			recipe.AddTile(412);
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}

		// Token: 0x0600004F RID: 79 RVA: 0x000022B6 File Offset: 0x000004B6
		public StaticWings()
		{
		}
	}
}
