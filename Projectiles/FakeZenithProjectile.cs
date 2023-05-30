using System;
using Terraria.ModLoader;

namespace UnfinishedSetnour6Mod.Projectiles
{
	// Token: 0x02000003 RID: 3
	public class FakeZenithProjectile : ModProjectile
	{
		// Token: 0x06000002 RID: 2 RVA: 0x00002058 File Offset: 0x00000258
		public override void SetStaticDefaults()
		{
		}

		// Token: 0x06000003 RID: 3 RVA: 0x0000205A File Offset: 0x0000025A
		public override void SetDefaults()
		{
			base.projectile.CloneDefaults(132);
			this.aiType = 132;
		}

		// Token: 0x06000004 RID: 4 RVA: 0x00002077 File Offset: 0x00000277
		public FakeZenithProjectile()
		{
		}
	}
}
