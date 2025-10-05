using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedDataRepository
{
    public class clsCourses
    {
        public int id { get; set; }
        public string Title { get; set; }

        public override bool Equals(object? obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj is not clsCourses s) return false;

            clsCourses neobj = (clsCourses)obj;

            return this.id == neobj.id && string.Equals(neobj.Title, this.Title);
        }
        public override int GetHashCode()
        {
            int hash = 17;
            hash = hash * 23 + id.GetHashCode();
            hash = hash * 23 + Title.GetHashCode();

            return hash;
        }

        public static bool operator ==(clsCourses left, clsCourses right)
        {
            if (ReferenceEquals(left, right)) return true;
            if (left is null || right is null) return false;

            return left.Equals(right);
        }
        public static bool operator !=(clsCourses left, clsCourses right)
        {
            return !(left == right);
        }
    }
}
