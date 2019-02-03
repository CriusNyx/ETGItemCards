using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ETGItemCards
{
    public class ItemCardFormat
    {
        public readonly string format;
        private string realFormat;

        public ItemCardFormat(string format)
        {
            this.format = format;
            realFormat = format
                .Replace("{id}", "{0}")
                .Replace("{title}", "{1}")
                .Replace("{flavour}", "{2}")
                .Replace("{flavor}", "{2}")
                .Replace("{text}", "{3}")
                .Replace("{stats}", "{4}")
                .Replace("{tags}", "{5}")
                .Replace("{quality}", "{6}")
                .Replace("{qColor}", "{7}");

            Regex invalid = new Regex("\\{[^0-7]+\\}");
            if(invalid.IsMatch(realFormat.Replace("{{", "").Replace("}}", "")))
            {
                throw new ItemCardFormatException("Item card format failed to validate");
            }
        }

        public class ItemCardFormatException : System.Exception
        {
            public ItemCardFormatException()
            {

            }

            public ItemCardFormatException(string message) : base(message)
            {

            }
        }


        public string Format(ItemData item)
        {
            return string.Format(realFormat, item.id, item.title, item.flavour, item.text, item.GetStats(), item.tag, item.quality, item.qColor);
        }

        public const string LITE = @"{id}: {title}
{text}
Quality: [color {qColor}]{quality}[/color]";

        public const string FULL = @"{id}: {title}
{flavour}
{text}
{stats}
{tags}";
    }
}