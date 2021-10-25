using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterCurrent : MonoBehaviour
{

    private List<Cloth> JellyfishTentacles;

    public int multiplyer;
    // Start is called before the first frame update
    void Start()
    {
        JellyfishTentacles = new List<Cloth>();
        GameObject[] obj = GameObject.FindGameObjectsWithTag("Tentacle");

        foreach (GameObject item in obj)
        {
            JellyfishTentacles.Add(item.GetComponent<Cloth>());
        }

        Debug.Log("Tentacle ammount : " + JellyfishTentacles.Count);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        TentacleMovement();
    }


    private void TentacleMovement()
    {
        foreach (Cloth tentacle in JellyfishTentacles)
        {
            float direction = Mathf.Sin(Time.time) * multiplyer;

            Debug.Log("direction : " + direction);

            tentacle.externalAcceleration = new Vector3(direction, -2, direction );
        }

    }
}
