using System.Collections;

namespace Element
{
    class UserController : IEnumerable, IEnumerator
    {
        readonly Elements[] elem = new Elements[5];

        public Elements this[int index]
        {
            get { return elem[index]; }
            set { elem[index] = value; }
        }

        int position = -1;

        public bool MoveNext()
        {
            if (position < elem.Length - 1)
            {
                position++;
                return true;
            }
            else
            {
                Reset();
                return false;
            }
        }

        public void Reset()
        {
            position = -1;
        }

        public object Current => elem[position];


        public IEnumerator GetEnumerator()
        {
            return this;
        }

    }
}
