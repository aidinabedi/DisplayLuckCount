using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;

namespace DisplayLuckCount
{
	public class LuckInfoDisplay : InfoDisplay
	{
		public static LocalizedText DisplayValueText { get; private set; }

		public override void SetStaticDefaults()
		{
			DisplayValueText = this.GetLocalization("DisplayValue");
		}

		public override bool Active()
		{
			return DepthMeter.Active();
		}

		public override string DisplayValue(ref Color displayColor)
		{
			var value = $"{Main.LocalPlayer.luck:0.00}";
			return DisplayValueText.Format(value);
		}
	}
}
