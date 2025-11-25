using System;

namespace _14
{
    public enum Difficulty
    {
        Easy = 1,
        Medium = 2,
        Hard = 3,
    }

    internal class Course
    {
        int courseid; int duration; string title; Difficulty lvl;

        public Course(int courseid, int duration, string title, int diff)
        {
            this.courseid = courseid;
            this.duration = duration;
            this.title = title;
            this.lvl = (Difficulty)diff;
        }

        #region setget
        // courseid
        public int GetCourseId()
        {
            return this.courseid;
        }

        public void SetCourseId(int courseid)
        {
            this.courseid = courseid;
        }

        // duration
        public int GetDuration()
        {
            return this.duration;
        }

        public void SetDuration(int duration)
        {
            this.duration = duration;
        }

        // title
        public string GetTitle()
        {
            return this.title;
        }

        public void SetTitle(string title)
        {
            this.title = title;
        }

        // difficulty level
        public Difficulty GetDifficulty()
        {
            return this.lvl;
        }

        public void SetDifficulty(Difficulty lvl)
        {
            this.lvl = lvl;
        }

        #endregion
    }
}
