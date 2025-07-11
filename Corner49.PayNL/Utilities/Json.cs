using System.Text.Json;
using System.Text.Json.Serialization;

namespace Corner49.PayNL.Utilities;

public class Json {
	private static readonly JsonSerializerOptions? SerializerOptions = new() {
		WriteIndented = true,
		Converters = { new DateOnlyConverter() },
		NumberHandling = JsonNumberHandling.AllowReadingFromString,
		PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
		DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
	};

	public static string Serialize(object input) {
		return JsonSerializer.Serialize(input, SerializerOptions);
	}
	public static T? Deserialize<T>(string input)
	{
		return JsonSerializer.Deserialize<T>(input, SerializerOptions);
	}

	public static async Task<T?> DeserializeAsync<T>(Stream input) {
		return await JsonSerializer.DeserializeAsync<T>(input, SerializerOptions);
	}


}
