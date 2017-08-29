using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

/*仕様
 * シーンの切り替えを行うクラス。
 * 処理内容はシーンの初期化、シーンの実行、シーンの終了処理を行う。
 * シーンの初期化等は専用のシーンクラスを作成しそれを呼び出して行う。
 */

public class SceneManager : MonoBehaviour {

    public enum SceneState
    {
        TITLE,
        MAIN,
        RESULT,
        HOWTO,

        NONE
    }

    SceneState _currentScene;
    SceneState _nextScene;


	// Use this for initialization
	void Start () {
        _currentScene = SceneState.NONE;
        _nextScene    = SceneState.TITLE;
    }
	
	// Update is called once per frame
	void Update () {
        //シーンの切り替え
		if(_nextScene != SceneState.NONE)
        {

            //現シーンの終了処理
            switch (_currentScene)
            {
                case SceneState.TITLE:

                    break;

                case SceneState.MAIN:

                    break;
            }

            switch (_nextScene)
            {
                case SceneState.TITLE:

                    break;

                case SceneState.MAIN:

                    break;
            }



        }



	}
}
