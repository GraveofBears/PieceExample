using System.Collections.Generic;
using BepInEx;
using PieceManager;
using ItemManager;

//using ServerSync;


namespace PieceExample
{
	[BepInPlugin(ModGUID, ModName, ModVersion)]
	public class PieceExample : BaseUnityPlugin
	{
		private const string ModName = "PieceExample";
		private const string ModVersion = "0.0.1";
		private const string ModGUID = "org.bepinex.plugins.pieceexample";

		public void Awake()
		{

			//item
			Item CapeBlack = new("guildpack", "CapeBlack ");  //assetbundle name, Asset Name
			CapeBlack.Crafting.Add(CraftingTable.Workbench, 3);
			CapeBlack.RequiredItems.Add("DeerHide", 5);
			CapeBlack.RequiredItems.Add("BoneFragments", 2);
			CapeBlack.RequiredItems.Add("LeatherScraps", 5);
			CapeBlack.RequiredUpgradeItems.Add("DeerHide", 2);
			CapeBlack.RequiredUpgradeItems.Add("BoneFragments", 2);
			CapeBlack.RequiredUpgradeItems.Add("LeatherScraps", 10);
			CapeBlack.CraftAmount = 1;

			//item
			Item ClanShieldBlack = new("guildpack", "ClanShieldBlack");  //assetbundle name, Asset Name
			ClanShieldBlack.Crafting.Add(CraftingTable.Forge, 3);
			ClanShieldBlack.RequiredItems.Add("Iron", 2);
			ClanShieldBlack.RequiredItems.Add("Silver", 2);
			ClanShieldBlack.RequiredItems.Add("FineWood", 10);
			ClanShieldBlack.RequiredUpgradeItems.Add("Silver", 2);
			ClanShieldBlack.RequiredUpgradeItems.Add("Iron", 2);
			ClanShieldBlack.RequiredUpgradeItems.Add("FineWood", 10);
			ClanShieldBlack.CraftAmount = 1;

			//buildpieces
			BuildPiece buildPiece = new("guildpack", "BannerBlack");
			buildPiece.Name.English("BannerBlack");
			buildPiece.Description.English("A Black Guild Banner.");
			buildPiece.RequiredItems.Add("Bronze", 1, false);
			buildPiece.RequiredItems.Add("Iron", 1, false);
			buildPiece.RequiredItems.Add("DeerHide", 4, false);

		}
	}
}
