using Newtonsoft.Json;

namespace uprove_json
{
    public class UProveJSONParser
    {
        #region Properties
        private JsonSerializerSettings Settings = new JsonSerializerSettings();
        #endregion Properties

        public UProveJSONParser()
        {
            Settings.NullValueHandling = NullValueHandling.Ignore;
        }
        
        public T ParseJsonToObject<T>(string jsonToParse)
        {
            return JsonConvert.DeserializeObject<T>(jsonToParse, Settings);
        }

        public string ParseObjectToJson(object objectToParse)
        {
            return JsonConvert.SerializeObject(objectToParse, Settings);
        }
    }
}
