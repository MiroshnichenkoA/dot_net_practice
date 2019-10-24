using System;
using System.Collections.Generic;
using System.Text;

namespace lecture_13
{
    class Song
    {
        string _title;
        int _minutes;
        string _author;
        int _year;

        public string Title { get { return _title; } }
        public int Minutes { get { return _minutes; } }
        public string Author { get { return _author; } }
        public int Year { get { return _year; } }

        public Song(string title, int minutes, string author, int year)
        {
            _title = title;
            _minutes = minutes;
            _author = author;
            _year = year;
        }
    }

}
