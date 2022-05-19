#include<stdio.h>
#include<conio.h>
void main() 

{
    int j, a = 'D';
    for (int i = 4; i >= 1; i--) 
    {
        for (int l = 0; l < 4 - i; l++)
            printf("  ");
        for (j = i; j <= 2 * i - 1; j++)
            printf("%c ", a);
        for (j = 0; j < i - 1; j++)
            printf("%c ", a);
        a--;
        printf("\n");
        }
}