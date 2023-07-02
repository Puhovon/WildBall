using UnityEngine;

namespace Assets.Scripts.Player
{
    public class ParticleFollow : MonoBehaviour
    {
        
        public Transform player;

        void Update()
        {
            transform.position = player.position;
        }
    }
}