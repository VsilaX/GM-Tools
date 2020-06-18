//-----------------------------------------------------------------------------
// MAIN
//-----------------------------------------------------------------------------

// Set Title
// Gets the current version from init.cs and suffixes it to the window title
if ($sfVersion)
{
	SFGMGuiWindowCtrl.text = "SF GM Tools " @ $sfGMVersion;
}


// Window Toggle
// Does what it says really
function sfGMWindowToggle(%val)
{
	if (%val)
	{
		if (SFGMGuiWindow.isAwake())
		{
			PlayGui.remove(SFGMGuiWindow);

			// Save the window position
			sfGMSaveWindowPosition();

		} else
		{
			PlayGui.add(SFGMGuiWindow);

			// Sets the window position
			sfGMSetWindowPosition();
		}
	}
}

// Sets window toggle to the ALT + G combo
moveMap.bind(keyboard, "alt g", sfGMWindowToggle);


// Save the window position
function sfGMSaveWindowPosition()
{
	$pref::SFGMTools::WindowPosition = SFGMGuiWindowCtrl.position;

	export("$pref::*", "data/prefs.cs", False);
}


// Sets the window position
function sfGMSetWindowPosition()
{
	SFGMGuiWindowCtrl.position = $pref::SFGMTools::WindowPosition;
}


// Reload GM Tools
// Re-executes the GM Tools (mainly used for Debugging)
function sfGMReloadGMTools(%val)
{
	if (%val)
	{
		onChatMessage("<spush><color:ffff00>SF GM Tools Reloaded<spop>", null, null);

		warn("SF GM Tools Reloaded");

		exec("mod/sf-gm-tools/init.cs");
	}
}

// Sets reload to F11 key
moveMap.bind(keyboard, "F11", sfGMReloadGMTools);


// List Items
// Opens the official lif items search in a handy built-in web window
function sfGMListItems()
{
	openWeb("https://lifeisfeudal.com/billing/gmcommands.php#itemSearch");
}


// Toggle Fly Mode
// Without the need to press F7 and F8 to toggle
// Also forces third person on when disabing
function sfGMToggleFlyMode(%val)
{
	if (%val)
	{
		if (isObject(ServerConnection))
		{
			%co = ServerConnection.getControlObject();

			if (%co.isMethod(isInFlyingCameraMode) && %co.isInFlyingCameraMode())
			{
				// Disble fly mode
				commandToServer('DropPlayerAtCamera');

				// Set third person
				ServerConnection.setFirstPerson(false);

			} else
			{
				// Enable fly mode
				commandToServer('dropCameraAtPlayer');
			}
		}
	}
}

moveMap.bind(keyboard, "alt f", sfGMToggleFlyMode);

