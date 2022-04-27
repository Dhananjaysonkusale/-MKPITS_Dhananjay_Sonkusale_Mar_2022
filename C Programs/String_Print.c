#include<stdio.h>
#include<conio.h>
void main()
{
	char i, name[10];
	printf("Enter Any Name: ");
	scanf("%s",name);
	for(i=0;i<=10;i++)
	//for removing garbage value 
	
	//for(i=0;name[i]!='\0';i++)
	{
		printf("%c ",name[i]);
	}
}
