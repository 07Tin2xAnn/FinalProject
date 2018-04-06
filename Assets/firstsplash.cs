using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class firstsplash : MonoBehaviour {

    public void next()
    {
        SceneManager.LoadScene("secondsplash");
    }
}
