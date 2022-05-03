#include<stdio.h>
#include<conio.h>
//void add();

void add()
{
	int n1,n2,res;
	printf("Enter any 2 num :\n ");
	scanf("%d %d",&n1,&n2);
	
	res=n1+n2;
	
	printf("Sum = %d \n\n",res);
}
void sub()
{
	int n1,n2,res;
	printf("Enter any 2 num : \n ");
	scanf("%d %d",&n1,&n2);
	
	res=n1-n2;
	
	printf("Sub= %d \n\n",res);
}
void mul()
{
	int n1,n2,res;
	printf("Enter any 2 num : \n ");
	scanf("%d %d",&n1,&n2);
	
	res=n1*n2;
	
	printf("Mul = %d \n\n",res);
}
void div()
{
	int n1,n2,res;
	printf("Enter any 2 num: \n ");
	scanf("%d %d",&n1,&n2);
	
	res=n1/n2;
	
	printf("Div= %d \n\n",res);
}
void main()
{
	add();
	sub();
	mul();
	div();
}