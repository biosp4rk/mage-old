using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Drawing;
using System.Text.Json;

namespace mage.Theming
{
    class ColorJsonConverter : JsonConverter<Color>
    {
        private static ColorConverter converter = new();

        public override Color Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            return (Color)converter.ConvertFromInvariantString(reader.GetString() ?? "")!;
        }

        public override void Write(Utf8JsonWriter writer, Color value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(converter.ConvertToInvariantString(value));
        }
    }
}
