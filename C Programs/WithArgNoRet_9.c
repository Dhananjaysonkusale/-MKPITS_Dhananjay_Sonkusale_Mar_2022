#include<stdio.h>
#include<conio.h>
void fun1(int b[])
{
	int i;
	int sum=0;

	
	for(i=0;i<=4;i++)
	{
		sum=sum+b[i];
	}
	printf("%d",sum);

}
void main()
{
	int i,a[4];
	printf("Enter Any 5 number :\n");
	for(i=0;i<=4;i++)
	{
		printf("Enter Number : ");
		scanf("%d",&a[i]);
	}
	fun1(a);
}