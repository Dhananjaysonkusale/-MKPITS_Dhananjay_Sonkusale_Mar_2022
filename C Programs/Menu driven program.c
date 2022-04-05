#include<stdio.h>
#include<conio.h>
void main()
{
	int choice;
	int a,b,c;
	printf("Press 1 for Additon. \n");
	printf("Press 2 for Subtraction. \n");
	printf("Press 3 for Multiplication. \n");
	printf("Press 4 for Divison. \n");
	scanf("%d",&choice);
	
	if(choice==1)
	{
	printf("Enter any two Numbers : ");
	scanf("%d %d",&a,&b);
	c=a+b;
	printf("Additon is = %d",c);
	}
	else
	if(choice==2)
	{
	printf("Enter any two Numbers : ");
	scanf("%d %d",&a,&b);
	c=a-b;
	printf("Subtraction is = %d",c);
	}
	else
	if(choice==3)
	{
	printf("Enter any two Numbers : ");
	scanf("%d %d",&a,&b);
	c=a*b;
	printf("Multiplication is = %d",c);
	}
	else
	if(choice==4)
	{
	printf("Enter any two Numbers : ");
	scanf("%d %d",&a,&b);
	c=a/b;
	printf("Division is = %d",c);
	}
	else
	{
		printf("Invalid Input !");
	}
	
	
	
	
	
	
	
	
	
	
	
		
}