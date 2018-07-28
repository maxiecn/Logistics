using Newtonsoft.Json;

namespace LogisticsAPI
{
    public class AppUtils
    {
        public static T JsonDeserialize<T>(string jsonString)
        {
            var list = (T) JsonConvert.DeserializeObject(jsonString, typeof (T));
            return list;
        }

        public static string JsonSerializer<T>(T t)
        {return JsonConvert.SerializeObject(t);}
    }
}