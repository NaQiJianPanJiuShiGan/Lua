using UnityEngine;
using System.Collections;

public class Test : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButton(0))
        {
            print(getPosition());
        }
    }
    Vector3 getPosition()
    {
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        Vector3 hitPoint = Vector3.zero;
        if (Physics.Raycast(ray,out hit))
        {
            print("123");
            hitPoint = hit.point;
            Debug.DrawLine(ray.origin, hit.point, Color.red);
        }
        return hitPoint;
    }
   
}
