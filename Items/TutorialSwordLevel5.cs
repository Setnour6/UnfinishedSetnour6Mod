using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria.ID;
using Terraria.ModLoader;

namespace UnfinishedSetnour6Mod.Items
{
	// Token: 0x0200000D RID: 13
	public class TutorialSwordLevel5 : ModItem
	{
		// Token: 0x0600002A RID: 42 RVA: 0x00002F92 File Offset: 0x00001192
		public override void SetStaticDefaults()
		{
			base.DisplayName.SetDefault("Tutorial Sword Level 5");
			base.Tooltip.SetDefault("[c/334A59:This is way too deadly ]");
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00002FB4 File Offset: 0x000011B4
		public override void SetDefaults()
		{
			base.item.damage = 100000;
			base.item.melee = true;
			base.item.width = 4;
			base.item.height = 4;
			base.item.useTime = 8;
			base.item.useAnimation = 8;
			base.item.useStyle = 1;
			base.item.knockBack = 20f;
			base.item.value = 10000000;
			base.item.rare = 17;
			base.item.UseSound = SoundID.Item1;
			base.item.autoReuse = true;
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00003064 File Offset: 0x00001264
		public override void ModifyTooltips(List<TooltipLine> list)
		{
			foreach (TooltipLine line2 in list)
			{
				if (line2.mod == "Terraria" && line2.Name == "ItemName")
				{
					line2.overrideColor = new Color?(new Color(50, 255, 255));
				}
			}
		}

		// Token: 0x0600002D RID: 45 RVA: 0x000030EC File Offset: 0x000012EC
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(base.mod);
			recipe.AddIngredient(base.mod.GetItem("TutorialSwordLevel4"), 1);
			recipe.AddIngredient(3467, 999);
			recipe.AddIngredient(3459, 500);
			recipe.AddIngredient(3456, 500);
			recipe.AddIngredient(3530, 250);
			if (ModLoader.GetMod("CalamityMod") != null)
			{
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").ItemType("ShadowspecBar"), 200);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").ItemType("Animus"), 3);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").ItemType("ProfanedSoulCrystal"), 1);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").ItemType("TriactisTruePaladinianMageHammerofMight"), 1);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").ItemType("TriactisTruePaladinianMageHammerofMightMelee"), 1);
				recipe.AddIngredient(ModLoader.GetMod("CalamityMod").ItemType("Earth"), 1);
			}
			recipe.AddTile(412);
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}

		// Token: 0x0600002E RID: 46 RVA: 0x000022B6 File Offset: 0x000004B6
		public TutorialSwordLevel5()
		{
		}
	}
}
