#include<stdio.h>
#include<conio.h>
void main()
{
	int num,i,fact=1;
	printf("Enter Number : ");
	scanf("%d",&num);
	
	i=num;
	while(i>=1)
	{
		fact=fact*i;
		
		i--;
	}
	printf("Factorial is %d ",fact);
}

//{
//	int num,i,fact=1;
//	printf("Enter Number : ");
//	scanf("%d",&num);
//	
//	i=1;
//	while(i<=num)
//	{
//		fact=fact*i;
//		
//		i++;
//	}
//	printf("Factorial is %d ",fact);
//}