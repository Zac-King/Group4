using UnityEngine;
using System.Collections;
    


public class RandomMovement : MonoBehaviour
{
    private float m_timer;
    public float m_delay;
    private Rigidbody rb;

    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }

	void Update () 
    {
        m_timer += Time.deltaTime;

        // move forward by z axis
       // rb.AddForce(Vector3.forward * Random.Range(-1.0f, 1.0f) *  gameObject.GetComponent<EnemyStats>().m_Speed);

        if (m_timer >= m_delay)
        {
            // rotate randomly by x axis
          //  rb.AddForce(Vector3.right * Random.Range(-1.0f, 1.0f) * 10);
            m_timer = 0;
        }
	}
}
