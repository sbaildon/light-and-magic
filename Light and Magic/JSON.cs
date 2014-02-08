using System;
using System.Collections;
using Microsoft.SPOT;
using Json.NETMF;

namespace Light_and_Magic {
	class JSON {
		public static string Encode(Hashtable table) {
			ArrayList datasets = new ArrayList();

			foreach (DictionaryEntry entry in table) {
				Hashtable dataset = new Hashtable();
				dataset.Add("id", entry.Key.ToString());
				dataset.Add("current_value", entry.Value.ToString());
				datasets.Add(dataset);
;			}

			Hashtable json = new Hashtable();
			json.Add("version", "1.0.0");
			json.Add("datastreams", datasets);

			return JsonSerializer.SerializeObject(json);
		}
	}
}