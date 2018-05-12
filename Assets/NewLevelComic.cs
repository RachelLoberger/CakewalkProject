using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewLevelComic : MonoBehaviour {

	[SerializeField]
	private float delayBeforeLoad = 10f;
	[SerializeField]	
	private string sceneNameToLoad;

	private float timeElapsed;

	private void Update()
	{
		timeElapsed += Time.deltaTime;

		if (timeElapsed > delayBeforeLoad)
			SceneManager.LoadScene (sceneNameToLoad);
	}
}
