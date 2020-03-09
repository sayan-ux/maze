
using UnityEngine;

public class gun : MonoBehaviour
{
    public float damage = 10f;
        public float range = 100f;

    public Camera fpscam;
    public ParticleSystem mf;
    public GameObject imef;
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            shoot();
        }
        
    }
    void shoot()
    {
        mf.Play();
        RaycastHit hit;
        if(Physics.Raycast(fpscam.transform.position, fpscam.transform.forward, out hit, range))
        {
            Debug.Log(hit.transform.name);

            target tg = hit.transform.GetComponent<target>();
	    
            if (tg != null)
            {
                tg.Takedamage(damage);
            }
           GameObject op = Instantiate(imef, hit.point, Quaternion.LookRotation(hit.normal));
            Destroy(op, 2f);
        }
    }
}
