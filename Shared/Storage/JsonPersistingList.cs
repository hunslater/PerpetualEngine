using Newtonsoft.Json;
using System;

namespace PerpetualEngine.Storage
{
    public class JsonPersistingList<T> : PersistentList<T>
    {
        public JsonPersistingList(string editGroup) : base(
            editGroup, 
            (obj) => {
                var str = JsonConvert.SerializeObject(obj);
                return str;
            },
            (str) => {
                try {
                    return JsonConvert.DeserializeObject<T>(str);
                } catch (JsonException e) {
                    Console.WriteLine("could not deserialize '" + str + "'");
                    Console.WriteLine(e.GetType().ToString() + ": " + e.Message);
                    return default(T);
                }
            })
        {
        }
    }
}