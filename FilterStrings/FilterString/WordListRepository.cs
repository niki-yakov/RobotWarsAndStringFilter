using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilterString
{
    public class WordListRepository : IWordListRepository
    {
        public string[] GetAllStrings()
        {
            return new string[] {
                "al", "albums", "aver", "bar", "barely", "be", "befoul", "bums", "by", "cat", "con", "convex", "ely", "foul", "here", "hereby", "jig", "jigsaw", "or", "saw", "tail", "tailor", "vex", "we", "weaver"
            };
        }
    }
}
