using System;

namespace CSClass2
{
    class Child : Parent, IDisposable, IComparable<Child>
    {
        public int CompareTo(Child other)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}