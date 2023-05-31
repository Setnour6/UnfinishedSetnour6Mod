using System;
using Microsoft.Xna.Framework;
using Terraria.ModLoader;

namespace UnfinishedSetnour6Mod.Projectiles
{
	// Token: 0x02000004 RID: 4
	public abstract class TutorialSwordLevel4Projectile : ModProjectile
	{
		// Token: 0x06000005 RID: 5 RVA: 0x00002058 File Offset: 0x00000258
		public virtual void SetAI(float[] ai, int aiType)
		{
		}

		// Token: 0x06000006 RID: 6 RVA: 0x0000207F File Offset: 0x0000027F
		public virtual Vector4 GetFrameV4()
		{
			return new Vector4(0f, 0f, 1f, 1f);
		}

		// Token: 0x06000007 RID: 7 RVA: 0x00002077 File Offset: 0x00000277
		//protected TutorialSwordLevel4Projectile()
		//{
		//}
	}
}
