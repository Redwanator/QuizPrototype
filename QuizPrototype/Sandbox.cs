namespace QuizPrototype;

internal class Sandbox
{
    //void Questionner(string Question, List<string> Choix, int BonneReponse)
    //{

    //    Console.WriteLine(Question);
    //    Console.WriteLine(Choix[0]);
    //    Console.WriteLine(Choix[1]);
    //    Console.WriteLine(Choix[2]);

    //    Console.WriteLine("Merci de preciser le chiffre de la reponse 0 , 1 , 2");


    //    string Reponse = Console.ReadLine();
    //    bool EstNombre = int.TryParse(Reponse, out int result);

    //    while (!EstNombre)
    //    {
    //        Console.WriteLine("Nombre invalide");
    //        Reponse = Console.ReadLine();
    //        EstNombre = int.TryParse(Reponse, out int result2);
    //    }
    //    int ReponseUtilisateur = int.Parse(Reponse);


    //    if (BonneReponse == ReponseUtilisateur)
    //    {
    //        Console.WriteLine("Super tu est trop fort");
    //    }
    //    else
    //    {
    //        Console.WriteLine("Va chier pourriture !");
    //    }
    //}

    /*
     * TO DO
     *      Faire une liste de questions/choix/réponse et boucler dessus avec ForEach
     *      Compter le score et le donner à la fin du QUIZ
     *          Du premier coup 2 points
     *      Permettre à l'utilisateur d'avoir une seconde chance pour bien répondre mais ne donne que la moitié des points
     *          Du second coup 1 point
     *          
     *      ....
     *      
     *      Permettre à l'utilisateur de choisir un thème et lui proposer un QCM en fonction du thème choisi
     *      
     *      Le faire avec un Front (pas en console)
     *      
     *      Permettre de rejouer en fin de quiz
     *      
     *      Choix aléatoire de 3 questions parmi 10 propositions dans un thème
     *      
     */


    //Questionner(
    //"1. Quel est le rôle exact du volant moteur dans un moteur thermique ?",

    //    [
    //        "0. Il permet de faire varier la puissance envoyée aux roues",
    //        "1. Il sert à démarrer le moteur en lançant le vilebrequin",
    //        "2. Il stocke de l’énergie cinétique pour réguler les variations de régime moteur"],
    //    2
    //);


    //Questionner(
    //"2. Lors d’une vidange, pourquoi change-t-on également le filtre à huile ?",

    //    [
    //        "0. Parce qu’il empêche l’huile de devenir trop visqueuse",
    //        "1. Parce qu’il retient les impuretés qui pourraient circuler avec la nouvelle huile",
    //        "2. Parce qu’il améliore la combustion dans les cylindres"],
    //    1
    //);

    //Questionner(
    //"3. Quelle anomalie pourrait entraîner une surconsommation de carburant ?",

    //    [
    //        "0. Une courroie d’accessoire trop tendue",
    //        "1. Un filtre à air légèrement encrassé",
    //        "2. Un liquide de refroidissement trop ancien"
    //    ],
    //    1
    //);

    //Questionner(
    //"4. Quelle est la particularité d’un moteur à injection directe par rapport à un moteur à injection indirecte ?",

    //    [
    //        "0. L’injection se fait dans le collecteur d’admission",
    //        "1. L’injection se fait directement dans la chambre de combustion",
    //        "2. L’injection est contrôlée mécaniquement"
    //    ],
    //    1
    //);

    //Questionner(
    //"5. Un disque de frein voilé provoquera principalement :",

    //    [
    //        "0. Une perte totale de freinage",
    //        "1. Une usure prématurée des pneus",
    //        "2. Des vibrations lors des freinages"
    //    ],
    //    2
    //);

    //Questionner(
    //"6. Pourquoi le calage de distribution est-il crucial ?",

    //    [
    //        "0. Parce qu’il synchronise l’ouverture des soupapes et la position des pistons",
    //        "1. Parce qu’il régule la pression dans le système de freinage",
    //        "2. Parce qu’il équilibre les masses en rotation dans le moteur"
    //    ],
    //    0
    //);

    //Questionner(
    //"7. Un cliquetis métallique dans le moteur peut indiquer :",

    //    [
    //        "0. Une huile trop fluide ou un manque de lubrification",
    //        "1. Une bougie de préchauffage défaillante",
    //        "2. Un turbo en surpression"
    //    ],
    //    0
    //);

    //Questionner(
    //"8. Quel est l’impact principal d’un mauvais parallélisme ?",

    //    [
    //        "0. Une perte de puissance moteur",
    //        "1. Une usure irrégulière des pneus",
    //        "2. Une surchauffe du liquide de frein"
    //    ],
    //    1
    //);

    //Questionner(
    //"9. Une sonde lambda défaillante peut engendrer :",

    //    [
    //        "0. Une panne de direction assistée",
    //        "1. Une mauvaise régulation du mélange air/carburant",
    //        "2. Un grincement à l’arrière du véhicule"
    //    ],
    //    1
    //);

    //Questionner(
    //"10. Que mesure un débitmètre d’air (MAF) ?",

    //    [
    //        "0. La pression dans les cylindres",
    //        "1. La quantité d’air entrant dans le moteur",
    //        "2. La température des gaz d’échappement"
    //    ],
    //	1
    //);

    /*
     * 
     * RADOUANE
     * 
     * 
     */

    //public class Quiz
    //{
    //    private string question;
    //    private string[] options;
    //    private int correctAnswer;

    //    public Quiz(string question, string[] options, int correctAnswer)
    //    {
    //        this.question = question;
    //        this.options = options;
    //        this.correctAnswer = correctAnswer;
    //    }

    //    public void DisplayQuestion()
    //    {
    //        Console.WriteLine(question);
    //        foreach (string option in options)
    //        {
    //            Console.WriteLine(option);
    //        }
    //    }

    //    public bool CheckAnswer(int userAnswer)
    //    {
    //        return userAnswer == correctAnswer;
    //    }

    //    public static void Main(string[] args)
    //    {
    //        Quiz[] quizzes = new Quiz[]
    //        {
    //            new Quiz("Question 1 ?", new string[] { "1. Option 1", "2. Option 2", "3. Option 3" }, 1),
    //            new Quiz("Question 2 ?", new string[] { "1. Option 1", "2. Option 2", "3. Option 3" }, 2)
    //        };

    //        int score = 0;

    //        foreach (var quiz in quizzes)
    //        {
    //            quiz.DisplayQuestion();
    //            Console.Write("Entrez le numéro de votre réponse : ");
    //            if (int.TryParse(Console.ReadLine(), out int userAnswer))
    //            {
    //                if (quiz.CheckAnswer(userAnswer))
    //                {
    //                    Console.WriteLine("Correct !");
    //                    score++;
    //                }
    //                else
    //                {
    //                    Console.WriteLine("Incorrect.");
    //                }
    //            }
    //            else
    //            {
    //                Console.WriteLine("Entrée invalide. Veuillez entrer un numéro.");
    //            }
    //        }

    //        Console.WriteLine($"Votre score final est : {score}/{quizzes.Length}");
    //    }
    //}
}
