using UnityEngine;
using UnityEngine.UI;

public class PointTowards : MonoBehaviour
{
    public GameObject target;
    public bool fromPlayerPerspective;
    public GameObject player;
    Vector2 prior;
    public Image image;
    bool paused;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        prior = new Vector2(0,0);
    }

    // Update is called once per frame
    void Update()
    {
        if (!paused) {
        Vector3 t = Camera.main.WorldToScreenPoint(target.transform.position);
        Vector2 direction;
        if (!fromPlayerPerspective) {direction = t - transform.position;}
        else {
            direction = t - player.transform.position;
            }
       /* if (direction!=prior) {
            Debug.Log(direction);
            prior = direction;
            }*/
        transform.rotation = Quaternion.FromToRotation(Vector3.up, direction);
        }
    }

    public void ChangeTargetObject (GameObject objectt)
    {
        target = objectt;
    }

    public void Pause(){
        image.color = Color.grey;
        paused = true;
        transform.rotation = Quaternion.identity;
    }

        public void Unpause(){
        image.color = Color.white;
        paused = false;
    }

}
