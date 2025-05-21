namespace QuizPrototype;

internal class Data
{
    public static (int index, string code, string label)[] DataDiscipline =
    {
        (1, "Mecanic", "Mécanique"),
        (2, "CSharp", "C#")
    };

    public static (string disciplineCode, string question, List<string> options, int correctAnswer)[] DataQcm =
    {
        (
            "Mecanic",
            "Quel est le rôle exact du volant moteur dans un moteur thermique ?",
            [
                "1. Il permet de faire varier la puissance envoyée aux roues",
                "2. Il sert à démarrer le moteur en lançant le vilebrequin",
                "3. Il stocke de l’énergie cinétique pour réguler les variations de régime moteur"
            ],
            3
        ),
        (
            "Mecanic",
            "Lors d’une vidange, pourquoi change-t-on également le filtre à huile ?",
            [
                "1. Parce qu’il empêche l’huile de devenir trop visqueuse",
                "2. Parce qu’il retient les impuretés qui pourraient circuler avec la nouvelle huile",
                "3. Parce qu’il améliore la combustion dans les cylindres"
            ],
            2
        ),
        (
            "Mecanic",
            "Quelle anomalie pourrait entraîner une surconsommation de carburant ?",
            [
                "1. Une courroie d’accessoire trop tendue",
                "2. Un filtre à air légèrement encrassé",
                "3. Un liquide de refroidissement trop ancien"
            ],
            2
        ),
        (
            "Mecanic",
            "Quelle est la particularité d’un moteur à injection directe par rapport à un moteur à injection indirecte ?",
            [
                "1. L’injection se fait dans le collecteur d’admission",
                "2. L’injection se fait directement dans la chambre de combustion",
                "3. L’injection est contrôlée mécaniquement"
            ],
            2
        ),
        (
            "Mecanic",
            "Un disque de frein voilé provoquera principalement :",
            [
                "1. Une perte totale de freinage",
                "2. Une usure prématurée des pneus",
                "3. Des vibrations lors des freinages"
            ],
            3
        ),
        (
            "Mecanic",
            "Pourquoi le calage de distribution est-il crucial ?",
            [
                "1. Parce qu’il synchronise l’ouverture des soupapes et la position des pistons",
                "2. Parce qu’il régule la pression dans le système de freinage",
                "3. Parce qu’il équilibre les masses en rotation dans le moteur"
            ],
            1
        ),
        (
            "Mecanic",
            "Un cliquetis métallique dans le moteur peut indiquer :",
            [
                "1. Une huile trop fluide ou un manque de lubrification",
                "2. Une bougie de préchauffage défaillante",
                "3. Un turbo en surpression"
            ],
            1
        ),
        (
            "Mecanic",
            "Quel est l’impact principal d’un mauvais parallélisme ?",
            [
                "1. Une perte de puissance moteur",
                "2. Une usure irrégulière des pneus",
                "3. Une surchauffe du liquide de frein"
            ],
            2
        ),
        (
            "Mecanic",
            "Une sonde lambda défaillante peut engendrer :",
            [
                "1. Une panne de direction assistée",
                "2. Une mauvaise régulation du mélange air/carburant",
                "3. Un grincement à l’arrière du véhicule"
            ],
            2
        ),
        (
            "Mecanic",
            "Que mesure un débitmètre d’air (MAF) ?",
            [
                "1. La pression dans les cylindres",
                "2. La quantité d’air entrant dans le moteur",
                "3. La température des gaz d’échappement"
            ],
            2
        ),
        (
            "CSharp",
            "En C#, que se passe-t-il si vous ne libérez pas explicitement un objet qui implémente IDisposable ?",
            [
                "1. Il sera collecté automatiquement sans fuite mémoire",
                "2. Il pourra rester en mémoire plus longtemps que nécessaire et potentiellement entraîner une fuite de ressources",
                "3. Le compilateur lèvera une erreur à l’exécution"
            ],
            2
        ),
        (
            "CSharp",
            "Quelle est la différence principale entre ref et out en C# ?",
            [
                "1. ref nécessite une initialisation préalable, out non",
                "2. ref copie la valeur, out référence l’adresse",
                "3. out est plus rapide que ref"
            ],
            1
        ),
        (
            "CSharp",
            "Quelle est la portée d’une variable déclarée dans un bloc if sans accolade {} ?",
            [
                "1. Globale à la méthode",
                "2. Limitée à la condition if",
                "3. Toujours limitée au bloc dans lequel elle est déclarée, même sans {}"
            ],
            3
        ),
        (
            "CSharp",
            "En C#, quelle est la différence entre une classe abstract et une interface ?",
            [
                "1. Une classe abstract ne peut pas avoir de méthodes concrètes",
                "2. Une interface peut contenir des champs d’instance",
                "3. Une classe peut hériter d’une seule classe abstract mais implémenter plusieurs interfaces"
            ],
            3
        ),
        (
            "CSharp",
            "En programmation orientée objet, que permet le polymorphisme ?",
            [
                "1. De stocker plusieurs types dans une même variable",
                "2. De redéfinir complètement le comportement d’une méthode héritée",
                "3. D’interagir avec des objets via leur type parent ou interface commune"
            ],
            3
        ),
        (
            "CSharp",
            "Que se passe-t-il si un try contient une exception non interceptée par le catch ?",
            [
                "1. Le programme se ferme immédiatement sans message",
                "2. Le programme saute le catch et continue dans le finally",
                "3. Le finally s’exécute, puis l’exception remonte"
            ],
            3
        ),
        (
            "CSharp",
            "Quelle est la conséquence de l’utilisation d’un champ static dans une classe en C# ?",
            [
                "1. Il est instancié à chaque fois que l’on crée un objet de la classe",
                "2. Il est partagé entre toutes les instances de la classe",
                "3. Il ne peut contenir que des valeurs constantes"
            ],
            2
        ),
        (
            "CSharp",
            "En C#, List<T>.Find() retourne :",
            [
                "1. Le premier élément qui vérifie une condition",
                "2. Tous les éléments qui vérifient une condition",
                "3. L’index du premier élément qui vérifie une condition"
            ],
            1
        ),
        (
            "CSharp",
            "Quelle est la différence entre StringBuilder et string pour des concaténations multiples ?",
            [
                "1. string est plus rapide pour des boucles, car il est immuable",
                "2. StringBuilder évite la création d’objets intermédiaires à chaque concaténation",
                "3. StringBuilder ne supporte pas les caractères spéciaux"
            ],
            2
        ),
        (
            "CSharp",
            "Quel est le rôle du mot-clé using dans using System; ?",
            [
                "1. Il crée une instance de l’espace de noms",
                "2. Il permet d’importer un espace de noms pour accéder à ses membres sans qualification complète",
                "3. Il définit un alias local pour les classes utilisées dans le fichier"
            ],
            2
        )
    };


