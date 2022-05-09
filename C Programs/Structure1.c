#include<stdio.h>
#include<conio.h>

struct student
{
	int id;
	char name[20];
	
};

void main()
{
	struct student s1;
	
	printf("Enter Student Id : ");
	scanf("%d",&s1.id);
	printf("Enter Student Name : ");
	scanf("%s",&s1.name);
	
	printf("Student Id = %d  \n",s1.id);
	printf("Student Name = %s \n",s1.name);
}
