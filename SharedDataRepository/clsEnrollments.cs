using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedDataRepository
{
    public  class clsEnrollments
    {
        public int StudentId { get; set; }
        public int CourseId { get; set; }
        public int Grade { get; set; }



        public override bool Equals(object? obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(obj, this)) return true;
            //if (this.GetType ()!= obj.GetType()) return false;
            if (obj is not clsEnrollments s) return false;

            clsEnrollments clsEn = (clsEnrollments)obj;
            //var clsEnn = (clsEnrollment)obj;   diff 

            return this.StudentId == clsEn.StudentId && this.CourseId == clsEn.CourseId && this.Grade == clsEn.Grade;
        }
        public override int GetHashCode()
        {
            int hash = 17;
            hash = hash * 23 + StudentId.GetHashCode();
            hash = hash * 23 + CourseId.GetHashCode();
            hash = hash * 23 + Grade.GetHashCode();
            return hash;

        }
        public static bool operator ==(clsEnrollments left, clsEnrollments right)
        {
            if (ReferenceEquals(left, right)) return true;
            if (left is null || right is null) return false;

            return left.Equals(right);


        }
        public static bool operator !=(clsEnrollments left, clsEnrollments right) => !(left == right);
    }
}
