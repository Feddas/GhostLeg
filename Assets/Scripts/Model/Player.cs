using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class Player {
	public int XIndex { get; set; }
	public IList<int> AvailableJoints { get; set; }
	public IList<LadderRung> ConnectionsToTheRight { get; set; }
	
	public Player(int xIndex)
	{
		XIndex = xIndex;
		AvailableJoints = Enumerable.Range(1, 9).ToList();
		ConnectionsToTheRight = new List<LadderRung>();
	}
	
	public void ConnectTo(int jointHere, Player player, int jointThere)
	{
		ConnectionsToTheRight.Add(new LadderRung(jointHere, player, jointThere));
		Utility.MakeALine(new Vector2(XIndex, jointHere), new Vector2(XIndex+5, jointThere));
	}
}
