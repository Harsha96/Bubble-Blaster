using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class names : MonoBehaviour {


		public float currprog;
		public float maxprog;
		public Slider Pro;
	    public int a;
        public static int l=0;

		// Use this for initialization
		void Start () {

			maxprog = 20f;

			currprog = 1f;
			Pro.value = calprog ();
		}

		// Update is called once per frame
		void Update () {


	//	Debug.Log (ClickBub.Score);
		if (a == ClickBub.Score) {

			if (Input.GetMouseButtonDown (0)) {
				Deal (4);

				//Debug.Log (a);
			}
			a=a+10;
            l = l + 1;
		} 

	}

		void Deal(float save){

			currprog += save;
			Pro.value = calprog ();


		if (currprog > maxprog)
				Die ();

		}

		float calprog(){
			return currprog / maxprog;
		}


		void Die(){
			Debug.Log ("Game over");
		}






	}
