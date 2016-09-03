using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

	enum STATUS {
		PLAYING,
		WAITING,
	};

	const int stageWidth = 9;
	const int stageHeight = 9;
	GameObject targetingPiece;

	STATUS status = STATUS.WAITING;

	void Awake(){
		Debug.Log(PIECEDEFINE.test.HP);
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButton (0)) {
			RaycastHit hit;
			Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
			if (Physics.Raycast (ray, out hit)) {
				if (hit.transform.tag == "Piece") {
					
				}
			}
		}
	}
}
