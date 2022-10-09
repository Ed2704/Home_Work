double SlowFibonacci(int n)
{
    if (n == 1 || n == 2)
        return 1;
    else
        return SlowFibonacci(n - 1) + SlowFibonacci(n - 2);
}


double FastFibonacci(int n, int sum = 1, int previousSum = 0)
{
    if (n == 0) 
        return previousSum;
    else
        return FastFibonacci(n - 1, sum + previousSum, sum);
}
 
