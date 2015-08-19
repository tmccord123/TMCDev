using System.Text.RegularExpressions;
using System;
using Newtonsoft.Json;
using System.IO;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Data;

namespace TMC.Web.Shared
{
    /// <summary>
    /// Provides static utility methods for data validation purposes,
    /// Author : Nagarro
    /// </summary>
    public static class JsonUtility
    {
        public static bool FormatJsonOutput;

        private const string JSONStartDelimiter = "{";
        private const string JSONEndDelimiter = "}";
        private const string JSONValueDelimiter = ":";
        private const string JSONObjectDelimiter = ",";
        private const string JSONNewLineDelimiter = "\n";
        private const string JSONQuoteDelimiter = "\"";

        /// <summary>
        /// Returns the JSON string
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string Serialize(object value)
        {
            return SerializeToJSON(value, false);
        }

        /// <summary>
        /// Returns the JSON string
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string SerializeWithReplacingDataColumnNameFromDisplayProperty(object value)
        {
            return SerializeToJSON(value, true);
        }

        public static string Serialize<TEnum>()
        {
            var enumValues = Enum.GetValues(typeof (TEnum)).Cast<object>();

            string result = string.Empty;

            result = JSONStartDelimiter;
            result += JSONNewLineDelimiter;

            result += string.Join(JSONObjectDelimiter + JSONNewLineDelimiter,
                                  enumValues.Select(
                                      o => GetEnumName<TEnum>(o) + JSONValueDelimiter + GetEnumValue<TEnum>(o)));

            result += JSONNewLineDelimiter;
            result += JSONEndDelimiter;

            return result;
        }

        public static object Deserialize(string jsonText, Type valueType)
        {
            Newtonsoft.Json.JsonSerializer json = new Newtonsoft.Json.JsonSerializer();

            json.NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore;
            json.ObjectCreationHandling = Newtonsoft.Json.ObjectCreationHandling.Replace;
            json.MissingMemberHandling = Newtonsoft.Json.MissingMemberHandling.Ignore;
            json.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;

            StringReader sr = new StringReader(jsonText);
            Newtonsoft.Json.JsonTextReader reader = new JsonTextReader(sr);
            object result = json.Deserialize(reader, valueType);
            reader.Close();

            return result;
        }

        private static string GetEnumValue<TEnum>(object o)
        {
            return JSONQuoteDelimiter + ((int) o) + JSONQuoteDelimiter;
        }

        private static string GetEnumName<TEnum>(object o)
        {
            return JSONQuoteDelimiter + Enum.GetName(typeof (TEnum), o) + JSONQuoteDelimiter;
        }

        /// <summary>
        /// Retutns the JSON string
        /// </summary>
        /// <param name="value">Value to be serialized</param>
        /// <param name="replaceColumnNameWithDefaultNameProperty">Whether replace column name with default property</param>
        /// <returns></returns>
        private static string SerializeToJSON(object value, bool replaceColumnNameWithDefaultNameProperty)
        {
            Type type = value.GetType();

            Newtonsoft.Json.JsonSerializer json = new Newtonsoft.Json.JsonSerializer();

            json.NullValueHandling = NullValueHandling.Ignore;

            json.ObjectCreationHandling = Newtonsoft.Json.ObjectCreationHandling.Replace;
            json.MissingMemberHandling = Newtonsoft.Json.MissingMemberHandling.Ignore;
            json.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;

            if (type == typeof (DataRow))
                json.Converters.Add(new DataRowConverter(replaceColumnNameWithDefaultNameProperty));
            else if (type == typeof (DataTable))
                json.Converters.Add(new DataTableConverter(replaceColumnNameWithDefaultNameProperty));
            else if (type == typeof (DataSet))
                json.Converters.Add(new DataSetConverter(replaceColumnNameWithDefaultNameProperty));

            StringWriter sw = new StringWriter();
            Newtonsoft.Json.JsonTextWriter writer = new JsonTextWriter(sw);
            writer.DateFormatHandling = DateFormatHandling.MicrosoftDateFormat;
            writer.DateTimeZoneHandling = DateTimeZoneHandling.Unspecified;
            if (FormatJsonOutput)
                writer.Formatting = Formatting.Indented;
            else
                writer.Formatting = Formatting.None;

            writer.QuoteChar = '"';
            json.Serialize(writer, value);

            string output = sw.ToString();
            writer.Close();
            sw.Close();

            return output;
        }

        public class DataRowConverter : JSONDataConverter
        {
            public DataRowConverter(bool replaceColumnNameWithDefaultNameProperty) :
                base(replaceColumnNameWithDefaultNameProperty)
            {
            }

            /// <summary>
            /// Writes the JSON representation of the object.
            /// </summary>
            /// <param name="writer">The <see cref="JsonWriter"/> to write to.</param>
            /// <param name="value">The value.</param>
            public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
            {
                DataRow row = value as DataRow;

                writer.WriteStartObject();
                foreach (DataColumn column in row.Table.Columns)
                {
                    if (this.replaceColumnNameWithDefaultNameProperty)
                    {
                        writer.WritePropertyName(column.ExtendedProperties["DisplayName"].ToString());
                    }
                    else
                    {
                        writer.WritePropertyName(column.ColumnName);
                    }
                    serializer.Serialize(writer, row[column]);
                }
                writer.WriteEndObject();
            }

