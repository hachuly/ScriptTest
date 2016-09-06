using UnityEngine;
using System.Collections;

public class Test_another : MonoBehaviour {

    private int mp = 53;

    void Magic(){
        if(0 <= (mp = mp - 5) ){
            Debug.Log("魔法攻撃をした。残りMPは"+ mp +"。");
         }else{
            Debug.Log("MPが足りないため魔法が使えない。");
         }

    }

	// Use this for initialization
	void Start () {
        for(int i = 0; i < 11; i++){
            Magic();
        }
	}

}
