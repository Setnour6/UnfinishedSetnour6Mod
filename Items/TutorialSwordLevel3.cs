using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using UnfinishedSetnour6Mod.Projectiles;

namespace UnfinishedSetnour6Mod.Items
{
	// Token: 0x0200000B RID: 11
	public class TutorialSwordLevel3 : ModItem
	{
		// Token: 0x0600001F RID: 31 RVA: 0x000029CD File Offset: 0x00000BCD
		public override void SetStaticDefaults()
		{
			// base.DisplayName.SetDefault("Tutorial Sword Level 3");
			// base.Tooltip.SetDefault("A Seriously deadly testing sword that your enemies should avoid. ]\n[c/AB706F:Killing Time! ]\n[c/395933:--I'm terrible at trying to make this weapon fire projectiles, so I need lessons-- ]");
		}

		// Token: 0x06000020 RID: 32 RVA: 0x000029F0 File Offset: 0x00000BF0
		public override void SetDefaults()
		{
			base.Item.damage = 1000;
			base.Item.DamageType = DamageClass.Melee/* tModPorter Suggestion: Consider MeleeNoSpeed for no attack speed scaling */;
			base.Item.width = 100;
			base.Item.height = 100;
			base.Item.useTime = 14;
			base.Item.useAnimation = 14;
			base.Item.useStyle = 1;
			base.Item.knockBack = 8f;
			base.Item.value = 100000;
			base.Item.rare = 12;
			base.Item.UseSound = SoundID.Item1;
			base.Item.autoReuse = true;
			base.Item.useTurn = true;
			base.Item.shoot = ModContent.ProjectileType<TutorialSwordLevel4Projectile>();
			base.Item.shootSpeed = 10f;
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00002ADC File Offset: 0x00000CDC
		public override bool Shoot(Player player, EntitySource_ItemUse_WithAmmo source, Vector2 position, Vector2 velocity, int type, int damage, float knockback)
		{
			int speedX = 2;
			int speedY = 2;
			float numberProjectiles = 1f;
			float rotation = MathHelper.ToRadians(1f);
			position += Vector2.Normalize(new Vector2(speedX, speedY)) * 30f;
			int i = 0;
			while ((float)i < numberProjectiles)
			{
				Vector2 perturbedSpeed = Utils.RotatedBy(new Vector2(speedX, speedY), (double)MathHelper.Lerp(-rotation, rotation, (float)i / (numberProjectiles - 1f)), default(Vector2)) * 0.5f;
				Projectile.NewProjectile(Item.GetSource_FromThis(), player.Center, position, type, damage, knockback, player.whoAmI);
				i++;
			}
			return false;
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00002BA0 File Offset: 0x00000DA0
		public override void AddRecipes()
		{
			CreateRecipe(/*this.Type*/)
			.AddIngredient(3467, 50)
			.AddIngredient(3458, 25)
			.AddIngredient(ModContent.ItemType<TutorialSwordLevel2>(), 1)
			.AddTile(412)
			.Register();
		}

		// Token: 0x06000023 RID: 35 RVA: 0x000022B6 File Offset: 0x000004B6
		public TutorialSwordLevel3()
		{
		}
	}
}
