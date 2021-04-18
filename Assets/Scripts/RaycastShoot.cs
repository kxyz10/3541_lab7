using System.Collections;
using UnityEngine;

public class RaycastShoot : MonoBehaviour
{
    public Transform shipNose;
    private Camera camera;                                           
    private WaitForSeconds shotDuration = new WaitForSeconds(0.07f);
    private LineRenderer lineReader;                                        
    private float fireTime;
    public float fireRate = 0.10f;
    public float weaponRange = 1000f;

    void Start()
    {
        lineReader = GetComponent<LineRenderer>();
        camera = Camera.main;
    }


    void Update()
    {
        if (Input.GetKey(KeyCode.LeftShift) && Time.time > fireTime)
        {
            fireTime = Time.time + fireRate;
            StartCoroutine(ShotEffect());
            Vector3 shotOrigin = camera.ViewportToWorldPoint(new Vector3(0.5f, 0.5f, 0.0f));
            lineReader.SetPosition(0, shipNose.position);
            lineReader.SetPosition(1, shotOrigin + (camera.transform.forward * weaponRange));
            RaycastHit hit;
            if(Physics.Raycast(shotOrigin, shipNose.transform.forward, out hit, weaponRange))
            {
                Destroy(hit.transform.gameObject);
                IncreaseScore();

            }
        }
    }

    void IncreaseScore()
    {
        Debug.Log("Object Hit, Increasing Score");
        return;
    }
    private IEnumerator ShotEffect()
    {
        lineReader.enabled = true;
        yield return shotDuration;
        lineReader.enabled = false;
    }
}
