class Result
{

    /*
     * Complete the 'solve' function below.
     *
     * The function accepts following parameters:
     *  1. DOUBLE meal_cost
     *  2. INTEGER tip_percent
     *  3. INTEGER tax_percent
     */

    public static void solve(double meal_cost, int tip_percent, int tax_percent)
    {
        double tip =  meal_cost/100*tip_percent ;
        double tax =  meal_cost/100*tax_percent ;
        string  cost_meal = Convert.ToString(meal_cost + tip + tax);
        Console.WriteLine("Total meal cost:" + cost_meal);
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Meal Price?");
        double meal_cost = Convert.ToDouble(Console.ReadLine().Trim());
        System.Console.WriteLine("Tip Percetange?");
        int tip_percent = Convert.ToInt32(Console.ReadLine().Trim());
        System.Console.WriteLine("Tax Percetange?");
        int tax_percent = Convert.ToInt32(Console.ReadLine().Trim());

        Result.solve(meal_cost, tip_percent, tax_percent);
    }
}
