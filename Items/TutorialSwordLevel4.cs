using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using UnfinishedSetnour6Mod.Projectiles;

namespace UnfinishedSetnour6Mod.Items
{
	// Token: 0x0200000C RID: 12
	public class TutorialSwordLevel4 : ModItem
	{
		// Token: 0x06000024 RID: 36 RVA: 0x00002C01 File Offset: 0x00000E01
		public override void SetStaticDefaults()
		{
			// base.DisplayName.SetDefault("Tutorial Sword Level 4");
			// base.Tooltip.SetDefault("A seriously deadly testing sword that is so powerful against many things! ]\n[c/334A59:Relying on the sword itself is a good option, since no projectiles will be launched from the sword...]\n[c/395933:--I'm terrible at trying to make this weapon fire projectiles, so I need lessons-- ]\n[c/395933:--Hopefully I get this right...-- ]");
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00002C24 File Offset: 0x00000E24
		public override void SetDefaults()
		{
			base.Item.damage = 10000;
			base.Item.DamageType = DamageClass.Melee/* tModPorter Suggestion: Consider MeleeNoSpeed for no attack speed scaling */;
			base.Item.width = 4;
			base.Item.height = 4;
			base.Item.useTime = 8;
			base.Item.useAnimation = 10;
			base.Item.useStyle = 1;
			base.Item.knockBack = 10f;
			base.Item.value = 1000000;
			base.Item.rare = 12;
			base.Item.UseSound = SoundID.Item1;
			base.Item.autoReuse = true;
			base.Item.useTurn = true;
			base.Item.shoot = ModContent.ProjectileType<TutorialSwordLevel4Projectile>();
			base.Item.shootSpeed = 40f;
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00002D0C File Offset: 0x00000F0C
		public override bool Shoot(Player player, EntitySource_ItemUse_WithAmmo source, Vector2 position, Vector2 velocity, int type, int damage, float knockback)
		{
			float numberProjectiles = 2f;
			float rotation = MathHelper.ToRadians(2f);
			position += Vector2.Normalize(new Vector2(2, 2)) * 40f;
			int i = 0;
			while ((float)i < numberProjectiles)
			{
				Vector2 perturbedSpeed = Utils.RotatedBy(new Vector2(2, 2), (double)MathHelper.Lerp(-rotation, rotation, (float)i / (numberProjectiles - 1f)), default(Vector2)) * 0.6f;
				Projectile.NewProjectile(source, position, perturbedSpeed, type, damage, (int)knockback, player.whoAmI, 0f, 0f);
				i++;
			}
			return false;
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00002DD0 File Offset: 0x00000FD0
		public override void ModifyTooltips(List<TooltipLine> list)
		{
			foreach (TooltipLine line2 in list)
			{
				if (line2.Mod == "Terraria" && line2.Name == "ItemName")
				{
					line2.OverrideColor = new Color?(new Color(179, 121, 121));
				}
			}
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00002E54 File Offset: 0x00001054
		public override void AddRecipes()
		{
			Recipe recipe = /* base */CreateRecipe();
			recipe.AddIngredient(3467, 250);
			recipe.AddIngredient(3458, 100);
			recipe.AddIngredient(ModContent.ItemType<TutorialSwordLevel3>(), 1);
			recipe.AddIngredient(3530, 10);
			if (ModLoader.TryGetMod("CalamityMod", out Mod calamityMod) && calamityMod.TryFind<ModItem>("CoreofCalamity", out ModItem coreOfCalamity)
				&& calamityMod.TryFind<ModItem>("GalacticaSingularity", out ModItem galacticaSingularity)
				&& calamityMod.TryFind<ModItem>("UnholyEssence", out ModItem unholyEssence)
				&& calamityMod.TryFind<ModItem>("Phantoplasm", out ModItem phantoplasm))
			{
				//recipe.AddIngredient(ModLoader.GetMod("CalamityMod").Find<ModItem>("CoreofCalamity").Type, 50);
				recipe.AddIngredient(coreOfCalamity.Type, 50);
				recipe.AddIngredient(galacticaSingularity.Type, 100);
				recipe.AddIngredient(unholyEssence.Type, 100);
				recipe.AddIngredient(phantoplasm.Type, 20);
			}
			if (ModLoader.TryGetMod("ThoriumMod", out Mod thoriumMod) && thoriumMod.TryFind<ModItem>("InfernoEssence", out ModItem infernoEssence))
			{
				recipe.AddIngredient(infernoEssence.Type, 10);
			}
			//if (ModLoader.TryGetMod("JoostMod", out Mod joostMod) && calamityMod.TryFind<ModItem>("Gilameshset", out ModItem gilameshSet)
			//{
			//	recipe.AddIngredient(gilameshSet.Type, 1);
			//}
			recipe.AddTile(412);
			recipe.Register();
		}

		// Token: 0x06000029 RID: 41 RVA: 0x000022B6 File Offset: 0x000004B6
		public TutorialSwordLevel4()
		{
		}
	}
}
