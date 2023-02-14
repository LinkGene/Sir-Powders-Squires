using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TG_ChooseAnimation : MonoBehaviour {

    public string playAnimationName;

	// Use this for initialization
	void Start () {
        this.GetComponent<Animator>().Play(playAnimationName, 0);
	}

}
