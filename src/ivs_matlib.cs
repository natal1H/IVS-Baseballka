namespace ivs_matlib {
    class matlib {
        public static void Main() {
            System.Console.WriteLine("TEST FUNKCII");
            
            double n1 = 2;
            double n2 = 40;
            double res = matlib.add(n1, n2);
            System.Console.WriteLine("{0} + {1} = {2}", n1, n2, res);

            n1 = 9;
            n2 = 27;
            res = matlib.subtract(n1, n2);
            System.Console.WriteLine("{0} - {1} = {2}", n1, n2, res);

            n1 = 5;
            n2 = 7;
            res = matlib.multiply(n1, n2);
            System.Console.WriteLine("{0} * {1} = {2}", n1, n2, res);

            n1 = 99;
            n2 = 3;
            res = matlib.divide(n1, n2);
            System.Console.WriteLine("{0} / {1} = {2}", n1, n2, res);

            int num_int = 5;
            long res_fact = matlib.factorial(num_int);
            System.Console.WriteLine("{0}! = {1}", num_int, res_fact);

            double num = 0.81;
            double res_sqrt = matlib.sqrt(num);
            System.Console.WriteLine("sqrt({0}) = {1}", num, res_sqrt);

            double num_to_calc = 27;
            int root = 3;
            double res_genroot = matlib.genroot(num_to_calc, root);
            System.Console.WriteLine("genroot({0}, {1}) = {2}", num_to_calc, root, res_genroot);

            double x = 100;
            double res_log10 = matlib.log10(x);
            System.Console.WriteLine("log10({0}) = {1}", x, res_log10);
        }
        
        public static double add(double number1, double number2) {
            return number1 + number2;
        }

        public static double subtract(double number1, double number2) {
            return number1 - number2;
        }

        public static double multiply(double number1, double number2) {
            return number1 * number2;
        }

        public static double divide(double number1, double number2) {
            return number1 / number2;
        }

        public static long factorial(int number) {
            long res = 1;
            for (int i = 2; i <= number; i++) {
                res = res * i;
            }
            return res;
        }

        public static double square(double number) {
            return number * number;
        }

        public static double power(double number, int exp) {
            return System.Math.Pow(number, exp);
        }

        public static double sqrt(double number) {
            return System.Math.Sqrt(number);
        }

        public static double genroot(double number, int root) {
            return System.Math.Pow(number, 1.0 / root);
        }

        public static double log10(double number) {
            return System.Math.Log10(number);
        }
    }
}