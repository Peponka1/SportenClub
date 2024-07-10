public class Club
{
    public string Name { get; set; }
    public string Address { get; set; }
    public string Manager { get; set; }
    public List<Member> Members { get; set; }
    public List<Coach> Coaches { get; set; }
    public List<TrainingSession> TrainingSessions { get; set; }
    public List<Event> Events { get; set; }

    public Club(string name, string address, string manager)
    {
        Name = name;
        Address = address;
        Manager = manager;
        Members = new List<Member>();
        Coaches = new List<Coach>();
        TrainingSessions = new List<TrainingSession>();
        Events = new List<Event>();
    }

    public void AddMember(Member member) => Members.Add(member);

    public void RemoveMember(string memberID) => Members.RemoveAll(m => m.MemberID == memberID);

    public List<Member> SearchMemberByName(string name) => Members.Where(m => m.FullName.Contains(name, StringComparison.OrdinalIgnoreCase)).ToList();

    public void ListAllMembers()
    {
        Console.WriteLine("All Members:");
        Members.ForEach(m => Console.WriteLine(m.ToString()));
    }

    public void AddCoach(Coach coach) => Coaches.Add(coach);

    public void RemoveCoach(string coachID) => Coaches.RemoveAll(c => c.CoachID == coachID);

    public void AddTrainingSession(TrainingSession session) => TrainingSessions.Add(session);

    public void RemoveTrainingSession(string sessionID) => TrainingSessions.RemoveAll(s => s.SessionID == sessionID);

    public void AddEvent(Event newEvent) => Events.Add(newEvent);

    public void RemoveEvent(string eventID) => Events.RemoveAll(e => e.EventID == eventID);

    public void GenerateActivityReport()
    {
        Console.WriteLine("Activity Report:");
        Console.WriteLine("Training Sessions:");
        TrainingSessions.ForEach(s => Console.WriteLine(s.ToString()));
        Console.WriteLine("Events:");
        Events.ForEach(e => Console.WriteLine(e.ToString()));
    }
}
