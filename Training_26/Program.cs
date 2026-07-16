Console.Write ("Enter Number of Days: ");
int days = int.Parse (Console.ReadLine ());
int[] arr = new int[days];
for (int i = 0; i < days; i++) {
    Console.Write ("Enter the Temperature: ");
    arr[i] = int.Parse (Console.ReadLine ());
}

int[] ans = NumberOfCoolingDays (arr);
for (int k = 0; k < ans.Length; k++) {
    //Console.WriteLine (ans[k]);
    Console.WriteLine ($"Day{k + 1}: {arr[k]} -> wait Days{ans[k]+1}");
}

int[] NumberOfCoolingDays (int[] temp) {
    int i = 0;
    int j = 1;
    int count = 0;
    int[] day = new int[temp.Length];
    while (i < j && j < temp.Length) {
        if (temp[i] < temp[j]) {  
            
            count++;
            j++;
        } 
        else if (temp[i] > temp[j]) {
            day[i] = count;
            i++;
            j = i + 1;
            count = 0;
        }
    }
    return day;
}
