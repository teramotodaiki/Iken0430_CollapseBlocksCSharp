using UnityEngine;
using System.Collections;

/// <summary>
/// ボールと衝突したとき消滅する
/// </summary>
[RequireComponent(typeof(Collider))]
[AddComponentMenu("C#/Block Controller")]
public class BlockController : MonoBehaviour {

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

        // 自分を消滅させる
        Destroy(gameObject);
    }
}
