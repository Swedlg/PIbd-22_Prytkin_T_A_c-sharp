using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAtackAircraft
{
    class PlaneComparer : IComparer<FlyingTransport>
    {

        public int Compare(FlyingTransport firstFlyingTransport, FlyingTransport secondFlyingTransport)
        {
            if (firstFlyingTransport.GetType().Name != secondFlyingTransport.GetType().Name)
            {
                if (firstFlyingTransport is Plane && secondFlyingTransport is AttackAircraft)
                {
                    return 1;
                }
                else
                {
                    return -1;
                }
            }

            if (firstFlyingTransport is AttackAircraft && secondFlyingTransport is AttackAircraft)
            {
                return ComparerAttackAircraft(firstFlyingTransport as AttackAircraft, secondFlyingTransport as AttackAircraft);

            }
            if (firstFlyingTransport is Plane && secondFlyingTransport is Plane)
            {
                return ComparerPlane(firstFlyingTransport as Plane, secondFlyingTransport as Plane);
            }

            return 0;
        }

        private int ComparerPlane(Plane firstPlane, Plane secondPlane)
        {
            if (firstPlane.MaxSpeed != secondPlane.MaxSpeed)
            {
                return firstPlane.MaxSpeed.CompareTo(secondPlane.MaxSpeed);
            }
            if (firstPlane.Weight != secondPlane.Weight)
            {
                return firstPlane.Weight.CompareTo(secondPlane.Weight);
            }
            if (firstPlane.MainColor != secondPlane.MainColor)
            {
                return firstPlane.MainColor.Name.CompareTo(secondPlane.MainColor.Name);
            }
            if (firstPlane.Propeller != secondPlane.Propeller)
            {
                return firstPlane.Propeller.CompareTo(secondPlane.Propeller);
            }
            if (firstPlane.Сhassis != secondPlane.Сhassis)
            {
                return firstPlane.Сhassis.CompareTo(secondPlane.Сhassis);
            }
            if (firstPlane.Antenna != secondPlane.Antenna)
            {
                return firstPlane.Antenna.CompareTo(secondPlane.Antenna);
            }
            return 0;
        }

        private int ComparerAttackAircraft(AttackAircraft firstAttackAircraft, AttackAircraft secondAttackAircraft)
        {
            var res = ComparerPlane(firstAttackAircraft, secondAttackAircraft);
            if (res != 0)
            {
                return res;
            }
            if (firstAttackAircraft.DopColor != secondAttackAircraft.DopColor)
            {
                return firstAttackAircraft.DopColor.Name.CompareTo(secondAttackAircraft.DopColor.Name);
            }
            if (firstAttackAircraft.Rockets != secondAttackAircraft.Rockets)
            {
                return firstAttackAircraft.Rockets.CompareTo(secondAttackAircraft.Rockets);
            }
            if (firstAttackAircraft.Bombs != secondAttackAircraft.Bombs)
            {
                return firstAttackAircraft.Bombs.CompareTo(secondAttackAircraft.Bombs);
            }
            return 0;
        }
    }
}
