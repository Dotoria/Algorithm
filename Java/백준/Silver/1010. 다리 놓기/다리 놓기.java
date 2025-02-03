import java.util.Scanner;

class Main {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        int cases = scanner.nextInt();
        
        for (int i = 0; i < cases; i++) {
            int n = scanner.nextInt();
            int m = scanner.nextInt();
            
            // mCn
            double result = 1;
            
            for (int j = m; j > 0; j--) {
                if (m-n < j) { result *= j; }
                if (j < n+1) { result /= j; }
            }
            System.out.println("" + (int)result);
        }
    }
}