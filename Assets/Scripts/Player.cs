using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Player : MonoBehaviour {

	private Rigidbody rd;
    
	public int force = 5;
    public Text text;
    public GameObject winText;
    private int score = 0;    

	// Use this for initialization
	void Start () {
		rd = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
		float h = Input.GetAxis("Horizontal");
		float v = Input.GetAxis("Vertical");
		rd.AddForce(new Vector3(h, 0, v) * force);
	}
    
    //碰撞检测
    void OnCollisionEnter (Collision collision) {
        // collision.collider //碰撞到的物体collider
        // string name = collision.collider.name; //碰撞到的物体名称
        // string tag = collision.collider.tag;
        // Debug.Log(name + tag);
        if (collision.collider.tag == "PickUp") {
            Destroy(collision.collider.gameObject);
        }
    }
    
    //触发检测
    void OnTriggerEnter (Collider collider) {
        if (collider.tag == "PickUp") {
            score++;
            text.text = score.ToString();
            if (score == 11) {
                winText.SetActive(true);
            }
            Destroy(collider.gameObject);
        }
    }
}
