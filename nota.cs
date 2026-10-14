public class Program
{
    public static void Main()
    {
        List<Dictionary<string, List<double>>> testCases = [];

        testCases.Add(new Dictionary<string, List<double>>
        {
            { "Pedro", [10, 9, 4] }
        });

        testCases.Add(new Dictionary<string, List<double>>
        {
            { "Joao", [5, 6, 5] }
        });

        testCases.Add(new Dictionary<string, List<double>>
        {
            { "Bruno", [3, 3, 3] }
        });
        testCases.Add(new Dictionary<string, List<double>>
        {
            {"Eduardo", [6,2,1]}   
        });

        List<Dictionary<string, bool>> resultado = Foo(testCases);

        foreach (var item in resultado)
        {
            foreach (var aluno in item)
            {
                Console.WriteLine($"{aluno.Key} = {(aluno.Value ? "Aprovado" : "Reprovado")}");
            }
        }
    }

    public static List<Dictionary<string, bool>> Foo(
        List<Dictionary<string, List<double>>> studentGrades)
    {
        List<Dictionary<string, bool>> resultado = [];
        const double AVERAGE = 6d;

        foreach (var grade in studentGrades)
        {
            foreach (var student in grade)
            {
                double totalNota = 0d;

                foreach (double nota in student.Value)
                {
                    totalNota += nota;
                }

                double media = totalNota / student.Value.Count;
                bool aprovado = media >= AVERAGE;

                resultado.Add(new Dictionary<string, bool>
                {
                    { student.Key, aprovado }
                });
            }
        }

        return resultado;
    }
}