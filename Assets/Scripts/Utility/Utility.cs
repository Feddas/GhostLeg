using UnityEngine;
using System.Collections;

public class Utility : MonoBehaviour {
	
	private static GameObject LineScreen;
	
	public static GameObject MakeALine(Vector2 start, Vector2 end)
	{
		Vector3 start3 = new Vector3(start.x, start.y, 0);
		Vector3 end3 = new Vector3(end.x, end.y, 0);
		
		GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
		cube.transform.position = Vector3.Lerp(start3, end3, 0.5f);
		cube.transform.LookAt(end3);
		cube.transform.localScale = new Vector3(0.2f, 0.2f, Vector3.Distance(start3, end3));
		return cube;
	}
	
	public static void MakeScreen()
	{
		if (LineScreen == null)
		{
			Vector3 start3 = new Vector3(-11, 8, -1f);
			Vector3 end3 = new Vector3(11, 2, 1f);
			
			GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
			cube.transform.position = Vector3.Lerp(start3, end3, 0.5f);
			//cube.transform.LookAt(end3);
			cube.transform.localScale = new Vector3(22f, 8.5f, 2f);
			LineScreen = cube;
		}
	}
	
	public static void RemoveScreen()
	{
		if (LineScreen != null)
		{
			Utility.DestroyObject(LineScreen);	
		}
	}
}
