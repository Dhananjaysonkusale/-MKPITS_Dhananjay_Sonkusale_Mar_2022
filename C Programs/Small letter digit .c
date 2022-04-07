#include<stdio.h>
#include<conio.h>
void main()
{
    int a;
    printf("Enter any character: ");
    scanf("%c", &a);

    if(a>=97&&a<=122) 
    {
        printf("'%c' is small alphabet",a);
    }
    else
    if(a>=65&&a<=90)
    {
    	printf("'%c' is Capital alphabet.",a);
	}
    else 
	if(a>=48&&a<=57)
    {
        printf("'%c' is digit.",a);
    }
    else 
    {
        printf("'%c' is special character.",a);
    }
}
