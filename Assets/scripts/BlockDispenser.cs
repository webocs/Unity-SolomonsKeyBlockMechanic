using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockDispenser : MonoBehaviour {
    public GameObject block;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //   gameObject.transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(transform.position), Vector2.zero);
            if(hit.collider == null)
                if (block)
                {
                    Vector2 position = new Vector2(Mathf.RoundToInt(gameObject.transform.position.x), Mathf.RoundToInt(gameObject.transform.position.y));
                    Instantiate(block, position, Quaternion.identity);
                }
        }

    }
}
