using Aircompany.Models;
using System;

namespace Aircompany.Planes
{
    public class PassengerPlane : Plane
    {
        private int _passengersCapacity;

        public PassengerPlane(PlaneSpecification planeSpecification, int passengersCapacity)
            : base(planeSpecification)
        {
            _passengersCapacity = passengersCapacity;
        }

        public override bool Equals(object obj)
        {
            PassengerPlane plane = obj as PassengerPlane;
            return plane != null &&
                   base.Equals(obj) &&
                   _passengersCapacity == plane._passengersCapacity;
        }

        public override int GetHashCode()
        {
            int hashCode = 751774561;
            hashCode = hashCode * -1521134295 + base.GetHashCode();
            hashCode = hashCode * -1521134295 + _passengersCapacity.GetHashCode();
            return hashCode;
        }

        public int GetPassengersCapacity()
        {
            return _passengersCapacity;
        }


        public override string ToString()
        {
            return base.ToString().Replace("}",
                    ", passengersCapacity=" + _passengersCapacity +
                    '}');
        }

    }
}
