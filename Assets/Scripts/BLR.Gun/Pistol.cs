using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


namespace BLR.Gun
{
    public class Pistol : BaseGun
{
        [SerializeField]
        private Camera playerCamera;
        [SerializeField]
        private ParticleSystem muzzleFlash;
        [SerializeField]
        private Image hitCroshair;
        [SerializeField]
        private TextMeshProUGUI currentAmmoDisplay;
        [SerializeField]
        private Animator recoilAnimation;

        private float currentAmmo=0;
        private bool canShoot = true;
            
        public override void Shoot()
        {
            
            if (canShoot)
            {
                muzzleFlash.Play();
                recoilAnimation.Play("RecoilAnimation");
                RaycastHit hit;
                if (Physics.Raycast(playerCamera.transform.position, playerCamera.transform.forward, out hit, Range))
                {
                    Debug.Log(hit.transform.tag);
                    Target target = hit.transform.GetComponent<Target>();
                    if (target != null)
                    {
                        target.TakeDamage(Damage);
                        StartCoroutine(ShowHitCrosshair());
                    }
                }
                StartCoroutine(FireRateCounter());
            }
            
        }

        public override void Reload()
        {           
            StartCoroutine(BeginReloading());
        }
        public void DisplayAmmo()
        {
            currentAmmoDisplay.text = currentAmmo + "/" + MagazineSize;

            if (currentAmmo == 0)
            {
                Reload();
            }
        }

        IEnumerator BeginReloading()
        {
            yield return new WaitForSeconds(ReloadSpeed);
            currentAmmo = MagazineSize;
        }
        IEnumerator ShowHitCrosshair()
        {
            hitCroshair.color = new Color(0, 255, 0, 195);
            yield return new WaitForSeconds(0.15f);
            hitCroshair.color = new Color(0, 0, 0,0);
        }
        IEnumerator FireRateCounter()
        {
            canShoot = false;
            currentAmmo--;
            yield return new WaitForSeconds(FireRate);
            canShoot = true;
            
        }
    }
}

