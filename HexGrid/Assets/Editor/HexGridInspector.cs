using UnityEditor;
using UnityEngine;
using System.Collections;

[CustomEditor(typeof(HexGrid))]
public class GridInspector : Editor {

	public override void OnInspectorGUI() {
		base.OnInspectorGUI();
		HexGrid grid = target as HexGrid;

		if(GUILayout.Button("Generate Hex Grid"))
			grid.GenerateGrid();

		if(GUILayout.Button("Clear Hex Grid"))
			grid.ClearGrid();
	}
}