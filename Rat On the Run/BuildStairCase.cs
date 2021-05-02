using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildStairCase : MonoBehaviour {

    public GameObject stepPrefab;
    // Use this for initialization
    void Start()
    {
        Vector3 centerBottom = gameObject.transform.position;
        float radius = 5f;
        float angleDegrees = 10f;
        float angleRadians = angleDegrees * Mathf.PI / 180f;
        for (var i = 0; i < 100; i++)
        {
            float x = radius * Mathf.Cos(i * angleRadians);
            float z = radius * Mathf.Sin(i * angleRadians);
            Vector3 pos = new Vector3(centerBottom.x + x, centerBottom.y + i * .2f, centerBottom.z + z);
            Quaternion rot = new Quaternion();
            GameObject step = Instantiate(stepPrefab, pos, rot);
            step.transform.Rotate(0, -i * angleDegrees, 0);
        }
    }

    // Update is called once per frame
    void Update () {
		
	}
}