            /// <summary>
            /// Determines whether this instance can convert the specified value type.
            /// </summary>
            /// <param name="objectType">Type of the value.</param>
            /// <returns>
            ///     <c>true</c> if this instance can convert the specified value type; otherwise, <c>false</c>.
            /// </returns>
            public override bool CanConvert(Type objectType)
            {
                return typeof (DataRow).IsAssignableFrom(objectType);
            }

            /// <summary>
            /// Reads the JSON representation of the object.
            /// </summary>
            /// <param name="reader">The <see cref="JsonReader"/> to read from.</param>
            /// <param name="objectType">Type of the object.</param>
            /// <returns>The object value.</returns>
            public override object ReadJson(JsonReader reader, Type objectType, object existingValue,
                                            JsonSerializer serializer)
            {
                throw new NotImplementedException();
            }
        }

        /// <summary>
        /// Converts a DataTable to JSON. Note no support for deserialization
        /// </summary>
        public class DataTableConverter : JSONDataConverter
        {
            public DataTableConverter(bool replaceColumnNameWithDefaultNameProperty) :
                base(replaceColumnNameWithDefaultNameProperty)
            {
            }

            /// <summary>
            /// Writes the JSON representation of the object.
            /// </summary>
            /// <param name="writer">The <see cref="JsonWriter"/> to write to.</param>
            /// <param name="value">The value.</param>
            public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
            {
                DataTable table = value as DataTable;
                DataRowConverter converter = new DataRowConverter(this.replaceColumnNameWithDefaultNameProperty);

                //writer.WriteStartObject();

                //writer.WritePropertyName("Rows");
                writer.WriteStartArray();
                foreach (DataRow row in table.Rows)
                {
                    converter.WriteJson(writer, row, serializer);
                }
                writer.WriteEndArray();
                //writer.WriteEndObject();
            }

            /// <summary>
            /// Determines whether this instance can convert the specified value type.
            /// </summary>
            /// <param name="objectType">Type of the value.</param>
            /// <returns>
            ///     <c>true</c> if this instance can convert the specified value type; otherwise, <c>false</c>.
            /// </returns>
            public override bool CanConvert(Type objectType)
            {
                return typeof (DataTable).IsAssignableFrom(objectType);
            }

            /// <summary>
            /// Reads the JSON representation of the object.
            /// </summary>
            /// <param name="reader">The <see cref="JsonReader"/> to read from.</param>
            /// <param name="objectType">Type of the object.</param>
            /// <returns>The object value.</returns>
            public override object ReadJson(JsonReader reader, Type objectType, object existingValue,
                                            JsonSerializer serializer)
            {
                throw new NotImplementedException();
            }
        }

        /// <summary>
        /// Converts a <see cref="DataSet"/> object to JSON. No support for reading.
        /// </summary>
        public class DataSetConverter : JSONDataConverter
        {
            public DataSetConverter(bool replaceColumnNameWithDefaultNameProperty) :
                base(replaceColumnNameWithDefaultNameProperty)
            {
            }

            /// <summary>
            /// Writes the JSON representation of the object.
            /// </summary>
            /// <param name="writer">The <see cref="JsonWriter"/> to write to.</param>
            /// <param name="value">The value.</param>
            public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
            {
                DataSet dataSet = value as DataSet;

                DataTableConverter converter = new DataTableConverter(this.replaceColumnNameWithDefaultNameProperty);

                writer.WriteStartObject();

                writer.WritePropertyName("Tables");
                writer.WriteStartArray();

                foreach (DataTable table in dataSet.Tables)
                {
                    converter.WriteJson(writer, table, serializer);
                }
                writer.WriteEndArray();
                writer.WriteEndObject();
            }

            /// <summary>
            /// Determines whether this instance can convert the specified value type.
            /// </summary>
            /// <param name="objectType">Type of the value.</param>
            /// <returns>
            ///     <c>true</c> if this instance can convert the specified value type; otherwise, <c>false</c>.
            /// </returns>
            public override bool CanConvert(Type objectType)
            {
                return typeof (DataSet).IsAssignableFrom(objectType);
            }

            /// <summary>
            /// Reads the JSON representation of the object.
            /// </summary>
            /// <param name="reader">The <see cref="JsonReader"/> to read from.</param>
            /// <param name="objectType">Type of the object.</param>
            /// <returns>The object value.</returns>
            public override object ReadJson(JsonReader reader, Type objectType, object existingValue,
                                            JsonSerializer serializer)
            {
                throw new NotImplementedException();
            }
        }

        /// <summary>
        /// Abstract class used to override JSON converter for Dataset, Datatable and Datarow
        /// </summary>
        public abstract class JSONDataConverter : JsonConverter
        {
            protected JSONDataConverter(bool replaceColumnNameWithDefaultNameProperty)
            {
                this.replaceColumnNameWithDefaultNameProperty = replaceColumnNameWithDefaultNameProperty;
            }

            #region "Public Members"

            public bool replaceColumnNameWithDefaultNameProperty
            {
                get { return _replaceColumnNameWithDefaultNameProperty; }
                set { _replaceColumnNameWithDefaultNameProperty = value; }
            }

            #endregion

            #region "Private Members"

            private bool _replaceColumnNameWithDefaultNameProperty;

            #endregion
        }
    }
}