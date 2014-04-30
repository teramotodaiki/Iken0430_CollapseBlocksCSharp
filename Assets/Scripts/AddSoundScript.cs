using UnityEngine;
using System.Collections;

/// <summary>
/// コライダに衝突が起こった時に、設定されたサウンドを再生します。
/// </summary>
[RequireComponent(typeof(Collider))]
[AddComponentMenu("C#/Add Sound Script")]
public class AddSoundScript : MonoBehaviour {
    /// <summary>
    /// 鳴らしたいサウンド
    /// </summary>
    public AudioClip Sound;

	// Use this for initialization
	void Start () {
	    
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    /// <summary>
    /// このオブジェクトと他のオブジェクトが衝突を起こした時に呼び出される
    /// </summary>
    /// <param name="collision">衝突に関する情報</param>
    void OnCollisionEnter(Collision collision)
    {

        // soundを、オブジェクトの位置で再生（自動的に3D音声になる）する
        AudioSource.PlayClipAtPoint(Sound, transform.position);
    }
}
