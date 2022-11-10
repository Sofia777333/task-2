using System;
using System.Collections.Generic;


namespace Village
{
    class Village : IComparable<Village>
    {
        public int Population { get; set; }
        public double Area { get; set; }

        public Village(int population, double area)
        {
            Population = population;
            Area = area;
        }

        public Village(object p)
        {
        }

        public static Village operator +(Village lhs, Village rhs)
        {
            return new Village(lhs.Population + rhs.Population, lhs.Area + rhs.Area);
        }
        public static Village operator *(Village village, int value)
        {
            return new Village(village.Population * value, village.Area * value);
        }

        public static bool operator ==(Village lhs, Village rhs) => lhs.CompareTo(rhs) == 0;

        public static bool operator !=(Village lhs, Village rhs) => !(lhs == rhs);
        public static bool operator >(Village lhs, Village rhs) => lhs.CompareTo(rhs) == 1;
        public static bool operator <(Village lhs, Village rhs) => lhs.CompareTo(rhs) == -1;
        public static bool operator >=(Village lhs, Village rhs) => lhs.CompareTo(rhs) >= 0;
        public static bool operator <=(Village lhs, Village rhs) => lhs.CompareTo(rhs) <= 0; public int CompareTo(Village other)
        {
            if (Population > other.Population)
                return 1;
            if (Population < other.Population)
                return -1;
            return 0;
        }
        public override string ToString() => $"Население: {Population}; Площадь: {Area}";
    }

}  

