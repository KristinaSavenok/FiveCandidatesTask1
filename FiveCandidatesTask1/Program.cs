// See https://aka.ms/new-console-template for more information
using FiveCandidatesTask1;

SubjectScore subjectScore1 = new SubjectScore("Math", 9);
SubjectScore subjectScore2 = new SubjectScore("Physics", 8);
Candidate candidate1 = new Candidate(new Person("Ivan", "Ivanov", new Address("Minsk", "Kolosa", 3, 3)), new SubjectScore[] { subjectScore1, subjectScore2 });

SubjectScore subjectScore1_1 = new SubjectScore("Math", 10);
SubjectScore subjectScore2_1 = new SubjectScore("Physics", 10);
Candidate candidate2 = new Candidate(new Person("Iva", "Pon", new Address("Minsk", "Kupaly", 30, 30)), new SubjectScore[] { subjectScore1_1, subjectScore2_1 });

SubjectScore subjectScore1_2 = new SubjectScore("Math", 6);
SubjectScore subjectScore2_2 = new SubjectScore("Physics", 6);
Candidate candidate3 = new Candidate(new Person("Lida", "Petrova", new Address("Minsk", "Kulinki", 98, 23)), new SubjectScore[] { subjectScore1_2, subjectScore2_2 });

SubjectScore subjectScore1_3 = new SubjectScore("Math", 5);
SubjectScore subjectScore2_3 = new SubjectScore("Physics", 3);
Candidate candidate4 = new Candidate(new Person("Alex", "Belyj", new Address("Minsk", "Poliski", 30, 5)), new SubjectScore[] { subjectScore1_3, subjectScore2_3 });

SubjectScore subjectScore1_4 = new SubjectScore("Math", 7);
SubjectScore subjectScore2_4 = new SubjectScore("Physics", 8);
Candidate candidate5 = new Candidate(new Person("Kostas", "Kruglyj", new Address("Minsk", "Zaluski", 44, 3)), new SubjectScore[] { subjectScore1_4, subjectScore2_4 });


Candidate[] candidatesArray = new[] { candidate1, candidate2, candidate3, candidate4, candidate5 };
Console.WriteLine("Список улиц абитуриентов:");
for (int i = 0; i < candidatesArray.Length; i++)
{
    string street = candidatesArray[i].Person.Address.Street;
    Console.WriteLine(street);
}

int[] mathScorArray = new int[candidatesArray.Length];

for (int i = 0; i < candidatesArray.Length; i++)
{

    SubjectScore[] subjectScoreArray = candidatesArray[i].SubjectScores;
    for (int j = 0; j < subjectScoreArray.Length; j++)
    {
        if (subjectScoreArray[j].SubjectName == "Math")
        {
            mathScorArray[i] = subjectScoreArray[j].Score;
        }
    }
}
Console.WriteLine("максимальная отметка по математике: " + mathScorArray.Max());

