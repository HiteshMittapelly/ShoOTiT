﻿using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {

	public void Hit(){
		Destroy(gameObject);
	}
}
