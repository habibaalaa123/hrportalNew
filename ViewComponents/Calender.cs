using hrportalNew.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

public class CalenderViewComponent : ViewComponent
{


    public async Task<IViewComponentResult> InvokeAsync()
    {
        var currentMonth = DateTime.Now; // or get from parameters
        var viewModel = GenerateCalendarData(currentMonth);
        return View(viewModel);

    }
    private CalendarViewModel GenerateCalendarData(DateTime month)
    {
        var firstDayOfMonth = new DateTime(month.Year, month.Month, 1);
        var lastDayOfMonth = firstDayOfMonth.AddMonths(1).AddDays(-1);
        var firstDayOfCalendar = firstDayOfMonth.AddDays(-(int)firstDayOfMonth.DayOfWeek);

        var days = new List<CalendarDay>();
        var today = DateTime.Today;

        for (int i = 0; i < 42; i++) // 6 weeks * 7 days
        {
            var date = firstDayOfCalendar.AddDays(i);

            days.Add(new CalendarDay
            {
                Date = date,
                IsToday = date.Date == today.Date,
                IsCurrentMonth = date.Month == month.Month,
                HasEvent = HasEventOnDate(date), // Your event logic
                // Add other event properties as needed
            });
        }

        return new CalendarViewModel
        {
            CurrentMonth = month,
            Days = days
        };
    }
    private bool HasEventOnDate(DateTime date)
    {
        // Your logic to check if there are events on this date
        // This could query your database, check a list, etc.
        return false;
    }
}
