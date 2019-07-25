using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Record_Looks : MonoBehaviour {
	
	public static ArrayList savedVectors = new ArrayList();
	
	void Start(){

	}


	void Update() {

	}

	public static void add(Vector2 changedPosition){
		this.savedVectors.add(changedPosition);
	}
	
	
}
