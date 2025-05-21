namespace QuizPrototype;

internal class Game
{
    public void Run()
    {
        Discipline selectedDiscipline = SelectDiscipline(); // Etape 1 : Demander à l'utilisateur de sélectionner une discipline
        List<Qcm> questions = LoadQcmsFor(selectedDiscipline); // Etape 2 : Charger les questions du QCM de la discipline sélectionnée par l'utilisateur
        int score = RunQcm(questions); // Etape 3 : Lancer le questionnaire, poser les questions du QCM et calculer le score
        DisplayFinalScore(score, questions.Count); // Etape 4 : Afficher le score finale et l'évaluation
    }

    // Etape 1 : Demander à l'utilisateur de sélectionner une discipline
    private Discipline SelectDiscipline()
    {
        int disciplineIndex = Discipline.GetDisciplineChoice(); // Récupère une saisie d'utilisateur autorisée

        // Création d'un objet qui sert à rien pour le moment, d'une classe qui ne sert à rien sans doute non plus, mais ça me fait plaisir, je m'exerce à instancier et manipuler les objets !
        return Data.DataDiscipline
            .Where(a => a.index == disciplineIndex)
            .Select(a => new Discipline(a.index, a.code, a.label))
            .First();
    }

    // Etape 2 : Charger les questions du QCM de la discipline sélectionnée par l'utilisateur
    private List<Qcm> LoadQcmsFor(Discipline discipline)
    {
        // Création de l'objet qcms qui va permettre de manipuler en objet les QCMS
        return [.. Data.DataQcm
            .Where(dq => dq.disciplineCode == discipline.Code)
            .Select(a => new Qcm(a.question, a.options, a.correctAnswer))
        ];
    }

    // Etape 3.1 : Lancer le questionnaire, poser les questions du QCM et calculer le score
    private int RunQcm(List<Qcm> questions)
    {
        int questionNumber = 0;
        int score = 0;

        questions.ForEach(question =>
        {
            question.DisplayQuestion(++questionNumber);

            int userInput = AskAndValidateAnswer();

            score = question.CheckCorrectAnswer(userInput, score);
        });

        return score;
    }

    // Etape 3.2 : Demander et valider la réponse de l'utilisateur
    private int AskAndValidateAnswer()
    {
        string answer = ConsoleTools.AskAnswer();
        var validation = ConsoleTools.CheckValidAnswer(answer, 1, 3); // VS m'a suggéré VAR ici au lieu de ConsoleTools.EnumValidAnswer

        while (validation != ConsoleTools.EnumValidAnswer.Valid) // Tant que la réponse de l'utilisateur n'est pas valide
        {
            ConsoleTools.DisplayErrorMessage(validation); // Afficher le message liée à l'erreur de saisie
            answer = ConsoleTools.AskAnswer(); // Demander le choix à l'utilisateur
            validation = ConsoleTools.CheckValidAnswer(answer, 1, 3); // Réaffecte la l'état de validation en fonction de la nouvelle réponse de l'utilisateur pour la vérification de la boucle Tant que
        }

        return int.Parse(answer);
    }

    // Etape 4 : Afficher le score finale et l'évaluation
    private void DisplayFinalScore(int score, int totalQuestions)
    {
        Qcm.ScoreDisplay(score, totalQuestions);

        Console.WriteLine();
        Console.WriteLine("Appuyez sur une touche pour quitter...");
        Console.ReadLine();
    }
}
