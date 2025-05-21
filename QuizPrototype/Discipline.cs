namespace QuizPrototype;

internal class Discipline(int index, string code, string label)
{
    public int Index { get; } = index;
    public string Code { get; } = code;
    public string Label { get; } = label;

    // Méthode pour afficher les différentes disciplines proposées
    private static void DisplayDiscipline()
    {
        Console.WriteLine("Quelle discipline souhaitez-vous ?");

        foreach (var discipline in Data.DataDiscipline)
        {
            Console.WriteLine($"{discipline.index}. {discipline.label}");
        }
    }

    public static int GetDisciplineChoice()
    {
        DisplayDiscipline(); // Afficher les différentes discplines proposées

        string dataChoice = ConsoleTools.AskAnswer(); // Demander le choix à l'utilisateur

        ConsoleTools.EnumValidAnswer validChoice = ConsoleTools.CheckValidAnswer(dataChoice, 1, 2); // Vérifier l'état de validation de la réponse de l'utilisateur

        while (validChoice != ConsoleTools.EnumValidAnswer.Valid) // Tant que la réponse de l'utilisateur n'est pas valide
        {
            ConsoleTools.DisplayErrorMessage(validChoice); // Afficher le message liée à l'erreur de saisie
            dataChoice = ConsoleTools.AskAnswer(); // Demander le choix à l'utilisateur
            validChoice = ConsoleTools.CheckValidAnswer(dataChoice, 1, 2); // Réaffecte la l'état de validation en fonction de la nouvelle réponse de l'utilisateur pour la vérification de la boucle Tant que
        }

        return int.Parse(dataChoice.Trim());
    }
}
