using System;

namespace wf_poll_cwe
{
    public class Candidate
    {
        public string Name { get; }
        public Guid Id { get; }

        public Candidate(string name)
        {
            Name = name;
            Id = new Guid();
        }

        public bool Equals(Candidate other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return other.Name == Name && other.Id == Id;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != typeof(Candidate)) return false;
            return Equals((Candidate)obj);
        }

        //adapted from "Effective Java" by Josh Bloch
        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + Name.GetHashCode();
                hash = hash * 23 + Id.GetHashCode();
                return hash;
            }
        }
    }
}