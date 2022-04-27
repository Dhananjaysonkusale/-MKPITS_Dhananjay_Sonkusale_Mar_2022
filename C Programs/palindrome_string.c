#include<stdio.h>
#include<conio.h>
#include<string.h>
void main()
{
	char name[20];
	printf("Enter Any name :");
	scanf("%s",name);
	
	strrev(name);
	
	if(name==strrev)
	{
		printf("Palindrome ");
		
	}
}