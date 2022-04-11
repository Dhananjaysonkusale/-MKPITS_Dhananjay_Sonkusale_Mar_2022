#include<stdio.h>
#include<conio.h>
void main()
{
	int a,b;
	printf("Enter Number in pair i.e (1,2): \n");
    scanf("%d%d",&a,&b);

    if(a<b)
    {
        printf("Number is in Ascending order !");
    }
    else
    {
        printf("Number is in Descending order !");
    }

}