// Set Obj Id list
// Clears the list, adds all the gubbins
SFGMGuiobj.clear();
SFGMGuiobj.Add("1510  -  Dahlborne Sourgli", 0);
SFGMGuiobj.Add("1511  - Unwart The Gravedigger", 1);
SFGMGuiobj.Add("1512  -  Solef Oroskarpe", 2);
SFGMGuiobj.Add("1513  -  Wranen the Hunter", 3);
SFGMGuiobj.Add("1514  -  Yermyk Khtyn", 4);
SFGMGuiobj.Add("1516  -  Assel", 5);
SFGMGuiobj.Add("1517  -  Ulf", 6);
SFGMGuiobj.Add("1519  -  Lodur", 7);
SFGMGuiobj.Add("1520  -  Mara", 8);
SFGMGuiobj.Add("1521  -  Prisoner", 9);
SFGMGuiobj.Add("1153 - Viking + blue tabard", 10);
SFGMGuiobj.Add("1154 - bald spot guy + blue tabard", 11);
SFGMGuiobj.Add("1155 - normal one eye + blue tabard", 12);
SFGMGuiobj.Add("1232 - Long house", 13);
SFGMGuiobj.Add("1233 - Newbie bridge", 14);
SFGMGuiobj.Add("1234 - Broken Bridge", 15);
SFGMGuiobj.Add("1235 - Lots of idols random placed", 16);
SFGMGuiobj.Add("1236 - Woodwall", 17);
SFGMGuiobj.Add("1237 - woodwall large", 18);
SFGMGuiobj.Add("1239 - Drakkar wall", 19);
SFGMGuiobj.Add("1240 - Drakkar wall 4m-1", 20);
SFGMGuiobj.Add("1241 - Drakkar wall 4m-2", 21);
SFGMGuiobj.Add("1166 - Drakkar01", 22);
SFGMGuiobj.Add("1167 - Drakkar02", 23);
SFGMGuiobj.Add("1168 - Drakkar03", 24);
SFGMGuiobj.Add("1169 - Drakkar04", 25);
SFGMGuiobj.Add("1170 - Drakkar05", 26);
SFGMGuiobj.Add("1171 - Drakkar05", 27);
SFGMGuiobj.Add("1172 - DrakkarDebris01", 28);
SFGMGuiobj.Add("1173 - DrakkarSail01", 29);
SFGMGuiobj.Add("1174 - DrakkarSail02", 30);
SFGMGuiobj.Add("1175 - DrakkarSail01 150%", 31);
SFGMGuiobj.Add("1176 - DrakkarSail02 150%", 32);
SFGMGuiobj.Add("1177 - Drakkar07", 33);
SFGMGuiobj.Add("1178 - DrakkarDebris02", 34);
SFGMGuiobj.Add("1179 - DrakkarDebris03", 35);
SFGMGuiobj.Add("1180 - DrakkarDebris04", 36);
SFGMGuiobj.Add("1181 - DrakkarDebris05", 37);
SFGMGuiobj.Add("1182 - DrakkarDebris06", 38);
SFGMGuiobj.Add("1183 - DrakkarDebris07", 39);
SFGMGuiobj.Add("1184 - DrakkarDebris08", 40);
SFGMGuiobj.Add("1185 - DrakkarDebris09", 41);
SFGMGuiobj.Add("1186 - DrakkarDebris10", 42);
SFGMGuiobj.Add("1187 - Drakkar08", 43);
SFGMGuiobj.Add("1190 - Ship_Construct", 44);
SFGMGuiobj.Add("1243 - woodwall", 45);
SFGMGuiobj.Add("1245 - Arena light 1", 46);
SFGMGuiobj.Add("1246 - Arena light 2", 47);
SFGMGuiobj.Add("1250 - White ground glow", 48);
SFGMGuiobj.Add("1251 - LightCollum (Big blue light in the sky)", 49);
SFGMGuiobj.Add("1252 - Canopy_For_Mine", 50);
SFGMGuiobj.Add("1253 - Newbie Island Campfire (Burning)", 51);
SFGMGuiobj.Add("1254 - Yermyk_Khtyn_wooden_beams (pile of logs on ground)", 52);
SFGMGuiobj.Add("1255 - Dahleborne_Sourgli_wood_log", 53);
SFGMGuiobj.Add("1256 - Prisoner_stone_pile", 54);
SFGMGuiobj.Add("1257 - statue_tusgaal", 55);
SFGMGuiobj.Add("1258 - statue_mctir", 56);
SFGMGuiobj.Add("1259 - statue_sovereign", 57);
SFGMGuiobj.Add("1260 - Native Camp Torch v1", 58);
SFGMGuiobj.Add("1261 - Native Camp Torch v2", 59);
SFGMGuiobj.Add("1262 - Native Camp Torch v3", 60);
SFGMGuiobj.Add("1263 - Native Camp Torch v4", 61);
SFGMGuiobj.Add("1264 - Native Camp Torch v5", 62);
SFGMGuiobj.Add("1265 - TribeCamp_Totem_v1", 63);
SFGMGuiobj.Add("1266 - TribeCamp_Totem_v2", 64);
SFGMGuiobj.Add("1456 - Battle challenge totem", 65);
SFGMGuiobj.Add("1460 - Battle challenge totem", 66);
SFGMGuiobj.Add("1539 - siege totem", 67);
SFGMGuiobj.Add("1541 - Village coop", 68);
SFGMGuiobj.Add("1542 - Village Kitchen", 69);
SFGMGuiobj.Add("1543 - Ulfs Blacksmith shop", 70);
SFGMGuiobj.Add("1544 - Ulfs crate", 71);
SFGMGuiobj.Add("1545 - Ulfs chest", 72);
SFGMGuiobj.Add("1546 - Crate of one-armed  (Gives Self-made crucifix and Worn-out pages)", 5);
SFGMGuiobj.Add("1548 - Peasants chest", 73);
SFGMGuiobj.Add("1549 - Dusty crate", 74);
SFGMGuiobj.Add("1550 - Crate of the cook", 75);
SFGMGuiobj.Add("1650 - Lesser Battle Totem", 76);
SFGMGuiobj.Add("1652 - TribeCamp_Shield_v1", 77);
SFGMGuiobj.Add("1653 - TribeCamp_Shield_v2", 78);
SFGMGuiobj.Add("1654 - TribeCamp_Shield_v3", 79);
SFGMGuiobj.Add("1655 - TribeCamp_Shield_v4", 80);
SFGMGuiobj.Add("1656 - TribeCamp_Shield_v5", 81);
SFGMGuiobj.Add("1670 - Oak Belfry (not full)", 82);
SFGMGuiobj.Add("1671 - Bronze Belfry (not full)", 83);
SFGMGuiobj.Add("1673 - TribeCampTree01", 84);
SFGMGuiobj.Add("1674 - TribeCampTree02", 85);
SFGMGuiobj.Add("1675 - TribeCampTree03", 86);
SFGMGuiobj.Add("1676 - TribeCampTree04", 87);
SFGMGuiobj.Add("1677 - TribeCampTree05", 88);
SFGMGuiobj.Add("1678 TribeCAMP_BigShield_v1", 89);
SFGMGuiobj.Add("1679 TribeCAMP_BigShield_v2", 90);
SFGMGuiobj.Add("1680 TribeCAMP_BigShield_v3", 91);
SFGMGuiobj.Add("1681 - Trebuchet_Auto", 92);
SFGMGuiobj.Add("1687 - Native_wall01", 93);
SFGMGuiobj.Add("1688 - Native_wall01_roots", 94);
SFGMGuiobj.Add("1689 - Native_wall02", 95);
SFGMGuiobj.Add("1690 - Native_wall02_rootsv1", 96);
SFGMGuiobj.Add("1691 - Native_wall02_rootsv2", 97);
SFGMGuiobj.Add("1692 - Native_wall03", 98);
SFGMGuiobj.Add("1693 - Native_wall03_roots", 99);
SFGMGuiobj.Add("1694 - Native_wall04", 100);
SFGMGuiobj.Add("1695 - Native_wall04_roots", 101);
SFGMGuiobj.Add("1696 - Native_wall05", 102);
SFGMGuiobj.Add("1697 - Native_wall06", 103);
SFGMGuiobj.Add("1698 - Native_wall07", 104);

