// See https://aka.ms/new-console-template for more information
// Lista de pesos
        List<int> pesos = [5, 3, 2, 5, 6, 1, 4, 7, 9];

        // Valor objetivo
        int kilogramos = 10;

        // Lista para almacenar los pares de sumas
        List<Tuple<int, int>> paresEncontrados = [];

        // Recorrer la lista de pesos
        for (int i = 0; i < pesos.Count; i++)
        {
            int numeroActual = pesos[i];
            int indiceActual = i;

            // Buscar un par complementario
            for (int j = indiceActual + 1; j < pesos.Count; j++)
            {
                int suma = numeroActual + pesos[j];

                // Si la suma es igual a kilogramos, agregar el par a la lista
                if (suma == kilogramos)
                {
                    paresEncontrados.Add(new Tuple<int, int>(numeroActual, pesos[j]));
                }
            }
        }

        // Mostrar los pares encontrados
        foreach (Tuple<int, int> par in paresEncontrados.Distinct())
        {
            Console.WriteLine("({0}, {1})", par.Item1, par.Item2);
            
        }
        Console.WriteLine("There are {0} pairs of packages", paresEncontrados.Distinct().Count());

