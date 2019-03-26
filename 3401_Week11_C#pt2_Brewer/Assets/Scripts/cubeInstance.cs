using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubeInstance : MonoBehaviour
{
    public Rigidbody rb;
    public float countdown = 5f;
    float _currentCountdown = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnEnable()
    {
        _currentCountdown = 0;

    }

    // Update is called once per frame
    void Update()
    {
        _currentCountdown = Addlife ();
        if (_currentCountdown > countdown)
        {
            //resets speed of cube when going inactive
            rb.velocity = Vector3.zero;
            rb.angularVelocity = Vector3.zero;
            gameObject.SetActive(false);
        }
    }

    float Addlife()
    {
        _currentCountdown += Time.deltaTime;

        return _currentCountdown;
    }

}
