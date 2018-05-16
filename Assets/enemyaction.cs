using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class enemyaction : MonoBehaviour {

    Transform m_transform;

    Animation m_animation;

    NavMeshAgent m_agent;

    GameObject m_player;

    static float m_moveSpeed = 0.5f;

    float m_rotSpeed = 120;

    

	// Use this for initialization
	void Start () {
        m_transform = this.transform;
        m_animation = this.GetComponent<Animation>();
        m_agent = GetComponent<NavMeshAgent>();
        m_player = GameObject.Find("MobileMaleFreeSimpleMovement1");
	}
	
	// Update is called once per frame
	void Update () {
        m_agent.SetDestination(m_player.transform.position);
        //float speed = m_moveSpeed * Time.deltaTime;
        //m_agent.Move(m_transform.TransformDirection(new Vector3(0, 0, 0)));
	}
}
