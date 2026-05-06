using RadianSimInfectionStack;

public static class DomainReviewTests
{
    public static void Run()
    {
        var item = new DomainReview(70, 21, 22, 77);
        if (DomainReviewLens.Score(item) != 172) throw new Exception("domain score mismatch");
        if (DomainReviewLens.Lane(item) != "ship") throw new Exception("domain lane mismatch");
    }
}
