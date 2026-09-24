using UnityEngine;

public class Cubecontrolscript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // s = x t  s- distance = u (velocity) * t (time)

        if (Input. GetKey(KeyCode.UpArrow))
        transform.position +=  Vector3.up * Time.deltaTime;
    }
}
