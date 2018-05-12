using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine;


public class NewLevel2 : MonoBehaviour {
	public int count;
	//public int index;
	//public string levelName;
	//public int countScene;

	void Start ()
	{
		int count = 0;
		//int countScene = x 1;
	}
	void Update () {
	}

	void OnTriggerEnter (Collider other)
	{
		if (other.gameObject.CompareTag ("PickUp")) 
		{
			other.gameObject.SetActive (false);
			count = count + 1;
			if (count >= 13)
			{
				//SceneManager.LoadScene(index);
				SceneManager.LoadScene(10);
			}
		}
	}

}
