using System;

namespace ConsoleApp7
{
    class ArrayList
    {
        public int Count { get; set; }
        public int Capacity { get; set; }
        private object[] _arr;
        public ArrayList(int capacity)
        {
            this.Capacity = capacity;
            _arr = new object[capacity];
        }
        public void Add(object t)
        {
           Array.Resize(ref _arr, _arr.Length + 1);
            _arr[_arr.Length - 1] = t;
        }
        public void RemoveAt(int index)
        {
            for (int i = index; i < _arr.Length - 1; i++)
            {
                _arr[i] = _arr[i + 1];
            }
            Array.Resize(ref _arr, _arr.Length - 1);
        }
        public void Remove(object a)
        {
            
            for (int i = Array.IndexOf(_arr, a); i < _arr.Length - 1; i++)
            {
                _arr[i] = _arr[i + 1];

            }
            Array.Resize(ref _arr, _arr.
                Length - 1);
        }
        public void AddRange(object[] arr)
        {
            foreach (var item in arr)
            {
                Array.Resize(ref _arr, _arr.Length +1);
                _arr[_arr.Length - 1] = item;
            }
        }
        public void GetAll()
        {
            for (int i = 0; i < _arr.Length; i++)
            {
                if (_arr[i] != null)
                {
                    Console.WriteLine(_arr[i]);
                }

            }
        }
        public void TrimToSize()
        {

        }
    }
}

