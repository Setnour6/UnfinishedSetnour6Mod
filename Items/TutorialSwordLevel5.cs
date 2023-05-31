using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
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
			// base.DisplayName.SetDefault("Tutorial Sword Level 5");
			// base.Tooltip.SetDefault("[c/334A59:This is way too deadly ]");
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00002FB4 File Offset: 0x000011B4
		public override void SetDefaults()
		{
			base.Item.damage = 100000;
			base.Item.DamageType = DamageClass.Melee/* tModPorter Suggestion: Consider MeleeNoSpeed for no attack speed scaling */;
			base.Item.width = 4;
			base.Item.height = 4;
			base.Item.useTime = 8;
			base.Item.useAnimation = 8;
			base.Item.useStyle = 1;
			base.Item.knockBack = 20f;
			base.Item.value = 10000000;
			base.Item.rare = 17;
			base.Item.UseSound = SoundID.Item1;
			base.Item.autoReuse = true;
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00003064 File Offset: 0x00001264
		public override void ModifyTooltips(List<TooltipLine> list)
		{
			foreach (TooltipLine line2 in list)
			{
				if (line2.Mod == "Terraria" && line2.Name == "ItemName")
				{
					line2.OverrideColor = new Color?(new Color(50, 255, 255));
				}
			}
		}

		// Token: 0x0600002D RID: 45 RVA: 0x000030EC File Offset: 0x000012EC
		public override void AddRecipes()
		{
			Recipe recipe = /* base */CreateRecipe();
			recipe.AddIngredient(ModContent.ItemType<TutorialSwordLevel4>(), 1);
			recipe.AddIngredient(3467, 999);
			recipe.AddIngredient(3459, 500);
			recipe.AddIngredient(3456, 500);
			recipe.AddIngredient(3530, 250);
			if (ModLoader.TryGetMod("CalamityMod", out Mod calamityMod) && calamityMod.TryFind<ModItem>("ShadowspecBar", out ModItem shadowspecBar)
				&& calamityMod.TryFind<ModItem>("Animus", out ModItem animus)
				&& calamityMod.TryFind<ModItem>("ProfanedSoulCrystal", out ModItem profanedSoulCrystal)
				&& calamityMod.TryFind<ModItem>("TriactisTruePaladinianMageHammerofMight", out ModItem triactisTPMHoM)
				&& calamityMod.TryFind<ModItem>("TriactisTruePaladinianMageHammerofMightMelee", out ModItem triactisTPMHoM_M)
				&& calamityMod.TryFind<ModItem>("Earth", out ModItem earth))
			{
				recipe.AddIngredient(shadowspecBar.Type, 200);
				recipe.AddIngredient(animus.Type, 3);
				recipe.AddIngredient(profanedSoulCrystal.Type, 1);
				recipe.AddIngredient(triactisTPMHoM.Type, 1);
				recipe.AddIngredient(triactisTPMHoM_M.Type, 1);
				recipe.AddIngredient(earth.Type, 1);
			}
			recipe.AddTile(412);
			recipe.Register();
		}

		// Token: 0x0600002E RID: 46 RVA: 0x000022B6 File Offset: 0x000004B6
		public TutorialSwordLevel5()
		{
		}
	}
}
