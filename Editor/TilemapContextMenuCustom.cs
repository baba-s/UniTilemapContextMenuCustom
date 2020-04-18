using UnityEditor;
using UnityEngine;
using UnityEngine.Tilemaps;

namespace UniTilemapContextMenuCustom
{
	internal static class TilemapContextMenuCustom
	{
		[MenuItem( "CONTEXT/Grid/Clear All Tiles" )]
		private static void ClearAllTilesFromGrid( MenuCommand menuCommand )
		{
			var grid = menuCommand.context as Grid;
			if ( grid == null ) return;
			var tilemap = grid.GetComponentInChildren<Tilemap>();
			if ( tilemap == null ) return;
			tilemap.ClearAllTiles();
		}

		[MenuItem( "CONTEXT/Tilemap/Clear All Tiles" )]
		private static void ClearAllTiles( MenuCommand menuCommand )
		{
			var tilemap = menuCommand.context as Tilemap;
			if ( tilemap == null ) return;
			tilemap.ClearAllTiles();
		}
	}
}