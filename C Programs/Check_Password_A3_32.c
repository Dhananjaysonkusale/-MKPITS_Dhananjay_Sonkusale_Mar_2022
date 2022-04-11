#include<stdio.h>
#include<conio.h>
void main()
{
	int p, x=5;	

	while (x!=1)
	{
	printf("Enter password: ");
	scanf("%d",&p);	
	
	if (p==1234)
	{
		printf("Correct password");
		x=1;
    }
    else
    {
       printf("You enter Wrong password try again !");       
	}
	printf("\n");
   }

}