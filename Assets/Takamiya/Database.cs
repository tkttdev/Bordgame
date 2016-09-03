using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Database : MonoBehaviour {

	public string img;

	// Use this for initialization
	void Start () {
		// Insert
		SqliteDatabase sqlDB = new SqliteDatabase("Bordgame.db");

		// Select
		string selectQuery = "select * from General";
		DataTable dataTable = sqlDB.ExecuteQuery(selectQuery);

		foreach(DataRow dr in dataTable.Rows){
			img = (string)dr["Image"];
			//bug.Log ("name:" + name);
		}
	}

	// Update is called once per frame
	void Update () {

	}
}