using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ARTouch : MonoBehaviour {
    public GameObject UITest;
    public GameObject froggerVid;

    void Update() {
        // If mouse left click (On PC)
        if (Input.GetMouseButtonDown(0)) {
            Debug.Log("Pressed primary button.");

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, 100)) {
                Debug.Log("hit");
                Debug.Log(hit.transform.name + " : " + hit.transform.tag);

                if (hit.transform.tag == "planet") {
                    Vector3 pos = hit.point;
                    pos.z += 0.25f;
                    pos.y += 0.25f;
                    Instantiate(UITest, pos, transform.rotation);
                }

                if (hit.transform.tag == "frogger") {
                    Vector3 pos = hit.point;
                    pos.z += 0.25f;
                    pos.y += 0.25f;
                    Instantiate(froggerVid, pos, transform.rotation);
                }

                if (hit.transform.tag == "Info") {
                    Destroy(hit.transform.gameObject);
                }

                if (hit.transform.tag == "FroggerVid") {
                    Destroy(hit.transform.gameObject);
                }

            }
        }
    }
}