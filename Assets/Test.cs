using UnityEngine;
using System.Collections;

public class Test : MonoBehaviour {

    private int[] array = {1,3,5,7,13};

	// Use this for initialization
	void Start () {
        Debug.Log("arrayの要素\n");
        foreach(int i in array){
            Debug.Log(i);
        }Debug.Log("\n");
        Debug.Log("逆順表示\n");
        for(int i = array.Length-1; i >= 0; i--){
            Debug.Log(array[i]);
        }
	}

}
