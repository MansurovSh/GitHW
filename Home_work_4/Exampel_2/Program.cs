double fAkerm(double m , double n){
    
    if( (m > 0) && (n == 0))
        return fAkerm(m -1,1);
    if((m > 0) && (n > 0))
        return fAkerm((m - 1), fAkerm(m,(n - 1)));
    else
        return (n + 1);
}
Console.WriteLine($"{fAkerm(3,1)}");
