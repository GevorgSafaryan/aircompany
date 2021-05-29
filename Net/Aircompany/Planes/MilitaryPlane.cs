using Aircompany.Models;

namespace Aircompany.Planes
{
    public class MilitaryPlane : Plane
    {
        private MilitaryType _type;

        public MilitaryPlane(PlaneSpecification planeSpecification, MilitaryType type)
            : base(planeSpecification)
        {
            _type = type;
        }

        public override bool Equals(object obj)
        {
            MilitaryPlane plane = obj as MilitaryPlane;
            return plane != null &&
                   base.Equals(obj) &&
                   _type == plane._type;
        }

        public override int GetHashCode()
        {
            int hashCode = 1701194404;
            hashCode = hashCode * -1521134295 + base.GetHashCode();
            hashCode = hashCode * -1521134295 + _type.GetHashCode();
            return hashCode;
        }

        public MilitaryType GetMilitaryPlaneType()
        {
            return _type;
        }


        public override string ToString()
        {
            return base.ToString().Replace("}",
                    ", type=" + _type +
                    '}');
        }
    }
}
