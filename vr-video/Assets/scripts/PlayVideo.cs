using System.Collections;
using System.Collections.Generic;
using UnityEngine.Video;
using UnityEngine;

public class PlayVideo : MonoBehaviour {

	[SerializeField]
	private GameObject obj;
	[SerializeField]	
	private GameObject des;

	private IEnumerator coroutine;

	void Start () {

	}
	void FixedUpdate() 
	{
		  Vector3 fwd = transform.TransformDirection(Vector3.forward);
		 	 if (Physics.Raycast(transform.position, fwd, 15)){
       		 	coroutine = Wait(3.0f);
       			StartCoroutine(coroutine);
			  }

	}
	private IEnumerator Wait(float waitTime)
    {
        while (true)
        {
            yield return new WaitForSeconds(waitTime);
			obj.GetComponent<VideoPlayer>().Play();
			des.SetActive(false);
        }
    }

	void Update () {
		
	}


}
