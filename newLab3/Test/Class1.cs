namespace Test;
public class Class1
{
    /// <summary>
        /// this method calculates the root
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>

        public static double MyPow(double number, double number2) {
            double root;
            root = Math.Pow(number,3);

            Console.WriteLine("The square root of " + number + " is " + root);
            return root;
        }
        public static double MyPow2(double number, double number2, double number3) {
            double root;
            root = Math.Pow(number,4);

            Console.WriteLine("The square root of " + number + " is " + root);
            return root;
        }

}
