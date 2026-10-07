using CoworkingGitPractice.Models;
using CoworkingGitPractice.Services;

var service = new WorkplaceService();

service.Add(new Workplace(1, "A-101", "Open Space", true));
service.Add(new Workplace(2, "A-102", "Meeting Room", true));
service.Add(new Workplace(3, "B-201", "Private Office", false));

Console.WriteLine("Система учета рабочих мест коворкинга");
Console.WriteLine("------------------------------------");

foreach (var workplace in service.GetAll())
{
    var status = workplace.IsAvailable ? "Свободно" : "Забронировано";
    Console.WriteLine($"{workplace.Id}: {workplace.Code} | {workplace.Type} | {status}");
}
