#include<stdio.h>
#include<conio.h>
void main()
{
	int a,b;
	
	printf("Enter Any Two Value: \n");
	scanf(" %d %d",&a,&b);
	
	a=a+b;
	b=a-b;
	a=a-b;
	
	printf("After Swapping : \n %d \n %d  ",a,b);
	
}


//{
//	int a,b;
//	
//	printf("Enter Any Two Value: \n");
//	scanf(" %d %d",&a,&b);
//	
//	a=a*b;
//	b=a/b;
//	a=a/b;
//	
//	printf("After Swapping : \n %d \n %d  ",a,b);
//	
//}