SFGMGuiscale.clear();
SFGMGuiscale.Add(".2", 1);
SFGMGuiscale.Add("1", 2);
SFGMGuiscale.Add("2", 3);
SFGMGuiscale.Add("3", 4);
SFGMGuiscale.Add("4", 5);
SFGMGuiscale.Add("5", 6);
SFGMGuiscale.Add("6", 7);
SFGMGuiscale.Add("7", 8);
SFGMGuiscale.Add("8", 9);
SFGMGuiscale.Add("9", 10);
SFGMGuiscale.Add("10", 11);



// Set Animal List
// Clears the list, adds all the gubbins
SFGMGuiAnimal.clear();
SFGMGuiAnimal.Add("AurochsBullData", 0);
SFGMGuiAnimal.Add("AurochsCowData", 1);
SFGMGuiAnimal.Add("BoarData", 2);
SFGMGuiAnimal.Add("SowData", 3);
SFGMGuiAnimal.Add("WolfData", 4);
SFGMGuiAnimal.Add("MuttonData", 5);
SFGMGuiAnimal.Add("MooseData", 6);
SFGMGuiAnimal.Add("HindData", 7);
SFGMGuiAnimal.Add("HareData", 8);
SFGMGuiAnimal.Add("GrouseData", 9);
SFGMGuiAnimal.Add("DeerMaleData", 10);
SFGMGuiAnimal.Add("BearData", 11);
SFGMGuiAnimal.Add("WildhorseData", 12);


