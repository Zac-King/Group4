using UnityEngine;
using System.Collections;

public class SpawnEnemy : MonoBehaviour
{
    public GameObject enemy;

    public Transform[] spawnPoints;

    private float m_Timer;
    public float  SpawnDelay;

    void Start()
    {
    }

	void Update ()
    {
        m_Timer += Time.deltaTime;

        if (m_Timer >= SpawnDelay)
        {
            m_Timer = 0;
            int pos = Random.Range(0, spawnPoints.Length);
            Instantiate(enemy, spawnPoints[pos].position, transform.rotation);
        }
	}
}
