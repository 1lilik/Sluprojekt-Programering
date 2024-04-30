using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    void Start()
    {
        
    
    }
    [SerializeField]
    GameObject ShootingThing;
    int numberOfBullets = 0;
    public List<GameObject> Cylinder = new List<GameObject>();
    public List<GameObject> Capsule = new List<GameObject>();

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            numberOfBullets += 1;
            GameObject Bullet = Instantiate(ShootingThing, transform.position + new Vector3(1, 0, 0), Quaternion.identity);
            Rigidbody BulletRB = Bullet.GetComponent<Rigidbody>();
            BulletRB.velocity = new Vector3(10, 0, 0);

            BulletSpawnsThings BST = Bullet.GetComponent<BulletSpawnsThings>();
            BST.S = this;

            if (numberOfBullets == 2)
            {
                numberOfBullets = 0;
                for (int i = 0; i < Cylinder.Count; i++)
                {
                    Destroy(Cylinder[i]);
                   
                }
                for (int a = 0; a < Capsule.Count; a++)
                {
                    Destroy(Capsule[a]);

                }
            }
        }
    }
}
