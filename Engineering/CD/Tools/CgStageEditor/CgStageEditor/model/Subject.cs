using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CgStageEditor.model
{
    class ComicsType
    {
        public int id;
        public string name;
    }

    class SubjectType
    {
        public int id;
        public string name;
    }

    class Catalog
    {
        public int id;
        public string name;
    }

    class Stage
    {
        public int id;
        public string name;
        public Catalog catalog;
    }

    class Subject
    {
        public int id;
        public string title;
        public SubjectType subjectType;
        public ComicsType comicsType;
        public Stage stage;
        public int level;
        public string remark;
        public string resImg;
        public string resText;
        public string resAudio;
        public string createdate;
        public string tip;
        public string selectors;
        public string answer;
        public int sorter = 0;
        public bool resolved = false;
    }
}
