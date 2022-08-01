

static int[] RandomArray() {
    // initialize new array of ints with a length of 10
    int[] newArray = new int[10];
    // create new int variable to hold the sum of all values in array
    int sum = 0;
    // initialize Random class to create random numbers
    Random rand = new Random();

    // for loop to loop through the indeces of array and assign random integer between 5 and 25 to each index
    for (int x = 0; x < newArray.Length; x++) {
        int newVal = rand.Next(5, 25);
        newArray[x] = newVal;
    }
    // write the max and min values to console
    Console.WriteLine("Max Value:" + newArray.Max());
    Console.WriteLine("Min Value:" + newArray.Min());


    // foreach loop to go through array and add all values together to get the sum
    foreach (int val in newArray) {
        sum += val;
    }

    // write line to console with the sum of all values
    Console.WriteLine("Sum is:" + sum);

    // for loop to go through array and print all the values of each index
    for (int i = 0; i < newArray.Length; i++) {
        Console.WriteLine("index " + i + " value: " + newArray[i]);
    }

    // return the array we created
    return newArray;
}

int[] array = RandomArray();

Console.WriteLine(array);

// function to simulate a coin toss
static string TossCoin() {
    // intializze the Random class
    Random rand = new Random();
    // create a coinflip int with a random value of either 0 or 1
    int coinflip = rand.Next(0,2);
    // create two strings, one for heads and one for tails
    string heads = "heads";
    string tails = "tails";

    // if statement to check if we got a 0 or 1 and return either heads or tails depending on which we get
    if (coinflip == 0) {
        Console.WriteLine(heads);
        return heads;
    }
    else {
        Console.WriteLine(tails);
        return tails;
    }

}

TossCoin();

// function to toss a coin a specific number of times
static Double TossMultipleCoins(int num) {
    // create two variables, one to store the number of heads tosses and one for tails tosses
    Double heads = 0;
    Double tails = 0;

    // for loop will toss the coin the number of tims specified by the num argument
    for (int i = 0; i < num; i++) {
        // create a string to store value returned by TossCoin function
        string cointoss = TossCoin();
        // print the result of the coin toss
        Console.WriteLine("cointoss is: " + cointoss);

        // if statement to check if it was a heads or tails toss and add 1 to the variable storing number of those tosses
        if (cointoss == "heads") {
            heads += 1;
        }
        else {
            tails += 1;
        }
    }

    // create a doulbe to store ratio of heads tosses to total number of tosses
    Double ratio = heads/num;
    Console.WriteLine("Ratio of heads to total tosses:" + ratio);
    // return the ratio
    return ratio;

}

TossMultipleCoins(10);


