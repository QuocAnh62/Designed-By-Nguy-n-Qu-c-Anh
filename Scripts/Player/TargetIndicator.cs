using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetIndicator : MonoBehaviour
{
    public Transform target;
    public Transform player;
    public List<MeshRenderer> mesh;
    private float distanceFromPlayer = 2.5f;

    void Update()
    {
        TargetPlayer();
        Show();
    }
    private void TargetPlayer()
    {
        // calculate position between rabbit and player
        Vector3 direction = (target.position - player.position).normalized;

        // this gameObject have tposition nearby player and at a distance 
        transform.position = player.position + direction * distanceFromPlayer; 

        // calculate rotation arrow
        float angle = Mathf.Atan2(direction.z, direction.x) * Mathf.Rad2Deg;

        // Rotation this arrow always follow Rabbit
        transform.rotation = Quaternion.Euler(0, -angle + -90, 0);
    }


    private void Show()
    {
        Vector3 pos = target.position - player.position; // Calculate the position between rabit and player
        if (pos.magnitude <= 4f)
        {
            foreach(MeshRenderer mesh in mesh)
            {
                mesh.enabled = false;
            }            
        }
        else 
        {
            foreach (MeshRenderer mesh in mesh)
            {
                mesh.enabled = true;
            }
        }
    }
}
