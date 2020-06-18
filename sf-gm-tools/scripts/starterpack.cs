//-----------------------------------------------------------------------------
// STARTER PACK
//-----------------------------------------------------------------------------

function sfGMStarterPack()
{
	onChatMessage("<spush><color:FF4500>Spawning Starter Pack<spop>", null, null);

	// ADD [Item ID] [Quantity] [Quality] [Durability]
	doSlashCommand("/ADD 1663 1 50"); // Shovel
	doSlashCommand("/ADD 490 1 50"); // Pickaxe

}
