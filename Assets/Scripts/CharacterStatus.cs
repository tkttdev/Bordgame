using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterStatus {

	public struct movePoint{
		int x;
		int y;
		public movePoint(int p1,int p2){
			x = p1;
			y = p2;
		}
	}

	public string name;
	public int HP;
	public List<movePoint> movePoints = new List<movePoint>();

	public CharacterStatus(int _HP, int[] _move_x, int [] _move_y){

		if (_move_x.Length != _move_y.Length) {
			Debug.Log ("Initialize Error, _move_x & _move_y Length is not same size. Please check PIECEDIFINE or CharacterStatus!\n");
			return;
		}

		HP = _HP;
		for(int i = 0; i < _move_x.Length; i++){
			movePoints.Add (new movePoint (_move_x [i], _move_y [i]));
		}
	}

}
