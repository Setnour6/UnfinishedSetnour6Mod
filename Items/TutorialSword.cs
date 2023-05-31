using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace UnfinishedSetnour6Mod.Items
{
	// Token: 0x02000009 RID: 9
	public class TutorialSword : ModItem
	{
		// Token: 0x06000017 RID: 23 RVA: 0x000027C9 File Offset: 0x000009C9
		public override void SetStaticDefaults()
		{
			// base.Tooltip.SetDefault("Literally a testing sword");
		}

		// Token: 0x06000018 RID: 24 RVA: 0x000027DC File Offset: 0x000009DC
		public override void SetDefaults()
		{
			base.Item.damage = 10;
			base.Item.DamageType = DamageClass.Melee/* tModPorter Suggestion: Consider MeleeNoSpeed for no attack speed scaling */;
			base.Item.width = 40;
			base.Item.height = 40;
			base.Item.useTime = 20;
			base.Item.useAnimation = 20;
			base.Item.useStyle = 1;
			base.Item.knockBack = 4f;
			base.Item.value = 1000;
			base.Item.rare = 1;
			base.Item.UseSound = SoundID.Item1;
			base.Item.autoReuse = true;
			base.Item.useTurn = true;
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00002896 File Offset: 0x00000A96
		public override void AddRecipes()
		{
			Recipe modRecipe = /* base */Recipe.Create(this.Type, 1);
			modRecipe.AddIngredient(2, 100);
			modRecipe.AddTile(18);
			modRecipe.Register();
		}

		// Token: 0x0600001A RID: 26 RVA: 0x000022B6 File Offset: 0x000004B6
		public TutorialSword()
		{
		}
	}
}
