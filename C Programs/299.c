#include <stdio.h>  
#include<conio.h>  
void main()  
{  
    int a=1;  
    
    for(int i=3;i>=1;i--)  
    {  
        for(int j=1;j<=i-1;j++)  
        {  
          printf(" ");  
        }  
        for(int k=1;k<=a;k++)  
        {  
            printf("*");  
        }  
        printf("\n");  
        a++;  
    }  
}