using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpeningCutSceneTimer : MonoBehaviour
{
        public string targetScene;
        public float delay;

        void Start()
        {
            StartCoroutine(LoadLevelAfterDelay(delay));
        }

        IEnumerator LoadLevelAfterDelay(float delay)
        {
            yield return new WaitForSeconds(delay);
            Application.LoadLevel(targetScene);
        }
}
