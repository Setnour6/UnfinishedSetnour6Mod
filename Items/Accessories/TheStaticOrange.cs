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
	[AutoloadEquip(EquipType.Shield)]
	public class TheStaticOrange : ModItem
	{
		// Token: 0x06000069 RID: 105 RVA: 0x00004C40 File Offset: 0x00002E40
		public override void SetStaticDefaults()
		{
			// base.DisplayName.SetDefault("Orange Static");
			// base.Tooltip.SetDefault("[c/7D766E:You feel glitchy from within... ]\n[c/694A8A:You feel as if you have so many friends ]\nMinion and Sentry damage increased by 100%\nMax number of minions and Sentries increased by 6\nMinion knockback increased");
			ItemID.Sets.ItemNoGravity[base.Item.type] = true;
			Main.RegisterItemAnimation(base.Item.type, new DrawAnimationVertical(4, 15));
		}

		// Token: 0x0600006A RID: 106 RVA: 0x00004C98 File Offset: 0x00002E98
		public override void SetDefaults()
		{
			base.Item.width = 24;
			base.Item.height = 28;
			base.Item.value = 1000000;
			base.Item.rare = -11;
			base.Item.expert = false;
			base.Item.accessory = true;
			base.Item.defense = 4;
			base.Item.knockBack = 7.5f;
		}

		// Token: 0x0600006B RID: 107 RVA: 0x00004D10 File Offset: 0x00002F10
		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.GetDamage(DamageClass.Summon) += 1f;
			player.maxMinions += 6;
			player.GetKnockback(DamageClass.Summon).Base += 6f;
			player.maxTurrets += 6;
		}

		// Token: 0x0600006C RID: 108 RVA: 0x00004D60 File Offset: 0x00002F60
		public override void ModifyTooltips(List<TooltipLine> list)
		{
			foreach (TooltipLine line2 in list)
			{
				if (line2.Mod == "Terraria" && line2.Name == "ItemName")
				{
					line2.OverrideColor = new Color?(new Color(255, 150, 0));
				}
			}
		}

		// Token: 0x0600006D RID: 109 RVA: 0x00004DE8 File Offset: 0x00002FE8
		public override void AddRecipes()
		{
			Recipe modRecipe = /* base */Recipe.Create(this.Type, 1);
			modRecipe.AddIngredient(ModContent.ItemType<Drops.StaticalEssence>(), 3);
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
			modRecipe.Register();
		}

		// Token: 0x0600006E RID: 110 RVA: 0x000022B6 File Offset: 0x000004B6
		public TheStaticOrange()
		{
		}
	}
}
