using Newtonsoft.Json;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;

namespace CaraBosca.Core
{
    public class TonieData
        {
            [JsonProperty("no")]
            public string SortNumber_;
            public string SortString
            {
                get
                {
                    string ret = "";

                    if (!string.IsNullOrEmpty(Language))
                    {
                        ret += Language;
                    }
                    if (!string.IsNullOrEmpty(SortNumber_) && SortNumber_ != "na")
                    {
                        ret += int.Parse(SortNumber_).ToString("0000");
                    }
                    return ret;
                }
                private set {}
            }
            [JsonProperty("model")]
            public string Model;
            [JsonProperty("audio_id")]
            public string[] AudioId_;
            [JsonIgnore]
            public long[] AudioIds
            {
                get
                {
                    List<long> ids = new List<long>();
                    foreach (var id in AudioId_)
                    {
                        if (id != "" && id != "na")
                        {
                            ids.Add(long.Parse(id));
                        }
                    }
                    return ids.ToArray();
                }
            }
            [JsonProperty("hash")]
            public string[] Hash;
            [JsonProperty("title")]
            public string Title;
            [JsonProperty("series")]
            public string Series;
            [JsonProperty("episodes")]
            public string Episodes; // unused
            [JsonProperty("tracks")]
            public string[] Tracks;
            [JsonProperty("release")]
            public string Release; // unused
            [JsonProperty("language")]
            public string Language;
            [JsonProperty("category")]
            public string Category; // unused
            [JsonProperty("pic")]
            public string Pic;

            // TODO_MAISIE fix this, it's shameful
            public static string ReverseUid(string uid)
            {
                List<string> groups = (from Match m in Regex.Matches(uid, @"[A-Fa-f0-9]{2}") select m.Value).ToList();
                groups.Reverse();
                string ret = string.Join("", groups.ToArray());

                return ret;
            }
        }

    public class CustomTonieData
    {
        [JsonProperty("name")]
        public string Name;
        [JsonProperty("img_path")]
        public string imgPath;
    }
}