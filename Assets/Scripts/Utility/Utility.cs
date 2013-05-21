using UnityEngine;
using System.Collections;

public class Utility : MonoBehaviour {
	public static void MakeALine(Vector2 start, Vector2 end)
	{
		Vector3 start3 = new Vector3(start.x, start.y, 0);
		Vector3 end3 = new Vector3(end.x, end.y, 0);
		
		GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
		cube.transform.position = Vector3.Lerp(start3, end3, 0.5f);
		cube.transform.LookAt(end3);
		cube.transform.localScale = new Vector3(0.2f, 0.2f, Vector3.Distance(start3, end3));
	}
}
