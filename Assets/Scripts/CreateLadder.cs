using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class CreateLadder : MonoBehaviour
{
	IList<Player> players = new List<Player>();
	
	// Use this for initialization
	void Start ()
	{
		for (int i = -10; i <= 10; i+=5) //five players at x coord -10, -5, 0, 5, 10
		{
			//create vertical line for player
			Utility.MakeALine(new Vector2(i, 0), new Vector2(i, 10));
			players.Add(new Player(i));
		}
		
		connectToTheRight(0);
		connectToTheRight(1);
		connectToTheRight(2);
		connectToTheRight(3);
	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}
	
	void connectToTheRight(int playerIndex)
	{
		List<int> jointsHere = new List<int>();
		List<int> jointsThere = new List<int>();
		
		for (int i = 0, jointIndex; i < 4; i++)
		{
			//pick a random joint from here
			jointIndex = Random.Range(0, players[playerIndex].AvailableJoints.Count);
			jointsHere.Add(players[playerIndex].AvailableJoints[jointIndex]);
			players[playerIndex].AvailableJoints.RemoveAt(jointIndex);
			
			//pick a random joint from there
			jointIndex = Random.Range(0, players[playerIndex+1].AvailableJoints.Count);
			jointsThere.Add(players[playerIndex+1].AvailableJoints[jointIndex]);
			players[playerIndex+1].AvailableJoints.RemoveAt(jointIndex);
		}
		
		jointsHere.Sort();
		jointsThere.Sort();
		
		for (int i = 0; i < jointsHere.Count; i++)
		{
			players[playerIndex].ConnectTo(jointsHere[i], players[playerIndex+1], jointsThere[i]);
		}
	}
}
