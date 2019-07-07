using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Date
{
    public class DateModifier
    {
        private string firstDateTime;
        private string secondDateTime;

        public string FirstDate
        {
            get
            {
                return this.firstDateTime;
            }

            set
            {
                this.firstDateTime = value;
            }
        }
        public string SecondDate
        {
            get
            {
                return this.secondDateTime;
            }

            set
            {
                this.secondDateTime = value;
            }
        }
        public DateModifier(string firsDate, string secondDate)
        {
            this.FirstDate = firsDate;
            this.SecondDate = secondDate;
        }
        public int GetDifference()
        {
            DateTime firstDate = DateTime.Parse(FirstDate);
            DateTime secondDate = DateTime.Parse(SecondDate);

            int diff = Math.Abs((secondDate - firstDate).Days);

            return diff;
        }
    }
}
