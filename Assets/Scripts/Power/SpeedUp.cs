using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedUp : MonoBehaviour
{
    private void Start() {
        Destroy(this.gameObject, 10f);
    }
    
    private void Update() 
    {
        transform.Rotate(Vector3.up * 20 * Time.deltaTime);
    }

}