    public static (string question, List<string> options, int correctAnswer)[] DataMecanic =
    {
        (
            "Quel est le rôle exact du volant moteur dans un moteur thermique ?",
            [
                "1. Il permet de faire varier la puissance envoyée aux roues",
                "2. Il sert à démarrer le moteur en lançant le vilebrequin",
                "3. Il stocke de l’énergie cinétique pour réguler les variations de régime moteur"
            ],
            3
        ),
        (
            "Lors d’une vidange, pourquoi change-t-on également le filtre à huile ?",
            [
                "1. Parce qu’il empêche l’huile de devenir trop visqueuse",
                "2. Parce qu’il retient les impuretés qui pourraient circuler avec la nouvelle huile",
                "3. Parce qu’il améliore la combustion dans les cylindres"
            ],
            2
        ),
        (
            "Quelle anomalie pourrait entraîner une surconsommation de carburant ?",
            [
                "1. Une courroie d’accessoire trop tendue",
                "2. Un filtre à air légèrement encrassé",
                "3. Un liquide de refroidissement trop ancien"
            ],
            2
        ),
        (
            "Quelle est la particularité d’un moteur à injection directe par rapport à un moteur à injection indirecte ?",
            [
                "1. L’injection se fait dans le collecteur d’admission",
                "2. L’injection se fait directement dans la chambre de combustion",
                "3. L’injection est contrôlée mécaniquement"
            ],
            2
        ),
        (
            "Un disque de frein voilé provoquera principalement :",
            [
                "1. Une perte totale de freinage",
                "2. Une usure prématurée des pneus",
                "3. Des vibrations lors des freinages"
            ],
            3
        ),
        (
            "Pourquoi le calage de distribution est-il crucial ?",
            [
                "1. Parce qu’il synchronise l’ouverture des soupapes et la position des pistons",
                "2. Parce qu’il régule la pression dans le système de freinage",
                "3. Parce qu’il équilibre les masses en rotation dans le moteur"
            ],
            1
        ),
        (
            "Un cliquetis métallique dans le moteur peut indiquer :",
            [
                "1. Une huile trop fluide ou un manque de lubrification",
                "2. Une bougie de préchauffage défaillante",
                "3. Un turbo en surpression"
            ],
            1
        ),
        (
            "Quel est l’impact principal d’un mauvais parallélisme ?",
            [
                "1. Une perte de puissance moteur",
                "2. Une usure irrégulière des pneus",
                "3. Une surchauffe du liquide de frein"
            ],
            2
        ),
        (
            "Une sonde lambda défaillante peut engendrer :",
            [
                "1. Une panne de direction assistée",
                "2. Une mauvaise régulation du mélange air/carburant",
                "3. Un grincement à l’arrière du véhicule"
            ],
            2
        ),
        (
            "Que mesure un débitmètre d’air (MAF) ?",
            [
                "1. La pression dans les cylindres",
                "2. La quantité d’air entrant dans le moteur",
                "3. La température des gaz d’échappement"
            ],
            2
        )
    };

