using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorManagerScript : MonoBehaviour
{
    // Start is called before the first frame update
    public Material bodyMat;
    public Material subBodyMat;
    Vector2 startPos;
    Vector2 direction;
    public GameObject[] carsPrefab;
    public GameObject instance;
    Vector3 initialPosition;
    Quaternion initialRotation;
    Renderer renderer;
    int index;

    void Start()
    {
        index = 0;
        GameObject[] cars = GameObject.FindGameObjectsWithTag("Respawn");
        bodyMat.color = Color.blue;
        initialPosition = new Vector3(-0.4f, 1.0f, 0.13f);
        // (-90.0f, 0, 27.0f, 1)
        initialRotation = new Quaternion(0f, 0f,0f, 1);
        Instantiate();
        // Material[] myMaterials = vehicle.GetComponent<Renderer>().sharedMaterials;
        // Debug.Log( myMaterials.Length);
        // foreach(Material mat in myMaterials) {
        //     Debug.Log(mat);
        // }
    }

    public void NextButton() {
        if(index < carsPrefab.Length - 1) {
            index++;
            Instantiate();
        }
    }

    public void PreviousButton() {
        if(index > 0) {
            index--;
            Instantiate();
        }
    }

    void Instantiate() {
        GameObject[] cars = GameObject.FindGameObjectsWithTag("Respawn");
        if(cars.Length > 0) {
            foreach(GameObject car in cars) {
                Destroy(car);
            }
        }
        instance = GameObject.Instantiate(carsPrefab[index], initialPosition, initialRotation);
        instance.transform.Rotate(-90.0f, 0, 27.0f);
    }

    // Update is called once per frame
    void Update()
    {
         if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            switch (touch.phase)
            {
                case TouchPhase.Began:
                    startPos = touch.position;
                    break;

                case TouchPhase.Moved:
                    direction = touch.position - startPos;
                    instance.transform.Rotate(0f, 0f, touch.deltaPosition.x);
                    break;

                case TouchPhase.Ended:
                    break;
            }
        }
    }

    public void YellowColorFull(){
        ChangeColor(Color.yellow);
    }

    public void YellowBlackColor(){
        ChangeColor(Color.yellow, Color.black);
    }

    public void RedColorFull(){
        ChangeColor(Color.red);
    }

    public void RedBlackColor(){
        ChangeColor(Color.red, Color.black);
    }

    public void BlueColorFull(){
        ChangeColor(Color.blue);
    }

    public void BlueBlackColor(){
        ChangeColor(Color.blue, Color.black);
    }

    private void ChangeColor(Color body){
            bodyMat.color = body;
            subBodyMat.color = body;
    }

    private void ChangeColor(Color body, Color subBody) {
            bodyMat.color = body;
            subBodyMat.color = subBody;
    }
}
