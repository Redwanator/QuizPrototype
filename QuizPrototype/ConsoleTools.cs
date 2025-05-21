namespace QuizPrototype;

internal class ConsoleTools
{
    // Méthode pour demander la saisie de la réponse de l'utilisateur
    public static string AskAnswer()
    {
        Console.WriteLine("Merci d'entrer le numéro de votre réponse :");
        return Console.ReadLine() ?? string.Empty; // Si Console.ReadLine() = NULL alors string.Empty
    }
    // Potentiellement je n'ai besoin que de ça en Public et les autres en private

    // Membre de la classe de type énuméré pour exprimer l'état de la validation de la réponse de l'utilisateur
    public enum EnumValidAnswer
    {
        Valid,
        ErrorRange,
        ErrorNumber
    }

    // Méthode pour vérifier que la réponse de l'utilisateur est bien un numéro parmi les options possibles
    public static EnumValidAnswer CheckValidAnswer(string userAnswer, int minOption, int maxOption)
    {
        if (!int.TryParse(userAnswer.Trim(), out int numericUserAnswer))
            return EnumValidAnswer.ErrorNumber;

        if (numericUserAnswer < minOption || numericUserAnswer > maxOption)
            return EnumValidAnswer.ErrorRange;

        return EnumValidAnswer.Valid;
    }

    // Méthode pour afficher le message d'erreur lié à la saisie utilisateur
    public static void DisplayErrorMessage(EnumValidAnswer validAnswer)
    {
        string errorMessage = validAnswer switch
        {
            EnumValidAnswer.ErrorRange => "Votre réponse n'est pas dans l'intervalle proposé.",
            EnumValidAnswer.ErrorNumber => "Ce n'est pas un numéro valide.",
            _ => "Erreur inconnue."
        };

        Console.WriteLine(errorMessage);
    }
}
