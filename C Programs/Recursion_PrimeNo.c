#include<stdio.h>
#include<conio.h>
int Prime(int n1);
int i;
int main()
{

    int n1,primeNo;

	printf(" Enter any number : ");
    scanf("%d",&n1);
    
    i = n1/2;

    primeNo = Prime(n1);

   	if(primeNo==1)
    {
        printf(" %d is a prime number.",n1);
   	}
   else
   {
      printf(" %d is not a prime number. \n",n1);
   }
   return 0;
}

int Prime(int n1)
{
    if(i==1)
    {
        return 1;
    }
    else if(n1%i==0)
    {
        return 0;
    }     
    else
    {
        i = i-1; 
        Prime(n1);
    }
}