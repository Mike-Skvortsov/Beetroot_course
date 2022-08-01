using System.Collections.Generic;

namespace homework35.ASP.Net.Core._2._0
{
    public class Storage<T>
    {
        private static Storage<T> _instance;
        private List<T> _data;
        public static Storage<T> Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Storage<T>();
                }
                return _instance;
            }
        }

        private Storage()
        {
            _data = new List<T>();
        }

        public IReadOnlyCollection<T> GetAll()
        {
            return _data;
        }

        public void Add(T item)
        {
            _data.Add(item);
        }
        public void Update(T item, int index) => _data[index] = item;
        public void Delete(int id) => _data.RemoveAt(id);
        public T Get(int index) => _data[index];
    }
}
