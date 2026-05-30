using System;
using System.Collections.Generic;
using System.Linq;

namespace kas_kelas__2_.Helpers
{
    public class WeekInfo
    {
        public int WeekNumber { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string DisplayName { get; set; }
    }

    public static class WeekHelper
    {
        /// <summary>
        /// Mendapatkan daftar minggu dalam bulan tertentu, dimulai dengan Senin
        /// </summary>
        public static List<WeekInfo> GetWeeksInMonth(int year, int month)
        {
            var weeks = new List<WeekInfo>();
            var firstDay = new DateTime(year, month, 1);
            var lastDay = new DateTime(year, month, DateTime.DaysInMonth(year, month));

            // Cari Senin pertama dalam bulan
            DateTime currentMonday = firstDay;
            while (currentMonday.DayOfWeek != DayOfWeek.Monday)
            {
                currentMonday = currentMonday.AddDays(1);
            }

            int weekNumber = 1;

            while (currentMonday <= lastDay)
            {
                DateTime endDate = currentMonday.AddDays(6); // Minggu (7 hari)

                // Jika akhir minggu melampaui bulan, gunakan hari terakhir bulan
                if (endDate.Month != currentMonday.Month)
                {
                    endDate = lastDay;
                }

                weeks.Add(new WeekInfo
                {
                    WeekNumber = weekNumber,
                    StartDate = currentMonday,
                    EndDate = endDate,
                    DisplayName = $"Minggu {weekNumber} ({currentMonday:dd/MM} - {endDate:dd/MM})"
                });

                currentMonday = currentMonday.AddDays(7);
                weekNumber++;
            }

            return weeks;
        }

        /// <summary>
        /// Mendapatkan nomor minggu untuk tanggal tertentu dalam bulannya
        /// </summary>
        public static int GetWeekNumberInMonth(DateTime date)
        {
            var weeks = GetWeeksInMonth(date.Year, date.Month);
            var week = weeks.FirstOrDefault(w => date >= w.StartDate && date <= w.EndDate);
            return week?.WeekNumber ?? 0;
        }

        /// <summary>
        /// Mendapatkan info minggu untuk tanggal tertentu
        /// </summary>
        public static WeekInfo GetWeekInfo(DateTime date)
        {
            var weeks = GetWeeksInMonth(date.Year, date.Month);
            return weeks.FirstOrDefault(w => date >= w.StartDate && date <= w.EndDate);
        }
    }
}