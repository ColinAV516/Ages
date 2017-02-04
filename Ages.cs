using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;


namespace Ages
{
	public class Ages : Mod
	{
		public Ages()
		{
			Properties = new ModProperties()
			{
				Autoload = true,
				AutoloadGores = true,
				AutoloadSounds = true,
                AutoloadBackgrounds = true
            };
		}


	}
}