using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour {

    private NavMeshAgent enemy;

	// Use this for initialization
	void Start () {
        enemy = this.GetComponent<NavMeshAgent>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
