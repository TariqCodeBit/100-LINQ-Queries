namespace SharedDataRepository
{
    public class clsStudent
    {
        public int id { get; set; }
        public string name { get; set; }
        public int Age { get; set; }

        public override bool Equals(object? obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;

            clsStudent neobj = (clsStudent)obj;

            return this.id == neobj.id && string.Equals(neobj.name, this.name) && neobj.Age == this.Age;
        }
        public override int GetHashCode()
        {
            int hash = 17;
            hash = hash * 23 + id.GetHashCode();
            hash = hash * 23 + name.GetHashCode();
            hash = hash * 23 + Age.GetHashCode();
            return hash;
        }

        public static bool operator ==(clsStudent left, clsStudent right)
        {
            if (ReferenceEquals(left, right)) return true;
            if (left is null || right is null) return false;

            return left.Equals(right);
        }
        public static bool operator !=(clsStudent left, clsStudent right)
        {
            return !(left == right);
        }

    }
}
