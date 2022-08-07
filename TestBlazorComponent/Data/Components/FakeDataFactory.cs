using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestBlazorComponent.Domain;

namespace TestBlazorComponent.Data.Components
{
    public static class FakeDataFactory
    {
        public static IEnumerable<Event> Events()
        {
            yield return new Event 
            {
                Id = Guid.Parse("2BF1E3D4-D6F3-4DF5-A640-92682B14B164"),
                Note = "Test 1",
                EventDate = new DateTime(2022, 8, 8),
                DayName = "08-августа-2022",
            };
            yield return new Event 
            {
                Id = Guid.Parse("51555979-BF1F-47A0-B8EF-29471DFA73DD"),
                Note = "Test 2",
                EventDate = new DateTime(2022, 8, 9),
                DayName = "09-августа-2022",
            };
            yield return new Event
            {
                Id = Guid.Parse("C7A50B1A-F421-45F1-82C0-ABB48FC1C20C"),
                Note = "Test 3",
                EventDate = new DateTime(2022, 8, 9).AddHours(3),
                DayName = "09-августа-2022",
            };
            yield return new Event
            {
                Id = Guid.Parse("32E9C7C6-856D-40DA-BE8C-44C7226EDD28"),
                Note = "Test 5",
                EventDate = new DateTime(2022, 8, 10),
                DayName = "10-августа-2022",
            };
            yield return new Event
            {
                Id = Guid.Parse("E68A2666-A12E-490A-8C51-09685B46894E"),
                Note = "Test 6",
                EventDate = new DateTime(2022, 8, 10).AddHours(6),
                DayName = "10-августа-2022",
            };
        }
    }
}
