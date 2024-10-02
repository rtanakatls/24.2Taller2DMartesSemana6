using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeveloperController : MonoBehaviour
{
    [SerializeField] private GameObject inputGroupPrefab;
    private LifeController playerLifeController;
    private PlayerShoot playerShoot;
    private PlayerMovement playerMovement;

    

    private void Awake()
    {
        playerLifeController=GameObject.Find("Player").GetComponent<LifeController>();
        playerShoot=GameObject.Find("Player").GetComponent<PlayerShoot>();
        playerMovement=GameObject.Find("Player").GetComponent<PlayerMovement>();
        
    }

    public void Init()
    {
        foreach (Transform t in transform.GetComponentInChildren<Transform>())
        {
            if (t != transform)
            {
                Destroy(t);
            }
        }
        GameObject playerLifeControllerInputGroup = Instantiate(inputGroupPrefab);
        playerLifeControllerInputGroup.transform.parent = transform;
        playerLifeControllerInputGroup.GetComponent<InputGroupController>().RegisterCallback("Player Life",ChangeLife,playerLifeController.Life.ToString());
        
        GameObject playerShootInputGroup = Instantiate(inputGroupPrefab);
        playerShootInputGroup.transform.parent = transform;
        playerShootInputGroup.GetComponent<InputGroupController>().RegisterCallback("Player Bullets",ChangeBullets,playerShoot.Bullets.ToString());

        GameObject playerMovementInputGroup = Instantiate(inputGroupPrefab);
        playerMovementInputGroup.transform.parent = transform;
        playerMovementInputGroup.GetComponent<InputGroupController>().RegisterCallback("Player Speed",ChangeSpeed,playerMovement.Speed.ToString());

    }

    void ChangeLife(string life)
    {
        try 
        {
            playerLifeController.Config(int.Parse(life));
        }
        catch
        {

        }
    }

    void ChangeSpeed(string speed)
    {
        try
        {
            playerMovement.Config(float.Parse(speed));
        }
        catch
        {

        }
    }
    void ChangeBullets(string bullets)
    {
        try
        {
            playerShoot.Config(int.Parse(bullets));
        }
        catch
        {

        }
    }
}
