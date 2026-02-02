using UnityEngine;

public class ScrollBG : MonoBehaviour
{ public GameObject square;
    public Material MaterialBG;
public float speed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //square.transform.position = new Vector3(2,2, square.transform.position.z);
        //square.transform.localEulerAngles = new Vector(0f,0f,30f);
        //square.transform.localScale = new Vector3(2,2, square.transform.localScale.z);

        speed = 2f;

    }

    // Update is called once per frame
    void Update()
    {
        //square.transform.position = new Vector3(square.transform.position.x+speed*Time.deltaTime,square.transform.position.y,square.transform.position.z);
        //square.transform.localScale = new Vector3(square.transform.localScale.x + speed * Time.deltaTime, square.transform.localScale.y + speed * Time.deltaTime, square.transform.localScale.z);
        MaterialBG.mainTextureOffset = new Vector2(MaterialBG.mainTextureOffset.x + speed * Time.deltaTime, MaterialBG.mainTextureOffset.y);
    }
}