    public static (string question, List<string> options, int correctAnswer)[] DataCSharp =
    {
        (
            "En C#, que se passe-t-il si vous ne libérez pas explicitement un objet qui implémente IDisposable ?",
            [
                "1. Il sera collecté automatiquement sans fuite mémoire",
                "2. Il pourra rester en mémoire plus longtemps que nécessaire et potentiellement entraîner une fuite de ressources",
                "3. Le compilateur lèvera une erreur à l’exécution"
            ],
            2
        ),
        (
            "Quelle est la différence principale entre ref et out en C# ?",
            [
                "1. ref nécessite une initialisation préalable, out non",
                "2. ref copie la valeur, out référence l’adresse",
                "3. out est plus rapide que ref"
            ],
            1
        ),
        (
            "Quelle est la portée d’une variable déclarée dans un bloc if sans accolade {} ?",
            [
                "1. Globale à la méthode",
                "2. Limitée à la condition if",
                "3. Toujours limitée au bloc dans lequel elle est déclarée, même sans {}"
            ],
            3
        ),
        (
            "En C#, quelle est la différence entre une classe abstract et une interface ?",
            [
                "1. Une classe abstract ne peut pas avoir de méthodes concrètes",
                "2. Une interface peut contenir des champs d’instance",
                "3. Une classe peut hériter d’une seule classe abstract mais implémenter plusieurs interfaces"
            ],
            3
        ),
        (
            "En programmation orientée objet, que permet le polymorphisme ?",
            [
                "1. De stocker plusieurs types dans une même variable",
                "2. De redéfinir complètement le comportement d’une méthode héritée",
                "3. D’interagir avec des objets via leur type parent ou interface commune"
            ],
            3
        ),
        (
            "Que se passe-t-il si un try contient une exception non interceptée par le catch ?",
            [
                "1. Le programme se ferme immédiatement sans message",
                "2. Le programme saute le catch et continue dans le finally",
                "3. Le finally s’exécute, puis l’exception remonte"
            ],
            3
        ),
        (
            "Quelle est la conséquence de l’utilisation d’un champ static dans une classe en C# ?",
            [
                "1. Il est instancié à chaque fois que l’on crée un objet de la classe",
                "2. Il est partagé entre toutes les instances de la classe",
                "3. Il ne peut contenir que des valeurs constantes"
            ],
            2
        ),
        (
            "En C#, List<T>.Find() retourne :",
            [
                "1. Le premier élément qui vérifie une condition",
                "2. Tous les éléments qui vérifient une condition",
                "3. L’index du premier élément qui vérifie une condition"
            ],
            1
        ),
        (
            "Quelle est la différence entre StringBuilder et string pour des concaténations multiples ?",
            [
                "1. string est plus rapide pour des boucles, car il est immuable",
                "2. StringBuilder évite la création d’objets intermédiaires à chaque concaténation",
                "3. StringBuilder ne supporte pas les caractères spéciaux"
            ],
            2
        ),
        (
            "Quel est le rôle du mot-clé using dans using System; ?",
            [
                "1. Il crée une instance de l’espace de noms",
                "2. Il permet d’importer un espace de noms pour accéder à ses membres sans qualification complète",
                "3. Il définit un alias local pour les classes utilisées dans le fichier"
            ],
            2
        )
    };
}
