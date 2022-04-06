#include<stdio.h>
#include<conio.h>
void main()
{
	int p,q,r,s;
	printf("Enter any 1st integer =");
	scanf("%d",&p);
	printf("Enter any 2nd integer =");
	scanf("%d",&q);
	printf("Enter any 3rd integer =");
	scanf("%d",&r);
	printf("Enter any 4th integer =");
	scanf("%d",&s);
	
	if((r>0)&&(s>0)&&(p%2==0)&&(q>r)&&(s>p)&&((r+s)>(p+q)))
	{
		printf("Correct Value ! ");
	}
	else
	{
		printf("Wrong Value !");
	}
	
}