using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MonthandYear.Controllers
{
    //[Authorize]
    public class ValuesController : ApiController
    {
        static List<string> str = new List<string>()
        {
             "value1", "value2"
        };
        // GET api/values
        public IEnumerable<string> Get()
        {
            return str;
        }

        // GET api/values/5
        public string Get(int id)
        {
            return str[id];
        }
        //POST api/values
        [HttpPost]
        public int Post([FromBody] DateTime value)
        {
            //    int year, month;
            //return new DateTimeOffset(value, TimeZoneInfo.Local.GetUtcOffset(value)).ToString("d");//it displays the same output but it convert 1-3 to 1/3
            //return new DateTimeOffset(value, TimeZoneInfo.Local.GetUtcOffset(value)).ToString("HH");
            //return new DateTimeOffset(value, TimeZoneInfo.Local.GetUtcOffset(value)).ToString("dd");
            //return new DateTimeOffset(value, TimeZoneInfo.Local.GetUtcOffset(value)).ToString("MMMM");
            //return str.Add(DateTime.DaysInMonth(DateTimePicker.Value.Date.Year, DateTimePicker.Value.Date.Month).ToString());

            //    //System.DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month);
            //    //str.Add(CultureInfo.CurrentCulture.Calendar.GetDaysInMonth(2017,02));

            //    //DateTime dt = DateTime.ParseExact(.Text, "MM/dd/yyyy", CultureInfo.InvariantCulture);
            //    //int numberOfDays = DateTime.DaysInMonth(dt.Year, dt.Month);
            //    int days = DateTime.DaysInMonth(2019, 04);
            //    //return days;

            //int TotalNumberOfDaysInMonth(int year, int month)
            //int days = DateTime.DaysInMonth(value.Year, value.Month);
            //String s = days.ToString();
            //str.Add(s);
            //return str;

            //return DateTime.DaysInMonth(value.Year, value.Month);  //dispaly the no. of days in a month

            //DateTimeFormatInfo dtf = DateTimeFormatInfo.CurrentInfo;
            //Calendar cal = dtf.Calendar;

            //DateTime date = default(DateTime);
            //return cal.GetWeekOfYear(date, dtf.CalendarWeekRule, dtf.FirstDayOfWeek);////its working but it displays 1 for any date 

            //return Calendar.GetWeekOfYear(DateTime time,CalendarWeekRule rule,DayOfWeek firstDayOfWeek);

            //return new GregorianCalendar(GregorianCalendarTypes.Localized).GetWeekOfYear(date, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);////it is also working but the output displays 1

            //CultureInfo ciCurr = CultureInfo.CurrentCulture;
            //int weekNum = ciCurr.Calendar.GetWeekOfYear(value, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);////successfull code it displays the no of days in a month
            //return weekNum;

            //CultureInfo culture = CultureInfo.CreateSpecificCulture("en-US");
            //DateTimeFormatInfo dtfi = culture.DateTimeFormat;
            //dtfi.TimeSeparator = ".";

            CultureInfo ciCurr = CultureInfo.CurrentCulture;
            int weekNum = ciCurr.Calendar.GetWeekOfYear(value, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);
            return weekNum;

        }



    }

    //PUT api/values/5
    //public void Put(int id, [FromBody]string value)
    //{
    //}

    //// DELETE api/values/5
    //public void Delete(int id)
    //{
    //}
//}
}

