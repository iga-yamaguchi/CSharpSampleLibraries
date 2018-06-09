using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleLibraries
{
    public class LinqSample
    {
        public void DoSomething()
        {
            var arr = new string[] { "a", "bb", "ccc" };
            var a = arr.Any(s => s == "a");
            var w = arr.Where(s => s.Length >= 2);
            var wType = w.GetType();
            var s2 = arr.Select(s => s + s);

            var lifeStyleTags = new Article().GetTags()
                .Where(tag => tag.GetTagType() == TagType.LifeStyle)
                .ToList();
        }
    }

    public class Article
    {
        public IEnumerable<Tag> GetTags()
        {
            return new List<Tag>();
        }
    }

    public class Tag
    {
        public string GetTagName()
        {
            return "tag name";
        }

        public TagType GetTagType()
        {
            return TagType.LifeStyle;
        }

        public
    }

    public enum TagType
    {
        LifeStyle,
    }
}
