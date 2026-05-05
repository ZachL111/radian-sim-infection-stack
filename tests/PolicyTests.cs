using RadianSimInfectionStack;

public static class PolicyTests
{
    public static void Run()
    {
        var signalcase_1 = new Signal(84, 97, 18, 22, 10);
        if (Policy.Score(signalcase_1) != 119) throw new Exception("score mismatch");
        if (Policy.Classify(signalcase_1) != "review") throw new Exception("decision mismatch");
        var signalcase_2 = new Signal(95, 90, 20, 17, 6);
        if (Policy.Score(signalcase_2) != 142) throw new Exception("score mismatch");
        if (Policy.Classify(signalcase_2) != "review") throw new Exception("decision mismatch");
        var signalcase_3 = new Signal(100, 97, 21, 18, 4);
        if (Policy.Score(signalcase_3) != 142) throw new Exception("score mismatch");
        if (Policy.Classify(signalcase_3) != "review") throw new Exception("decision mismatch");
    }
}
