#include<stdio.h>  
#include<conio.h>  
void main()  
{     
    int i, j, k, m = 1;  
    for ( i = 4; i >= 1; i--)  
    {  
        for ( j = 1; j <= m; j++)  
        {  
            printf ("  ");   
        }  
        for ( k = 1; k <= ( 2 * i - 1); k++)  
        {  
            printf ("%c ", 'A' + k - 1);   
        }  
        m++;  
        printf ("\n");  
    }  
}