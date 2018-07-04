using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimetableOfClasses
{
    public class MObject
    {
        protected Dictionary<string, object> keyValuePairs = new Dictionary<string, object>();
        public MObject()
        {
            keyValuePairs.Add("ID", Guid.NewGuid());
        }
        public MObject(Guid id)
        {
            keyValuePairs.Add("ID", id);
        }
        public string[] GetColumnNames()
        {
            return keyValuePairs.Keys.ToArray();
        }
        public object this[string key]
        {
            get
            {
                object result = null;
                if (keyValuePairs.TryGetValue(key, out result)) return result;
                else throw new Exception("Указан несуществующий ключ");
            }
            set
            {
                if (keyValuePairs.ContainsKey(key)) keyValuePairs.Add(key, value);
                else throw new Exception("Указан несуществующий ключ");
            }
        }
    }
}
