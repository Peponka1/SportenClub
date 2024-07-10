public class TrainingSession
{
    public string SessionID { get; set; }
    public string CoachID { get; set; }
    public DateTime Date { get; set; }
    public int Duration { get; set; }
    public List<Member> Participants { get; set; }

    public TrainingSession(string sessionID, string coachID, DateTime date, int duration)
    {
        SessionID = sessionID;
        CoachID = coachID;
        Date = date;
        Duration = duration;
        Participants = new List<Member>();
    }

    public override string ToString()
    {
        return $"ID: {SessionID}, Coach ID: {CoachID}, Date: {Date}, Duration: {Duration} minutes, Participants: {Participants.Count}";
    }
}
