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

        // ボールから見て右上に、Speedの早さで一気に初速を与える
        rigidbody.AddForce((transform.forward + transform.right) * Speed, ForceMode.VelocityChange);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
