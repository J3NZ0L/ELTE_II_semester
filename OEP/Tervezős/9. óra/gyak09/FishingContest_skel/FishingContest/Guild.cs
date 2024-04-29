namespace FishingContest;

public class Guild
{
    private List<Competition> competitions;
    private List<Fisherman> members;

    public Guild()
    {
        competitions = new List<Competition>();
        members = new List<Fisherman>();
    }

    public void Enter(Fisherman fisherman)
    {
        if (IsMember(fisherman))
        {
            throw new InvalidOperationException("Fisherman tries to be two members at once");
        }

        members.Add(fisherman);
    }

    public void HoldCompetition(string place, DateTime start)
    {
        if (competitions.Any(c=>c.Location==place && c.StartTime == start)) 
        {
            throw new InvalidOperationException("A competition is already held at the time");
        }

    }

    public bool IsMember(Fisherman fisherman)
    {
        return members.Any(m => fisherman == m);
        //return members.Contains(fisherman); //ugyanaz amugy
    }

    public Competition? Best()
    {
        Competition? competition = null;
        double best = 0.0;
        foreach (Competition c in competitions)
        {
            if (c.AllHasCatfish())
            {
                if (competitions == null)
                {
                    competition = c;
                    best = competition.TotalValue();
                } else if(c.TotalValue()>best){
                    competition = c;
                    best = competition.TotalValue();
                }
            }
        }
        return competition;
    }
}