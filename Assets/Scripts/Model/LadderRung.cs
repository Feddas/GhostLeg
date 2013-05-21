using UnityEngine;
using System.Collections;

public struct LadderRung {
	public int JointHere { get; set; }
	public Player ConnectingTo { get; set; }
	public int JointThere { get; set; }
	
	public LadderRung(int jointHere, Player connectingTo, int jointThere)
	{
		JointHere = jointHere;
		ConnectingTo = connectingTo;
		JointThere = jointThere;
	}
}