//-----------------------------------------------------------------------------
// SET DEFAULT VARIABLES AND PREFS
//-----------------------------------------------------------------------------

// Password
$sfgmPassword = "gm_pass";

if ($pref::SFGMTools::Password  $= "") { $pref::SFGMTools::Password = $sfgmPassword; } else { $sfgmPassword = $pref::SFGMTools::Password; }

SFGMGuiPassword.setText($pref::SFGMTools::Password);


// AddAmount
$sfgmAddAmount = 10;

if ($pref::SFGMTools::AddAmount  $= "") { $pref::SFGMTools::AddAmount = $sfgmAddAmount; } else { $sfgmAddAmount = $pref::SFGMTools::AddAmount; }

SFGMGuiAddAmount.setText($pref::SFGMTools::AddAmount);


// AddQuality
$sfgmAddQuality = 50;

if ($pref::SFGMTools::AddQuality  $= "") { $pref::SFGMTools::AddQuality = $sfgmAddQuality; } else { $sfgmAddQuality = $pref::SFGMTools::AddQuality; }

SFGMGuiAddQuality.setText($pref::SFGMTools::AddQuality);


// AddDurability
$sfgmAddDurability = 5000;

if ($pref::SFGMTools::AddDurability  $= "") { $pref::SFGMTools::AddDurability = $sfgmAddDurability; } else { $sfgmAddDurability = $pref::SFGMTools::AddDurability; }

SFGMGuiAddDurability.setText($pref::SFGMTools::AddDurability);


// TPPlayerName
$sfgmTPPlayerName = "";

if ($pref::SFGMTools::TPPlayerName  $= "") { $pref::SFGMTools::TPPlayerName = $sfgmTPPlayerName; } else { $sfgmTPPlayerName = $pref::SFGMTools::TPPlayerName; }

SFGMGuiTPPlayerName.setText($pref::SFGMTools::TPPlayerName);


// Obj
$sfgmobj = "0";

if ($pref::SFGMTools::obj  $= "") { $pref::SFGMTools::obj = $sfgmobj; } else { $sfgmobj = $pref::SFGMTools::obj; }

SFGMGuiobj.setSelected($sfgmobj);



// KillPlayerName
$sfgmKillPlayerName = "";

if ($pref::SFGMTools::KillPlayerName  $= "") { $pref::SFGMTools::KillPlayerName = $sfgmKillPlayerName; } else { $sfgmKillPlayerName = $pref::SFGMTools::KillPlayerName; }

SFGMGuiKillPlayerName.setText($pref::SFGMTools::KillPlayerName);


// Animal
$sfgmAnimal = "0";

if ($pref::SFGMTools::Animal  $= "") { $pref::SFGMTools::Animal = $sfgmAnimal; } else { $sfgmAnimal = $pref::SFGMTools::Animal; }

SFGMGuiAnimal.setSelected($sfgmAnimal);


// AnimalQuality
$sfgmAnimalQuality = 50;

if ($pref::SFGMTools::AnimalQuality  $= "") { $pref::SFGMTools::AnimalQuality = $sfgmAnimalQuality; } else { $sfgmAnimalQuality = $pref::SFGMTools::AnimalQuality; }

SFGMGuiAnimalQuality.setText($pref::SFGMTools::AnimalQuality);


// EXPORT ALL PREFS
export("$pref::*", "data/prefs.cs", False);
