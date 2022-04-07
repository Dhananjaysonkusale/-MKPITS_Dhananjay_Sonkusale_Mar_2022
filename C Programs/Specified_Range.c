#include<stdio.h>
#include<conio.h>
void main()
{
	int a;
	printf("Enter an integer: "); 
	scanf("%d", &a);
	if(a>=0 && a<=20) 
	{
		printf("Range between (0,20)\n");
	} 
	else if(a>=21 && a<=40) 
	{
		printf("Range between (21,40)\n");
	} 
	else if(a>=41 && a<= 60)
	{
		printf("Range between (41,60)\n");
	}
	else if(a>61 && a<=80)
	{
		printf("Range between (61,80)\n");
	}
	else
	{
		printf("Error !!!!!!!");
	}
}