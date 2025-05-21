namespace QuizPrototype;

internal class Qcm(string question, List<string> options, int correctAnswer)
{
    // Méthode pour afficher l'attribut
    public void DisplayQuestion(int questionNumber)
    {
        Console.WriteLine($"Question n°{questionNumber} : {question}");
        foreach (string option in options)
        {
            Console.WriteLine(option);
        }
    }

    // Méthode pour afficher la bonne réponse à la question
    public int DisplayCorrectAnswer()
    {
        return correctAnswer;
    }

    // Méthode pour vérifier si la réponse de l'utilisateur est bien la bonne réponse
    public int CheckCorrectAnswer(int userAnswer, int score)
    {
        if (userAnswer.Equals(correctAnswer))
        {
            Console.WriteLine($"Réponse correcte ! Il s'agissait bien de la réponse question.DisplayCorrectAnswer()");
            score++;
        }
        else
        {
            Console.WriteLine($"Réponse incorrecte ! La bonne réponse était la réponse question.DisplayCorrectAnswer()");
        }

        Console.WriteLine();

        return score;
    }

    // La seule que j'ai pu passer en private, sans doute parce que appelé par la Classe Qcm elle-même et pas par Game
    private static int ScoreCalculate(int score, int questionNumber)
    {
        decimal scoreDecimal = ((decimal)score / questionNumber) * 100;
        return (int)Math.Round(scoreDecimal);
    }

    // Celle la aussi
    private static string ScoreCase(int scorePercent)
    {
        (int index, string label)[] scoreCase =
        [
            (25, "Résultat très insuffisant, il faut songer à changer de voie !"), // [0%;25%]
            (50, "Résultat insuffisant, il faut encore travailler !"), // ]25%;50%]
            (75, "Résultat encourageant, tu peux sans doute encore faire mieux !"), // ]50%;75%]
            (100, "Résultat incroyable, tu as trouvé ta voie !") // ]75%;100%]
        ];

        string finalScore = $"Votre score final est de : {scorePercent}%. ";

        string labelScore = scoreCase
            .OrderBy(cas => cas.index)
            .Where(cas => cas.index >= scorePercent)
            .Select(cas => cas.label)
            .First();

        string scoreStatement = finalScore + labelScore;

        return scoreStatement;
    }

    public static void ScoreDisplay(int score, int totalQuestions)
    {
        int scorePercent = ScoreCalculate(score, totalQuestions);

        Console.WriteLine("══════════════════════════════════════════════════════════════════════════════════════════════════════"); // ALT + 205  ═════════
        Console.WriteLine(Qcm.ScoreCase(scorePercent));
        Console.WriteLine("══════════════════════════════════════════════════════════════════════════════════════════════════════");
    }
}
