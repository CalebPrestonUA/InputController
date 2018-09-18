using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour {

    public float speed;
    public Transform enemy;
    public Transform lily;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        Vector3 newPosition = Vector3.MoveTowards(enemy.position, lily.position, speed * Time.deltaTime); 
        enemy.position = new Vector3(newPosition.x, -0.89f, 0f);

	}
}
