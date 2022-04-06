#include<stdio.h>
#include<conio.h>
void main()
{
	int a,t;
	printf("Enter Amount : ");
	scanf("%d",&a);
	
	t=a/100;
	printf("%d Note of 100.0\n",t);

	a=a-(t*100);
	t=a/50;
	printf("%d Note of 50.0\n",t);
	
	a=a-(t*50);
	t=a/20;
	printf("%d Note of 20.0\n",t);
	
	a=a-(t*20);
	t=a/10;
	printf("%d Note of 10.0\n",t);
	
	a=a-(t*10);
	t=a/5;
	printf("%d Note of 5.0\n",t);
	
	a=a-(t*100);
	t=a/1;
	printf("%d Note of 1.0\n",t);
}