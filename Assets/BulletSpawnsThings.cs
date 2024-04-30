using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BulletSpawnsThings: MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    [SerializeField]
    GameObject Place1;
    [SerializeField]
    GameObject place2;

    public Shooting S;
    // Update is called once per frame
    void Update()
    {
        
    }

    // makes two cylinder spawn on either side of the wall whenever the bullet hits something
    // The bullet gets destroyed when it hits the wall
    private void OnCollisionEnter(Collision collision)
    {
        GameObject BulletGO = collision.gameObject;
        GameObject Cylinder = Instantiate(Place1, transform.position, Quaternion.identity);
        GameObject Capsule = Instantiate(place2, transform.position + new Vector3 (0,0,20), Quaternion.identity);
        S.Cylinder.Add(Cylinder);
        S.Capsule.Add(Capsule);

        Destroy(gameObject);
    }
}
