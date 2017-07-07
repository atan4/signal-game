using UnityEngine;
using System.Collections;

public class Play : MonoBehaviour {

	public bool isStart;
	public bool isQuit;

		void OnMouseUp(){
		if(gameObject.name == "start")
		{
			Application.LoadLevel(1);
		}

	} 
}