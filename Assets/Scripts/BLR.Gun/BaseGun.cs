using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace BLR.Gun
{
    public class BaseGun : MonoBehaviour
    {
        
        private float magazineSize = 10;


        public float Damage=1;
        public float Range=1;
        public float FireRate = 1;
        public float MagazineSize => magazineSize;
        public float ReloadSpeed = 1;
        public float Recoil = 1;

        public virtual void Shoot()
        {

        }
        public virtual void Reload()
        {

        }       
        public virtual void Scope()
        {

        }
    }
}

