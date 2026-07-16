int[,] arr = new int[3, 3];
for (int i = 0; i < 3; i++) {
    for (int j = 0; j < 3; j++) {
        Console.Write ($"Enter number{i + 1}{j + 1}: ");
        int n = int.Parse (Console.ReadLine ());
        arr[i, j] = n;
    }
}
Console.WriteLine (MagicChecker (arr));

bool MagicChecker (int[,] matrix) {
    int sum = 0;
    for (int i = 0; i < 3; i++) {
        sum += matrix[i, 0];
    }
    int diagsum1 = 0;
    int diagsum2 = 0;
    List<int> sums = new List<int> ();
    for (int j = 0; j < 3; j++) {
        int rowsum = 0;
        int colsum = 0;
        for (int k = 0; k < 3; k++) {
            rowsum += matrix[j, k];
            colsum += matrix[k, j];
            if (k == j) {
                diagsum1 += matrix[j, k];
            }
            if (j == 2 - k) {
                diagsum2 += matrix[j, k];
            }
        }
        sums.Add (rowsum);
        sums.Add (colsum);
    }
    foreach (int add in sums) {
        if (add != sum) {
            return false;
        }
    }
    return true;
}
