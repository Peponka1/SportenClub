public class Event
{
    public string EventID { get; set; }
    public string Name { get; set; }
    public DateTime Date { get; set; }
    public string Location { get; set; }
    public List<Member> Participants { get; set; }

    public Event(string eventID, string name, DateTime date, string location)
    {
        EventID = eventID;
        Name = name;
        Date = date;
        Location = location;
        Participants = new List<Member>();
    }

    public override string ToString()
    {
        return $"ID: {EventID}, Name: {Name}, Date: {Date}, Location: {Location}, Participants: {Participants.Count}";
    }
}