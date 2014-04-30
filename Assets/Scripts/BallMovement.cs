using UnityEngine;
using System.Collections;
/// <summary>
/// ボールに初期速度を与える
/// </summary>
[RequireComponent(typeof(Rigidbody))]
[AddComponentMenu("C#/Ball Movement")]
public class BallMovement : MonoBehaviour {

    /// <summary>
    /// ボールの初期スピード
    /// </summary>
    public float Speed = 20f;

    /// <summary>
    /// ボールが作られた時、最初に実行される
    /// </summary>
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {

        /* 止まっているボールを、スペースキーで動かす処理 */
        if (Input.GetKeyDown(KeyCode.Space)) // スペースキーが押された瞬間だけ、中の処理が行われる
        {
            if (rigidbody.isKinematic == true) // isKinematic ... (運動学的な) ... ここでは、非物理的であるか否かを意味する（動かないボールは、非物理的なので、中の処理に入る）
            {
                
                // isKinematicを false (偽） に設定する ... ここでは、物理的を意味する。
                rigidbody.isKinematic = false;

                // parent ... 追従関係を意味する。 null はドイツ語でゼロを意味する。ここでは、ボールとラケットの追従関係を断ち切っている。
                transform.parent = null;

                // ボールから見て右上に、Speedの早さで一気に初速を与える
                rigidbody.AddForce((transform.forward + transform.right) * Speed, ForceMode.VelocityChange);
            }
        }
	}
}
